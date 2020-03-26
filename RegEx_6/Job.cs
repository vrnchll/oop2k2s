using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab5
{
    [Serializable]
    [XmlRoot(Namespace = "Jobs")]
    [XmlType("Job")]
    public class Job
    {
        [XmlElement(ElementName = "Title")]
        public string Title { get; set; }
        [XmlElement(ElementName = "Company")]
        public string Company { get; set; }
        [XmlElement(ElementName = "Salary")]
        public int Salary { get; set; }
        [XmlElement(ElementName = "Experience")]
        public int Experience { get; set; }
    }
}
