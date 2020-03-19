namespace lab5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LastName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.MiddleName = new System.Windows.Forms.TextBox();
            this.фывфыв = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AgeSlider = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.Isit = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.Poibms = new System.Windows.Forms.RadioButton();
            this.Poit = new System.Windows.Forms.RadioButton();
            this.Deivi = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kurs = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.group = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Street = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.House = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Flat = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Experience = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.CompanyName = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ToXml = new System.Windows.Forms.Button();
            this.FromXml = new System.Windows.Forms.Button();
            this.OpenXml = new System.Windows.Forms.OpenFileDialog();
            this.SaveXml = new System.Windows.Forms.FolderBrowserDialog();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AgeSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(74, 6);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(121, 20);
            this.LastName.TabIndex = 0;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(74, 32);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(121, 20);
            this.FirstName.TabIndex = 1;
            // 
            // MiddleName
            // 
            this.MiddleName.Location = new System.Drawing.Point(74, 58);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(121, 20);
            this.MiddleName.TabIndex = 2;
            // 
            // фывфыв
            // 
            this.фывфыв.AutoSize = true;
            this.фывфыв.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.фывфыв.Location = new System.Drawing.Point(3, 7);
            this.фывфыв.Name = "фывфыв";
            this.фывфыв.Size = new System.Drawing.Size(62, 15);
            this.фывфыв.TabIndex = 4;
            this.фывфыв.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(3, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Имя";
            // 
            // Gender
            // 
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "Мужской",
            "Женский",
            "Другой"});
            this.Gender.Location = new System.Drawing.Point(74, 84);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(121, 21);
            this.Gender.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(3, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Пол";
            // 
            // AgeSlider
            // 
            this.AgeSlider.Location = new System.Drawing.Point(74, 157);
            this.AgeSlider.Maximum = 25;
            this.AgeSlider.Minimum = 17;
            this.AgeSlider.Name = "AgeSlider";
            this.AgeSlider.Size = new System.Drawing.Size(121, 45);
            this.AgeSlider.TabIndex = 9;
            this.AgeSlider.Value = 17;
            this.AgeSlider.Scroll += new System.EventHandler(this.AgeSlider_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(3, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Возраст";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(12, 124);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(0, 13);
            this.Age.TabIndex = 11;
            // 
            // Isit
            // 
            this.Isit.AutoSize = true;
            this.Isit.Location = new System.Drawing.Point(46, 223);
            this.Isit.Name = "Isit";
            this.Isit.Size = new System.Drawing.Size(55, 17);
            this.Isit.TabIndex = 12;
            this.Isit.TabStop = true;
            this.Isit.Text = "ИСИТ";
            this.Isit.UseVisualStyleBackColor = true;
            this.Isit.CheckedChanged += new System.EventHandler(this.Isit_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(3, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Специальность";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Poibms
            // 
            this.Poibms.AutoSize = true;
            this.Poibms.Location = new System.Drawing.Point(46, 246);
            this.Poibms.Name = "Poibms";
            this.Poibms.Size = new System.Drawing.Size(72, 17);
            this.Poibms.TabIndex = 15;
            this.Poibms.TabStop = true;
            this.Poibms.Text = "ПОИБМС";
            this.Poibms.UseVisualStyleBackColor = true;
            this.Poibms.CheckedChanged += new System.EventHandler(this.Poibms_CheckedChanged);
            // 
            // Poit
            // 
            this.Poit.AutoSize = true;
            this.Poit.Location = new System.Drawing.Point(124, 223);
            this.Poit.Name = "Poit";
            this.Poit.Size = new System.Drawing.Size(56, 17);
            this.Poit.TabIndex = 16;
            this.Poit.TabStop = true;
            this.Poit.Text = "ПОИТ";
            this.Poit.UseVisualStyleBackColor = true;
            this.Poit.CheckedChanged += new System.EventHandler(this.Poit_CheckedChanged);
            // 
            // Deivi
            // 
            this.Deivi.AutoSize = true;
            this.Deivi.Location = new System.Drawing.Point(124, 246);
            this.Deivi.Name = "Deivi";
            this.Deivi.Size = new System.Drawing.Size(64, 17);
            this.Deivi.TabIndex = 14;
            this.Deivi.TabStop = true;
            this.Deivi.Text = "ДЭИВИ";
            this.Deivi.UseVisualStyleBackColor = true;
            this.Deivi.CheckedChanged += new System.EventHandler(this.Deivi_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(3, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Дата рождения";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(3, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Курс";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // kurs
            // 
            this.kurs.Location = new System.Drawing.Point(74, 279);
            this.kurs.Name = "kurs";
            this.kurs.Size = new System.Drawing.Size(121, 20);
            this.kurs.TabIndex = 19;
            this.kurs.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.Location = new System.Drawing.Point(3, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Группа";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // group
            // 
            this.group.Location = new System.Drawing.Point(74, 315);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(121, 20);
            this.group.TabIndex = 21;
            this.group.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label9.Location = new System.Drawing.Point(462, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Город";
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(524, 20);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(121, 20);
            this.City.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label10.Location = new System.Drawing.Point(462, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "Улица";
            // 
            // Street
            // 
            this.Street.Location = new System.Drawing.Point(524, 46);
            this.Street.Name = "Street";
            this.Street.Size = new System.Drawing.Size(121, 20);
            this.Street.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label11.Location = new System.Drawing.Point(462, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 15);
            this.label11.TabIndex = 28;
            this.label11.Text = "Дом";
            // 
            // House
            // 
            this.House.Location = new System.Drawing.Point(524, 72);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(121, 20);
            this.House.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label12.Location = new System.Drawing.Point(454, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 15);
            this.label12.TabIndex = 30;
            this.label12.Text = "Квартира";
            // 
            // Flat
            // 
            this.Flat.Location = new System.Drawing.Point(524, 96);
            this.Flat.Name = "Flat";
            this.Flat.Size = new System.Drawing.Size(121, 20);
            this.Flat.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(559, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 17);
            this.label13.TabIndex = 31;
            this.label13.Text = "Адрес";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(760, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 17);
            this.label14.TabIndex = 40;
            this.label14.Text = "Место работы";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label15.Location = new System.Drawing.Point(681, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 15);
            this.label15.TabIndex = 39;
            this.label15.Text = "Зарплата";
            // 
            // Salary
            // 
            this.Salary.Location = new System.Drawing.Point(753, 100);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(121, 20);
            this.Salary.TabIndex = 38;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label16.Location = new System.Drawing.Point(691, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 15);
            this.label16.TabIndex = 37;
            this.label16.Text = "Стаж";
            // 
            // Experience
            // 
            this.Experience.Location = new System.Drawing.Point(753, 76);
            this.Experience.Name = "Experience";
            this.Experience.Size = new System.Drawing.Size(121, 20);
            this.Experience.TabIndex = 36;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label17.Location = new System.Drawing.Point(681, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 15);
            this.label17.TabIndex = 35;
            this.label17.Text = "Дожность";
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(753, 50);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(121, 20);
            this.Title.TabIndex = 34;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label18.Location = new System.Drawing.Point(681, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 15);
            this.label18.TabIndex = 33;
            this.label18.Text = "Компания";
            // 
            // CompanyName
            // 
            this.CompanyName.Location = new System.Drawing.Point(753, 24);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(121, 20);
            this.CompanyName.TabIndex = 32;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.submit.Location = new System.Drawing.Point(37, 359);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(110, 38);
            this.submit.TabIndex = 41;
            this.submit.Text = "Сохранить";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(206, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(238, 342);
            this.listBox1.TabIndex = 42;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // ToXml
            // 
            this.ToXml.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ToXml.Location = new System.Drawing.Point(228, 354);
            this.ToXml.Name = "ToXml";
            this.ToXml.Size = new System.Drawing.Size(180, 23);
            this.ToXml.TabIndex = 43;
            this.ToXml.Text = "Write To XML";
            this.ToXml.UseVisualStyleBackColor = false;
            this.ToXml.Click += new System.EventHandler(this.ToXml_Click);
            // 
            // FromXml
            // 
            this.FromXml.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.FromXml.Location = new System.Drawing.Point(227, 383);
            this.FromXml.Name = "FromXml";
            this.FromXml.Size = new System.Drawing.Size(181, 23);
            this.FromXml.TabIndex = 44;
            this.FromXml.Text = "Read From XML";
            this.FromXml.UseVisualStyleBackColor = false;
            this.FromXml.Click += new System.EventHandler(this.FromXml_Click);
            // 
            // OpenXml
            // 
            this.OpenXml.FileName = "openFileDialog1";
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(12, 126);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(180, 20);
            this.DatePicker.TabIndex = 45;
            this.DatePicker.ValueChanged += new System.EventHandler(this.DatePicker_ValueChanged);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(983, 481);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.FromXml);
            this.Controls.Add(this.ToXml);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Experience);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.CompanyName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Flat);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.House);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Street);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.City);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.group);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kurs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Poit);
            this.Controls.Add(this.Poibms);
            this.Controls.Add(this.Deivi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Isit);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AgeSlider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.фывфыв);
            this.Controls.Add(this.MiddleName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.LastName);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AgeSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox MiddleName;
        private System.Windows.Forms.Label фывфыв;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar AgeSlider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.RadioButton Isit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton Poibms;
        private System.Windows.Forms.RadioButton Poit;
        private System.Windows.Forms.RadioButton Deivi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox kurs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox group;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Street;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox House;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Flat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Salary;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Experience;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox CompanyName;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ToXml;
        private System.Windows.Forms.Button FromXml;
        private System.Windows.Forms.OpenFileDialog OpenXml;
        private System.Windows.Forms.FolderBrowserDialog SaveXml;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.ErrorProvider error;
    }
}

