using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataBase
{
    class DOM : IStrategy
    {
        public static string Name;
        public static string Year;
        public static string Ganre;
        public static string RunningTime;
        public static string Country;
        public static string Rate;
        static List<Films> result = new List<Films>();
        public List<Films> Search(Films f, string path)
        {
            result.Clear();
            Name = f.Name;
            Year = f.Year;
            Ganre = f.Ganre;
            RunningTime = f.RunningTime;
            Country = f.Country;
            Rate = f.Rate;
            parsingXmlDocument(path);
            return result;
        }
        private static void parsingXmlDocument(string path)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@path);
            RecurseNodes(xmlDoc.DocumentElement, 0);
        }
      
        private static void RecurseNodes(XmlNode node, int level)
        {
            Films res = new Films();
            if (level == 1)
            {
                int f = 0;
                foreach (XmlAttribute attr in node.Attributes)
                {
                    if (attr.Name == "Name")
                    {
                        if (Name != null && Name != attr.Value)
                        {
                            f = 1;
                            break;
                        }
                        res.Name = attr.Value;
                    }
                    if (attr.Name == "Year")
                    {
                        if (Year != null && Year != attr.Value)
                        {
                            f = 1;
                            break;
                        }
                        res.Year = attr.Value;
                    }
                    if (attr.Name == "Ganre")
                    {
                        if (Ganre != null && Ganre != attr.Value)
                        {
                            f = 1;
                            break;
                        }
                        res.Ganre = attr.Value;
                    }
                    if (attr.Name == "RunningTime")
                    {
                        if (RunningTime != null && RunningTime != attr.Value)
                        {
                            f = 1;
                            break;
                        }
                        res.RunningTime = attr.Value;                    
                    }
                    if (attr.Name == "Country")
                    {
                        if (Country != null && Country != attr.Value)
                        {
                            f = 1;
                            break;
                        }
                        res.Country = attr.Value;
                    }
                    if (attr.Name == "Rate")
                    {
                        if (Rate != null && Rate != attr.Value)
                        {
                            f = 1;
                            break;
                        }
                        res.Rate = attr.Value;
                    }
                }
                if(f == 0)
                {
                    result.Add(res);
                }
            }
            foreach(XmlNode n in node.ChildNodes)
            {
                RecurseNodes(n, level + 1);
            }

        }
    }
}
