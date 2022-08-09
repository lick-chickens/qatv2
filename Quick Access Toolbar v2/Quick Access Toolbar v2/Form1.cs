using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.InteropServices;

namespace Quick_Access_Toolbar_v2
{
    public partial class Form1 : Form
    {
        /*            Vars            */
        private Point[] _sizes = {
            new Point(47, 71),
            new Point(174, 323),
            new Point(394, 323)
        };
        private bool _toggled = false;
        private bool _toggleBuffer = false;
        private ArrayList Categories = new ArrayList();

        public Form1()
        {
            InitializeComponent();
            Keys k = Keys.F13;
            WindowsShell.RegisterHotKey(this, k);
            LoadChanges();
            LoadLists();
        }

        [DllImport("user32.dll", EntryPoint = "SetForegroundWindow")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WindowsShell.WM_HOTKEY)
            {
                SetForegroundWindow(this.Handle);
                resize(1);
                if (lb_category.Items.Count != 0) lb_category.SelectedIndex = 0;
            }
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
            lb_category.Items.Clear();
            lb_items.Items.Clear();
            foreach (Category c in Categories)
            {
                lb_category.Items.Add(c.Name);
            }
        }

        private void LoadItems()
        {
            if (lb_category.SelectedIndex != -1)
            {
                lb_items.Items.Clear();
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                foreach (Item i in ((Category)Categories[lb_category.SelectedIndex]).Items)
                {
                    lb_items.Items.Add(i.Name);
                }
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            }
        }

        private void resize(int step)
        {
            this.Size = (Size)_sizes[step];
            switch (step)
            {
                case 0:
                    _toggled = false;
                    pb_expand.BackgroundImage = Properties.Resources.cursor;
                    pb_expand.Cursor = Cursors.PanSouth;
                    pb_expand.Refresh();
                    _toggleBuffer = true;
                    lb_items.ClearSelected();
                    lb_category.ClearSelected();
                    _toggleBuffer = false;
                    break;
                case 1:
                    _toggled = true;
                    lb_category.Focus();
                    pb_expand.BackgroundImage = Properties.Resources.close;
                    pb_expand.Cursor = Cursors.PanNorth;
                    pb_expand.Refresh();
                    break;
                case 2:
                    _toggled = true;
                    pb_expand.BackgroundImage = Properties.Resources.close;
                    pb_expand.Cursor = Cursors.PanNorth;
                    pb_expand.Refresh();
                    LoadItems();
                    break;
                default:
                    throw new Exception();
            }
        }

        public void refresh()
        {
            LoadChanges();
            LoadLists();
        }

        private void cpClip()
        {
            Clipboard.SetText(((Item)((Category)Categories[lb_category.SelectedIndex]).Items[lb_items.SelectedIndex]).Link);
            resize(0);
            SendKeys.Send("%{Tab}");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            resize(0);
        }

        private void pb_expand_Click(object sender, EventArgs e)
        {
            resize(_toggled ? 0 : 1);
        }

        private void lb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_toggleBuffer)
            {
                resize(2);
            }
        }

        private void lb_category_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                e.SuppressKeyPress = true;
                if (lb_items.SelectedIndex != -1 && lb_items.Items.Count == 0) lb_items.SelectedIndex = 0;
                lb_items.Focus();
            }
        }

        private void lb_items_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                e.SuppressKeyPress = true;
                if (lb_category.SelectedIndex != -1 && lb_category.Items.Count == 0) lb_category.SelectedIndex = 0;
                lb_category.Focus();
            } else if (e.KeyCode == Keys.Enter)
            {
                cpClip();
            }
        }

        private void lb_items_DoubleClick(object sender, EventArgs e)
        {
            if (lb_items.SelectedIndex != -1) cpClip();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            Form2 settings = new Form2(this);
            settings.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            WindowsShell.UnregisterHotKey(this);
        }
    }

    public class WindowsShell
    {
        #region fields
        public static int MOD_ALT = 0x1;
        public static int MOD_CONTROL = 0x2;
        public static int MOD_SHIFT = 0x4;
        public static int MOD_WIN = 0x8;
        public static int WM_HOTKEY = 0x312;
        #endregion

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private static int keyId;
        public static void RegisterHotKey(Form f, Keys key)
        {
            int modifiers = 0;

            if ((key & Keys.Alt) == Keys.Alt)
                modifiers = modifiers | WindowsShell.MOD_ALT;

            if ((key & Keys.Control) == Keys.Control)
                modifiers = modifiers | WindowsShell.MOD_CONTROL;

            if ((key & Keys.Shift) == Keys.Shift)
                modifiers = modifiers | WindowsShell.MOD_SHIFT;

            Keys k = key & ~Keys.Control & ~Keys.Shift & ~Keys.Alt;
            keyId = f.GetHashCode(); // this should be a key unique ID, modify this if you want more than one hotkey
            RegisterHotKey((IntPtr)f.Handle, keyId, (int)(uint)modifiers, (int)(uint)k);
        }

        private delegate void Func();

        public static void UnregisterHotKey(Form f)
        {
            try
            {
                UnregisterHotKey(f.Handle, keyId); // modify this if you want more than one hotkey
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
