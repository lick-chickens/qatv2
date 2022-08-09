using System;
using System.Collections;
using System.Xml.Serialization;

namespace Quick_Access_Toolbar_v2
{
    [Serializable]
    [XmlType(TypeName = "Category")]
    public class Category
    {
        public string Name { get; set; }
        public ArrayList Items = new ArrayList();

        public Category()
        {
            Name = "";
        }

        public Category(string name)
        {
            Name = name;
        }
    }

    [Serializable]
    [XmlType(TypeName = "Item")]
    public class Item
    {
        public string Name { get; set; }
        public string Link { get; set; }

        public Item()
        {
            Name = "";
            Link = "";
        }

        public Item(string name, string link)
        {
            Name = name;
            Link = link;
        }
    }
}
