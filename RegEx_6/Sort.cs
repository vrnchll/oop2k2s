using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Sort : Form
    {
        public List<Student> studentList { get; set; }
        public Sort()
        {
            InitializeComponent();
        }
        public Sort(List<Student> stud)
        {
            InitializeComponent();
            studentList = stud;
        }
        private void ExperienceSort_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = studentList.OrderBy(s => s.Job.Experience).ToList();
            studentList = studentList.OrderBy(s => s.Job.Experience).ToList();
        }

        private void GroupSort_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = studentList.OrderBy(s => s.Group).ToList();
            studentList = studentList.OrderBy(s => s.Group).ToList();
        }

        private void CourseSort_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = studentList.OrderBy(s => s.Course).ToList();
            studentList = studentList.OrderBy(s => s.Course).ToList();
        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Result result = new Result((Student)listBox1.SelectedItem);
            result.Show();
        }

        private void ToXml_Click(object sender, EventArgs e)
        {
            SaveXml.ShowDialog();
            XmlSerializerWrapper.Serialize<List<Student>>(studentList, SaveXml.SelectedPath);
        }
    }
}
