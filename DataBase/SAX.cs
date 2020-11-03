using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataBase
{
    class SAX : IStrategy
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
            Parsing(path);
            return result;
        }
        private static void Parsing(string path)
        {
            int f = 0;
            var xmlReader = new XmlTextReader(@path);
            while (xmlReader.Read())
            {
                f = 0;
                if (xmlReader.HasAttributes)
                {
                    Films res = new Films();
                    while (xmlReader.MoveToNextAttribute())
                    {
                        if (xmlReader.Name == "Name")
                        {
                            if (Name != null && Name != xmlReader.Value)
                            {
                                f = 1;
                                break;
                            }
                            res.Name = xmlReader.Value;
                        }
                        if (xmlReader.Name == "Year")
                        {
                            if (Year != null && Year != xmlReader.Value)
                            {
                                f = 1;
                                break;
                            }
                            res.Year = xmlReader.Value;
                        }
                        if (xmlReader.Name == "Ganre")
                        {
                            if (Ganre != null && Ganre != xmlReader.Value)
                            {
                                f = 1;
                                break;
                            }
                            res.Ganre = xmlReader.Value;
                        }
                        if (xmlReader.Name == "RunningTime")
                        {
                            if (RunningTime != null && RunningTime != xmlReader.Value)
                            {
                                f = 1;
                                break;
                            }
                            res.RunningTime = xmlReader.Value;
                        }
                        if (xmlReader.Name == "Country")
                        {
                            if (Country != null && Country != xmlReader.Value)
                            {
                                f = 1;
                                break;
                            }
                            res.Country = xmlReader.Value;
                        }
                        if (xmlReader.Name == "Rate")
                        {
                            if (Rate != null && Rate != xmlReader.Value)
                            {
                                f = 1;
                                break;
                            }
                            res.Rate = xmlReader.Value;
                        }
                    }
                    if (f == 0 && res.Name != null && res.Year != null && res.Ganre != null && res.RunningTime != null && res.Country != null && res.Rate != null)
                    {
                        result.Add(res);
                    }
                }
            }
        }
    }
}
