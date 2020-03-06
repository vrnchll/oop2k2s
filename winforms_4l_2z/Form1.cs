using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_4_2
{
    public partial class Form1 : Form
    {
        private static List<int> collection;
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e) //создать
        {
            try
            {
                collection = new List<int>();
                int size = int.Parse(textBox1.Text);
                Random random = new Random();
                if (List.Items.Count != 0)
                    List.Items.Clear();
                for (int i = 0; i < size; i++)
                {
                    collection.Add(random.Next(1, 50));
                }
                foreach(int item in collection)
                {
                    List.Items.Add(item);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sort_vozr_Click(object sender, EventArgs e)
        {
            List.Items.Clear();
            collection.Sort();
            foreach(int it in collection)
            {
                List.Items.Add(it);
            }
        }

        private void sort_ub_Click(object sender, EventArgs e)
        {
            List.Items.Clear();
            collection.Sort();
            collection.Reverse();
            foreach(int it2 in collection)
            {
                List.Items.Add(it2);
            }
               
        }

        private void min_Click(object sender, EventArgs e)
        {
            MessageBox.Show(collection.Min().ToString());
        }

        private void max_Click(object sender, EventArgs e)
        {
            MessageBox.Show(collection.Max().ToString());
        }

        private void average_Click(object sender, EventArgs e)
        {
            MessageBox.Show(collection.Average().ToString());
        }

        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
