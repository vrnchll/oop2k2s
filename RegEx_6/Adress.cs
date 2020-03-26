using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab5
{
    [Serializable]
    [XmlRoot(Namespace = "Adresses")]
    [XmlType("Adress")]
    public class Adress
    {
        [XmlElement(ElementName = "City")]
        public string City { get; set; }
        [XmlElement(ElementName = "Street")]
        public string Street { get; set; }
        [XmlElement(ElementName = "House")]
        public int House { get; set; }
        [XmlElement(ElementName = "Apartment")]
        public int Apartment { get; set; }

        public override string ToString()
        {
            return $"{City}, {Street}, {House}, {Apartment}";
        }
    }
}
