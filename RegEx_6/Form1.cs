using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace lab5
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        private List<Student> fakeList = new List<Student>();
        List<Student> result = new List<Student>();
        private string selectedRadial = "";
        private string lastAction = "";
        public Form1()
        { 
            InitializeComponent();
            listBox1.DataSource = students;
            LastName.Validating += LastName_Validating;
            FirstName.Validating += FirstName_Validating;
            MiddleName.Validating += MiddleName_Validating;
            Kours.Validating += kurs_Validating;
            Group.Validating += group_Validating;
            ToolStripMenuItem SearchItem = new ToolStripMenuItem("Поиск");

            ToolStripMenuItem FIOItem = new ToolStripMenuItem("По ФИО");
            SearchItem.DropDownItems.Add(FIOItem);
            FIOItem.Click += FIOItem_Click;

            ToolStripMenuItem KursItem = new ToolStripMenuItem("По Курсу");
            SearchItem.DropDownItems.Add(KursItem);
            KursItem.Click += KursItem_Click;

            ToolStripMenuItem ProffItem = new ToolStripMenuItem("По Специальности");
            SearchItem.DropDownItems.Add(ProffItem);
            ProffItem.Click += ProffItem_Click;

            menuStrip1.Items.Add(SearchItem);

            //2
            ToolStripMenuItem SortItem = new ToolStripMenuItem("Сортировка");

            ToolStripMenuItem Kurs2Item = new ToolStripMenuItem("По Курсу");
            SortItem.DropDownItems.Add(Kurs2Item);
            Kurs2Item.Click += Kurs2Item_Click;

            ToolStripMenuItem StazhItem = new ToolStripMenuItem("По Стажу");
            SortItem.DropDownItems.Add(StazhItem);
            StazhItem.Click += StazhItem_Click;

            ToolStripMenuItem GrItem = new ToolStripMenuItem("По Группе");
            SortItem.DropDownItems.Add(GrItem);
            GrItem.Click += GrItem_Click;


            menuStrip1.Items.Add(SortItem);

            //3
            ToolStripMenuItem AboutItem = new ToolStripMenuItem("О программе");
            menuStrip1.Items.Add(AboutItem);
            AboutItem.Click += AboutItem_Click;



            timer1 = new Timer() { Interval = 1000 };
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }
        void timer1_Tick(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToLongDateString();
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student
            {
                FirstName = FirstName.Text,
                LastName = LastName.Text,
                MiddleName = MiddleName.Text,
                Gender = selectedRadial,
                Age = Convert.ToInt32(AgeSlider.Value),
                Profession = selectedRadial,
                BirthDate = DatePicker.Value,
                Course = Convert.ToInt32(Kours.Text),
                Group = Convert.ToInt32(Group.Text),
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
            };
            var results = new List<ValidationResult>();
            var context = new ValidationContext(newStudent);
            if (!Validator.TryValidateObject(newStudent, context, results, true))
                throw new Exception(results.Last().ErrorMessage);

            students.Add(newStudent);
           
            listBox1.DataSource = fakeList;
            listBox1.DataSource = students;
            listBox1.Refresh();
           Count.Text = string.Format("Количество объектов: {0}", students.Count);
            label19.Text = "Добавлен объект";
        }

        //Sort
        private void StazhItem_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = students.OrderBy(s => s.Job.Experience).ToList();
            students= students.OrderBy(s => s.Job.Experience).ToList();
        }

        private void GrItem_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = students.OrderBy(s => s.Group).ToList();
            students = students.OrderBy(s => s.Group).ToList();
        }
        private void Kurs2Item_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = students.OrderBy(s => s.Course).ToList();
            students = students.OrderBy(s => s.Course).ToList();
        }


        //Menu
        public void AboutItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Версия: " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() + "\nФИО разработчика: Veronika Bobrik", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LastAction1.Text = "Info";
        }

        //Search
        public void  FIOItem_Click(object sender, EventArgs e)
        {

            Find find = new Find(students);
            find.Show();
            label19.Text = "Find Menu";
        }

        public void KursItem_Click(object sender, EventArgs e)
        {

            Find find = new Find(students);
            find.Show();
            label19.Text = "Find Menu";
        }
        public void ProffItem_Click(object sender, EventArgs e)
        { 

            Find find = new Find(students);
            find.Show();
            label19.Text = "Find Menu";
        }
        private void AgeSlider_Scroll(object sender, EventArgs e)
        {
            label4.Text = "Возраст : " + AgeSlider.Value.ToString();
        }

        private void mButton_CheckedChanged(object sender, EventArgs e)
        {
            selectedRadial = "м";
        }

        private void zhButton_CheckedChanged(object sender, EventArgs e)
        {
            selectedRadial = "ж";
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
            label19.Text = $"Выбран объект {listBox1.SelectedItem}";
        }

        private void ToXml_Click(object sender, EventArgs e)
        {
            SaveXml.ShowDialog();
            XmlSerializerWrapper.Serialize<List<Student>>(students, SaveXml.SelectedPath);
            label19.Text = "Save To XML";
        }

        private void FromXml_Click(object sender, EventArgs e)
        {
            OpenXml.ShowDialog();
            students = XmlSerializerWrapper.Deserialize<List<Student>>(OpenXml.FileName.ToString());
            listBox1.DataSource = fakeList;
            listBox1.DataSource = students;
            Count.Text = string.Format("Количество объектов: {0}", students.Count);
            label19.Text = "Read From XML";

        }
        public List<Company.Job> joblist = new List<Company.Job>();
        private void CompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CompanyName.SelectedItem.ToString() == "Добавить компанию")
            {
               Company comp = new Company();
               comp.ShowDialog();
               foreach (Company.Job job in comp.Jobs)
                {
                    if (job.Title.ToString().Length > 0)
                    {
                        CompanyName.Items.Add(job.Title);
                        joblist.Add(job);
                    }
                    CompanyName.SelectedItem = job.Title;
                }
            }
        }
        
        


        private void button_clear_Click(object sender, EventArgs e)
        {
            students.Clear();
            listBox1.DataSource = fakeList;
            listBox1.DataSource = students;
            label19.Text = "Clear list";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = !toolStrip1.Visible;
            Button button = sender as Button;
            if (button.Text.Equals("Спрятать"))
                button.Text = "Показать";
            else
                button.Text = "Спрятать";
        }

       


        // панель инструментов
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Find find = new Find(students);
            find.Show();
            label19.Text = "Find Menu";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Sort sort = new Sort(students);
            sort.Show();
            label19.Text = "Sort menu";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SaveXml.ShowDialog();
            XmlSerializerWrapper.Serialize<List<Student>>(students, SaveXml.SelectedPath);
            label19.Text = "Save To XML";
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            students.Clear();
            listBox1.DataSource = fakeList;
            listBox1.DataSource = students;
            label19.Text = "Clear list";
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
            if (String.IsNullOrEmpty(Kours.Text))
            {
                error.SetError(Kours, "Не указан курс!");
            }
            else if (!Int32.TryParse(Kours.Text, out kurso))
            {
                error.SetError(Kours, "Некорретное значение!");
            }
            else
            {
                error.Clear();
            }
        }
        private void group_Validating(object sender, CancelEventArgs e)
        {
            int group1 = 11;
            if (String.IsNullOrEmpty(Group.Text))
            {
                error.SetError(Group, "Не указан курс!");
            }
            else if (!Int32.TryParse(Group.Text, out group1))
            {
                error.SetError(Group, "Некорретное значение!");
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

        private void OpenXml_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
