using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

namespace DataBase
{
    public partial class Form1 : Form
    {
        string path = @"Films.xml";
        string result = @"Result.xml";
        string htmlPath = @"Films.html";
        string xslPath = @"Films.xsl";
        List<Films> res;
        public Form1()
        {
            InitializeComponent();
            fillBox();
            radioButtonLINQtoXML.Checked = true;
        }
        public void fillBox()
        {
            IStrategy p = new LINQ();
            List<Films> res = p.Search(new Films(), path);
            List<string> names = new List<string>();
            List<string> years = new List<string>();
            List<string> ganres = new List<string>();
            List<string> runningTimes = new List<string>();
            List<string> countries = new List<string>();
            List<string> rates = new List<string>();
            foreach(Films item in res)
            {
                if (!names.Contains(item.Name))
                {
                    names.Add(item.Name);
                }
                if (!years.Contains(item.Year))
                {
                    years.Add(item.Year);
                }
                if (!ganres.Contains(item.Ganre))
                {
                    ganres.Add(item.Ganre);
                }
                if (!runningTimes.Contains(item.RunningTime))
                {
                    runningTimes.Add(item.RunningTime);
                }
                if (!countries.Contains(item.Country))
                {
                    countries.Add(item.Country);
                }
                if (!rates.Contains(item.Rate))
                {
                    rates.Add(item.Rate);
                }
            }
            comboBoxName.Items.AddRange(names.ToArray());
            comboBoxName.Enabled = false;
            comboBoxYear.Items.AddRange(years.ToArray());
            comboBoxYear.Enabled = false;
            comboBoxGanre.Items.AddRange(ganres.ToArray());
            comboBoxGanre.Enabled = false;
            comboBoxRunningTime.Items.AddRange(runningTimes.ToArray());
            comboBoxRunningTime.Enabled = false;
            comboBoxCountry.Items.AddRange(countries.ToArray());
            comboBoxCountry.Enabled = false;
            comboBoxRate.Items.AddRange(rates.ToArray());
            comboBoxRate.Enabled = false;
        }

        private Films Search()
        {
            Films film = new Films();
            if (checkBoxName.Checked)
            {
                film.Name = Convert.ToString(comboBoxName.Text);
            }
            if (checkBoxYear.Checked)
            {
                film.Year = Convert.ToString(comboBoxYear.Text);
            }
            if (checkBoxGanre.Checked)
            {
                film.Ganre = Convert.ToString(comboBoxGanre.Text);
            }
            if (checkBoxRunningTime.Checked)
            {
                film.RunningTime = Convert.ToString(comboBoxRunningTime.Text);
            }
            if (checkBoxCountry.Checked)
            {
                film.Country = Convert.ToString(comboBoxCountry.Text);
            }
            if (checkBoxRate.Checked)
            {
                film.Rate = Convert.ToString(comboBoxRate.Text);
            }
            return film;
        }
        private void ParseXml()
        {
            Films MyFilm = Search();
            if (radioButtonDOM.Checked)
            {
                IStrategy parser = new DOM();
                res = parser.Search(MyFilm, path);
                Output(res);
            }
            else if (radioButtonSAX.Checked)
            {
                IStrategy parser = new SAX();
                res = parser.Search(MyFilm, path);
                Output(res);
            }
            else if (radioButtonLINQtoXML.Checked)
            {
                IStrategy parser = new LINQ();
                res = parser.Search(MyFilm, path);
                Output(res);
            }
            else
            {
                MessageBox.Show("select a search method", "Warninng!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Output(List<Films> list)
        {
            richTextBox1.Clear();
            int i = 1;
            foreach(Films item in list)
            {
                richTextBox1.AppendText(i.ToString() + "\n");
                richTextBox1.AppendText("Name: " + item.Name + "\n");
                richTextBox1.AppendText("Year: " + item.Year + "\n");
                richTextBox1.AppendText("Ganre: " + item.Ganre + "\n");
                richTextBox1.AppendText("Running Time: " + item.RunningTime + "\n");
                richTextBox1.AppendText("Country: " + item.Country + "\n");
                richTextBox1.AppendText("Rate: " + item.Rate + "\n");
                richTextBox1.AppendText("----------------------------------------------\n");
                i++;
            }
        }
        private void Clear()
        {
            richTextBox1.Clear();
            radioButtonDOM.Checked = false;
            radioButtonLINQtoXML.Checked = false;
            radioButtonSAX.Checked = false;
            comboBoxName.Text = null;
            comboBoxYear.Text = null;
            comboBoxGanre.Text = null;
            comboBoxRunningTime.Text = null;
            comboBoxCountry.Text = null;
            comboBoxRate.Text = null;
            checkBoxName.Checked = false;
            checkBoxYear.Checked = false;
            checkBoxGanre.Checked = false;
            checkBoxRunningTime.Checked = false;
            checkBoxCountry.Checked = false;
            checkBoxRate.Checked = false;
        }
        private void Transform()
        {
            XslCompiledTransform xct = new XslCompiledTransform();
            xct.Load(@xslPath);
            CreateXml();
            string fXML = @result;
            string fHTML = @htmlPath;
            xct.Transform(fXML, fHTML);
            DialogResult = MessageBox.Show("database transformed to " + fHTML, "Transforming", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void CreateXml()
        {
            var xmlDoc = new XmlDocument();
            XmlElement el;
            xmlDoc.AppendChild(xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null));
            el = xmlDoc.CreateElement("Films");
            xmlDoc.AppendChild(el);
            foreach(Films f in res)
            {
                XmlElement childelm;
                XmlAttribute childattr;
                childelm = xmlDoc.CreateElement("Film");
                childattr = xmlDoc.CreateAttribute("Name");
                childattr.Value = f.Name;
                childelm.Attributes.Append(childattr);
                childattr = xmlDoc.CreateAttribute("Year");
                childattr.Value = f.Year; 
                childelm.Attributes.Append(childattr);
                childattr = xmlDoc.CreateAttribute("Ganre");
                childattr.Value = f.Ganre;
                childelm.Attributes.Append(childattr);
                childattr = xmlDoc.CreateAttribute("RunningTime");
                childattr.Value = f.RunningTime;
                childelm.Attributes.Append(childattr);
                childattr = xmlDoc.CreateAttribute("Country");
                childattr.Value = f.Country;
                childelm.Attributes.Append(childattr);
                childattr = xmlDoc.CreateAttribute("Rate");
                childattr.Value = f.Rate;
                childelm.Attributes.Append(childattr);
                el.AppendChild(childelm);
            }
            xmlDoc.Save(@result);

        }
        private void checkBoxName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxName.Checked)
            {
                comboBoxName.Enabled = true;
            }
            else
            {
                comboBoxName.Enabled = false;
            }
        }

        private void checkBoxYear_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxYear.Checked)
            {
                comboBoxYear.Enabled = true;
            }
            else
            {
                comboBoxYear.Enabled = false;
            }
        }

        private void checkBoxGanre_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGanre.Checked)
            {
                comboBoxGanre.Enabled = true;
            }
            else
            {
                comboBoxGanre.Enabled = false;
            }
        }

        private void checkBoxRunningTime_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRunningTime.Checked)
            {
                comboBoxRunningTime.Enabled = true;
            }
            else
            {
                comboBoxRunningTime.Enabled = false;
            }
        }

        private void checkBoxCountry_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCountry.Checked)
            {
                comboBoxCountry.Enabled = true;
            }
            else
            {
                comboBoxCountry.Enabled = false;
            }
        }

        private void checkBoxRate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRate.Checked)
            {
                comboBoxRate.Enabled = true;
            }
            else
            {
                comboBoxRate.Enabled = false;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ParseXml();
        }

        private void buttonTransformToHTML_Click(object sender, EventArgs e)
        {
            Transform();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Close the program?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void ToolStripMenuItemInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program implements the search for information about movies according to the specified criteria in three ways (DOM, SAX, LINQ). \n Clear - clears the search parameters. \n Transform to html - transforms information into an html file");
        }
    }

}
