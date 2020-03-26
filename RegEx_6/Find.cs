using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace lab5
{
    public partial class Find : Form
    {
     List<Student> students { get; set; }
     List<Student> result= new List<Student>();
        public Find()
        {
            InitializeComponent();
        }

        public Find(List<Student> list)
        {
            InitializeComponent();
            students = list;
        }
        private void NameSearch_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex($"({NameSearch.Text})", RegexOptions.IgnoreCase);
            result.Clear();
            foreach (Student x in students)
            {
                if (regex.Match(x.ToString()).Success)
                    result.Add(x);
            }
            listBox1.DataSource = students;
            listBox1.DataSource = result;
        }
        private void ProfessionSearch_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex($"({ProfessionSearch.Text})", RegexOptions.IgnoreCase);
            result.Clear();
            foreach (Student x in students)
            {
                if (regex.Match(x.Profession).Success)
                    result.Add(x);
            }
            listBox1.DataSource = students;
            listBox1.DataSource = result;
        }
        private void CourseSearch_Leave(object sender, EventArgs e)
        {
            try
            {
                result = students.Where(s => s.Course == Convert.ToInt32(CourseSearch.Text)).ToList();
                listBox1.DataSource = students;
                listBox1.DataSource = result;
            }
            catch { }
        }
        private void ToXml_Click(object sender, EventArgs e)
        {
            SaveXml.ShowDialog();
            XmlSerializerWrapper.Serialize<List<Student>>(result, SaveXml.SelectedPath);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Result result = new Result((Student)listBox1.SelectedItem);
            result.Show();
        }

       

       
    }
}
