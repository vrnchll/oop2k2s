using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab5
{
    [Serializable]
    [XmlRoot(Namespace = "Students")]
    [XmlType("Student")]
    public class Student
    {
        [XmlElement(ElementName = "FirstName")]
        public string FirstName { get; set; }
        [XmlElement(ElementName = "LastName")]
        public string LastName { get; set; }
        [XmlElement(ElementName = "MiddleName")]
        public string MiddleName { get; set; }
        [XmlElement(ElementName = "Gender")]
        public string Gender { get; set; }
        [XmlElement(ElementName = "Age")]
        public int Age { get; set; }
        [XmlElement(ElementName = "Profession")]
        public string Profession { get; set; }
        [XmlElement(ElementName = "BirthDate")]
        public DateTime BirthDate { get; set; }
        [XmlElement(ElementName = "Course")]
        public int Course { get; set; }
        [XmlElement(ElementName = "Group")]
        public int Group { get; set; }
        [XmlElement(ElementName = "Adress")]
        public Adress Adress { get; set; }
        [XmlElement(ElementName = "Job")]
        public Job Job { get; set; }

        public override string ToString()
        {
            return $"{LastName} {FirstName} {MiddleName}";
        }
    }
}
