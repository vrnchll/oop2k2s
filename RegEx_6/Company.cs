using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace lab5
{
    public partial class Company : Form
    {
        public List<Job> Jobs = new List<Job>();
        public Company()
        {
            InitializeComponent();
        }
        [Serializable]
        [XmlRoot(Namespace = "lab5")]
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

        private void submit_Click(object sender, EventArgs e)
        {
            Jobs.Add(new Job {Company = CompanyName1.Text});
        }
    }
}
