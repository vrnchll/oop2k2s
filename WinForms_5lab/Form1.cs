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
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        private List<Student> fakeList = new List<Student>();
        private string selectedRadial = "";
        public Form1()
        { 
            InitializeComponent();
            listBox1.DataSource = students;
            LastName.Validating += LastName_Validating;
            FirstName.Validating += FirstName_Validating;
            MiddleName.Validating += MiddleName_Validating;
            kurs.Validating += kurs_Validating;
            group.Validating += group_Validating;
        }


        private void submit_Click(object sender, EventArgs e)
        {
            students.Add(new Student
            {
                FirstName = FirstName.Text,
                LastName = LastName.Text,
                MiddleName = MiddleName.Text,
                Gender = Gender.Text,
                Age = Convert.ToInt32(AgeSlider.Value),
                Profession = selectedRadial,
                BirthDate = DatePicker.Value,
                Course = Convert.ToInt32(kurs.Text),
                Group = Convert.ToInt32(group.Text),
                Adress = new Adress
                {
                    City = City.Text,
                    Street = Street.Text,
                    House = Convert.ToInt32(House.Text),
                    Apartment = Convert.ToInt32(Flat.Text)
                },
                Job = new Job
                {
                    Company = CompanyName.Text,
                    Title = Title.Text,
                    Salary = Convert.ToInt32(Salary.Text),
                    Experience = Convert.ToInt32(Experience.Text)
                }
            });
            listBox1.DataSource = fakeList;
            listBox1.DataSource = students;
            listBox1.Refresh();
        }


        private void AgeSlider_Scroll(object sender, EventArgs e)
        {
            Age.Text = AgeSlider.Value.ToString();
        }

        

        private void Isit_CheckedChanged(object sender, EventArgs e)
        {
            selectedRadial = "ИСиТ";
        }

        private void Poit_CheckedChanged(object sender, EventArgs e)
        {
            selectedRadial = "ПОИТ";
        }

        private void Poibms_CheckedChanged(object sender, EventArgs e)
        {
            selectedRadial = "ПОИБМС";
        }

        private void Deivi_CheckedChanged(object sender, EventArgs e)
        {
            selectedRadial = "ДЭиВИ";
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Result result = new Result((Student)listBox1.SelectedItem);
            result.Show();
            
        }

        private void ToXml_Click(object sender, EventArgs e)
        {
            SaveXml.ShowDialog();
            XmlSerializerWrapper.Serialize<List<Student>>(students, SaveXml.SelectedPath);
        }

        private void FromXml_Click(object sender, EventArgs e)
        {
            OpenXml.ShowDialog();
            students = XmlSerializerWrapper.Deserialize<List<Student>>(OpenXml.FileName.ToString());
            listBox1.DataSource = fakeList;
            listBox1.DataSource = students;
            
        }
        private void LastName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(LastName.Text))
            {
                error.SetError(LastName, "Пустое поле!");
            }
            else if (LastName.Text.Length < 2)
            {
                error.SetError(LastName, "Недостаточно символов!");
            }
            else
            {
                error.Clear();
            }
        }

        private void FirstName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(FirstName.Text))
            {
                error.SetError(FirstName, "Пустое поле!");
            }
            else if (FirstName.Text.Length < 2)
            {
                error.SetError(FirstName, "Недостаточно символов!");
            }
            else
            {
                error.Clear();
            }
        }

        private void MiddleName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(MiddleName.Text))
            {
                error.SetError(MiddleName, "Пустое поле!");
            }
            else if (MiddleName.Text.Length < 2)
            {
                error.SetError(MiddleName, "Недостаточно символов!");
            }
            else
            {
                error.Clear();
            }
        }
        private void kurs_Validating(object sender, CancelEventArgs e)
        {
            int kurso = 5;
            if (String.IsNullOrEmpty(kurs.Text))
            {
                error.SetError(kurs, "Не указан курс!");
            }
            else if (!Int32.TryParse(kurs.Text, out kurso))
            {
                error.SetError(kurs, "Некорретное значение!");
            }
            else
            {
                error.Clear();
            }
        }
        private void group_Validating(object sender, CancelEventArgs e)
        {
            int group1 = 11;
            if (String.IsNullOrEmpty(group.Text))
            {
                error.SetError(group, "Не указан курс!");
            }
            else if (!Int32.TryParse(group.Text, out group1))
            {
                error.SetError(group, "Некорретное значение!");
            }
            else
            {
                error.Clear();
            }
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

       
    }
}
