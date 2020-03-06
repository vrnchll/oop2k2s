namespace WindowsForms_4_2
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
            this.sort_vozr = new System.Windows.Forms.Button();
            this.sort_ub = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Button();
            this.max = new System.Windows.Forms.Button();
            this.average = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sort_vozr
            // 
            this.sort_vozr.Location = new System.Drawing.Point(77, 186);
            this.sort_vozr.Name = "sort_vozr";
            this.sort_vozr.Size = new System.Drawing.Size(118, 58);
            this.sort_vozr.TabIndex = 0;
            this.sort_vozr.Text = "Сортировка по возрастанию";
            this.sort_vozr.UseVisualStyleBackColor = true;
            this.sort_vozr.Click += new System.EventHandler(this.sort_vozr_Click);
            // 
            // sort_ub
            // 
            this.sort_ub.Location = new System.Drawing.Point(525, 186);
            this.sort_ub.Name = "sort_ub";
            this.sort_ub.Size = new System.Drawing.Size(118, 58);
            this.sort_ub.TabIndex = 1;
            this.sort_ub.Text = "Сортировка по убыванию";
            this.sort_ub.UseVisualStyleBackColor = true;
            this.sort_ub.Click += new System.EventHandler(this.sort_ub_Click);
            // 
            // List
            // 
            this.List.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.List.FormattingEnabled = true;
            this.List.ItemHeight = 16;
            this.List.Location = new System.Drawing.Point(211, 83);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(307, 84);
            this.List.TabIndex = 2;
            this.List.SelectedIndexChanged += new System.EventHandler(this.List_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(257, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите желаемый размер коллекции";
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(227, 249);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(64, 48);
            this.min.TabIndex = 5;
            this.min.Text = "min";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(341, 249);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(64, 48);
            this.max.TabIndex = 6;
            this.max.Text = "max";
            this.max.UseVisualStyleBackColor = true;
            this.max.Click += new System.EventHandler(this.max_Click);
            // 
            // average
            // 
            this.average.Location = new System.Drawing.Point(443, 249);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(64, 48);
            this.average.TabIndex = 7;
            this.average.Text = "average";
            this.average.UseVisualStyleBackColor = true;
            this.average.Click += new System.EventHandler(this.average_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(386, 48);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 29);
            this.button6.TabIndex = 8;
            this.button6.Text = "Создать";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.average);
            this.Controls.Add(this.max);
            this.Controls.Add(this.min);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.List);
            this.Controls.Add(this.sort_ub);
            this.Controls.Add(this.sort_vozr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sort_vozr;
        private System.Windows.Forms.Button sort_ub;
        private System.Windows.Forms.ListBox List;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button max;
        private System.Windows.Forms.Button average;
        private System.Windows.Forms.Button button6;
    }
}

