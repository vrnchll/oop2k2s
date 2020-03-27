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
    public partial class Result : Form
    {
        Student Student;
        public Result(Student student)
        {
            InitializeComponent();
            Student = student;
            FirstName.Text = Student.FirstName;
            LastName.Text = Student.LastName;
            MiddleName.Text = Student.MiddleName;
            Age.Text = Student.Age.ToString();
            Gender.Text = Student.Gender;
            Profession.Text = Student.Profession;
            BirthDate.Text = Student.BirthDate.ToString();
            Course.Text = Student.Course.ToString();
            Group.Text = Student.Group.ToString();

            City.Text = Student.Adress.City;
            Street.Text = Student.Adress.Street;
            House.Text = Student.Adress.House.ToString();
            Flat.Text = Student.Adress.Apartment.ToString();

            Company.Text = Student.Job.Company;
            Title.Text = Student.Job.Title;
            Salary.Text = Student.Job.Salary.ToString();
            Experience.Text = Student.Job.Experience.ToString();
        }

        private void Result_Load(object sender, EventArgs e)
        {

        }
    }
}
