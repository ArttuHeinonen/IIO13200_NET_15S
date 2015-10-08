using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tehtava8
{
    class BLFeedback
    {
        private string filePath = Tehtava8.Properties.Settings.Default.filePath.ToString();

        public List<Feedback> getDataFromXML()
        {
            List<Feedback> list = new List<Feedback>();
            XElement xmlDoc = new XElement(XDocument.Load(filePath).Root);
            list = (from el in xmlDoc.Descendants("palaute")
                    select new Feedback
                    {
                        pvm = el.Element("pvm").Value,
                        name = el.Element("tekija").Value,
                        learned = el.Element("opittu").Value,
                        wantToLearn = el.Element("haluanoppia").Value,
                        good = el.Element("hyvaa").Value,
                        improvement = el.Element("parannettavaa").Value,
                        other = el.Element("muuta").Value,
                    }).ToList();

            return list;
        }

        public void pushDataToXML(DateTime today, string name, string learned, string wantToLearn, string good, string imporovement, string other)
        {
            XDocument doc = XDocument.Load(@filePath);

            XElement feedback = new XElement("palaute",
            new XElement("pvm", string.Format("{0:yyyyMMdd}", today)),
            new XElement("tekija", name),
            new XElement("opittu", learned),
            new XElement("haluanoppia", wantToLearn),
            new XElement("hyvaa", good),
            new XElement("parannettavaa", imporovement),
            new XElement("muuta", other));

            doc.Root.Add(feedback);
            doc.Save(filePath);
        }
    }
}
