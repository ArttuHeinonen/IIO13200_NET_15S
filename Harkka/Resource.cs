using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Harkka
{
    [XmlRoot("Resource")]
    public class Resource
    {
        [XmlAttribute("Name")]
        public string name { get; set; }
        [XmlElement("Value")]
        public float value { get; set; }
        [XmlElement("MaxValue")]
        public float maxValue { get; set; }
        [XmlElement("Increment")]
        public float increment { get; set; }
        [XmlElement("IsAvailable")]
        public bool isAvailable { get; set; }

        public Resource(string name, float value, float maxValue, bool isAvailable)
        {
            this.name = name;
            this.value = value;
            this.maxValue = maxValue;
            this.increment = 0;
            this.isAvailable = isAvailable;
        }

        
    }
}
