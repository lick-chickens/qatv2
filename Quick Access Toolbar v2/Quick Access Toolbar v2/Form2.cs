using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Quick_Access_Toolbar_v2
{
    public partial class Form2 : Form
    {
        private ArrayList Categories = new ArrayList();

        private Form1 parent;

        public Form2(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private string SerializeArrayList(ArrayList obj)
        {
            XmlDocument doc = new XmlDocument();
            XmlSerializer serializer = new XmlSerializer(typeof(ArrayList), new Type[] { typeof(Category), typeof(Item) });
            using (MemoryStream stream = new System.IO.MemoryStream())
            {
                try
                {
                    serializer.Serialize(stream, obj);
                    stream.Position = 0;
                    doc.Load(stream);
                    return doc.InnerXml;
                }
                catch { }
            }
            return string.Empty;
        }

        private void SaveChanges()
        {
            StreamWriter sw = new StreamWriter("./data.txt");
            sw.WriteLine(SerializeArrayList(Categories));
            sw.Close();
        }

        private void LoadChanges()
        {
            string? line = null;
            try
            {
                StreamReader sr = new StreamReader("./data.txt");
                line = sr.ReadLine();
                sr.Close();
                if (line != null)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ArrayList), new Type[] { typeof(Category), typeof(Item) });
                    object? result = null;

                    using (TextReader reader = new StringReader(line))
                    {
                        result = serializer.Deserialize(reader);
                    }

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    Categories = (ArrayList)result;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                }
            }
            catch { }
        }

        private void LoadLists()
        {
            lb_categories.Items.Clear();
            lb_items.Items.Clear();
            foreach (Category c in Categories)
            {
                lb_categories.Items.Add(c.Name);
            }
        }

        private void LoadItems()
        {
            if (lb_categories.SelectedIndex != -1)
            {
                lb_items.Items.Clear();
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                foreach (Item i in ((Category)Categories[lb_categories.SelectedIndex]).Items)
                {
                    lb_items.Items.Add(i.Name);
                }
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            }
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            LoadChanges();
            LoadLists();
        }

        private void btn_categories_add_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Category name", "Name?", "Type here").ToString();
            if (input.Trim().Length > 0)
            {
                Categories.Add(new Category(input));
                LoadLists();
                SaveChanges();
            }
        }

        private void btn_categories_remove_Click(object sender, EventArgs e)
        {
            if (lb_categories.SelectedIndex != -1)
            {
                Categories.RemoveAt(lb_categories.SelectedIndex);
                SaveChanges();
                LoadLists();
            }
        }

        private void btn_items_add_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Item name", "Name?", "Type here").ToString();
            string link = Microsoft.VisualBasic.Interaction.InputBox("Link address", "Link?", "Paste here").ToString();
            if (input.Trim().Length > 0)
            {
                if (lb_categories.SelectedIndex != -1)
                {
                    ((Category)Categories[lb_categories.SelectedIndex]).Items.Add(new Item(input, link));
                    SaveChanges();
                }
                LoadItems();
            }
        }

        private void btn_items_remove_Click(object sender, EventArgs e)
        {
            if (lb_items.SelectedIndex != -1)
            {
                ((Category)Categories[lb_categories.SelectedIndex]).Items.RemoveAt(lb_items.SelectedIndex);
                SaveChanges();
                LoadLists();
            }
        }

        private void lb_categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.refresh();
        }
    }
}
