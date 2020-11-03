using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DataBase
{
    class LINQ : IStrategy
    {
        public List<Films> Search(Films f, string path)
        {
            List<Films> results = new List<Films>();
            var doc = XDocument.Load(@path);
            var result = (from film in doc.Descendants("Film")
                          where
                          ((f.Name == null || f.Name == film.Attribute("Name").Value) &&
                          (f.Year == null || f.Year == film.Attribute("Year").Value) &&
                          (f.Ganre == null || f.Ganre == film.Attribute("Ganre").Value) &&
                          (f.RunningTime == null || f.RunningTime == film.Attribute("RunningTime").Value) &&
                          (f.Country == null || f.Country == film.Attribute("Country").Value) &&
                          (f.Rate == null || f.Rate == film.Attribute("Rate").Value)
                          )
                          select film).ToList();
            foreach(var item in result)
            {
                Films fl = new Films();
                fl.Name = item.Attribute("Name").Value;
                fl.Year = item.Attribute("Year").Value;
                fl.Ganre = item.Attribute("Ganre").Value;
                fl.RunningTime = item.Attribute("RunningTime").Value;
                fl.Country = item.Attribute("Country").Value;
                fl.Rate = item.Attribute("Rate").Value;
                results.Add(fl);
            }
            return results;
        }
    }
}
