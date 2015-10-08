using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Tehtava8
{
    public class Feedback
    {
        [XmlElement (ElementName = "pvm")]
        public string pvm { get; set; }

        [XmlElement (ElementName = "tekija")]
        public string name { get; set; }

        [XmlElement (ElementName = "opittu")]
        public string learned { get; set; }

        [XmlElement (ElementName = "haluanoppia")]
        public string wantToLearn { get; set; }

        [XmlElement (ElementName = "hyvaa")]
        public string good { get; set; }

        [XmlElement (ElementName = "parannettavaa")]
        public string improvement { get; set; }

        [XmlElement(ElementName = "muuta")]
        public string other { get; set; }
    }
}
