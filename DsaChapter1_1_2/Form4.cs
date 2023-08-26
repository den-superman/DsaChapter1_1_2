using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DsaChapter1_1_2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string surname = textBox2.Text;
            string number = textBox3.Text;
            string score = textBox4.Text;
            if(name.Any(char.IsDigit) || surname.Any(char.IsDigit))
            {
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show("Name or Last Name can not contain numbers");
            }

            try
            {
                float sc = float.Parse(score);
                Form1.customDatalist.AddStudent(new Entities.Student()
                {
                    FirstName = name,
                    LastName = surname,
                    AverageScore = sc,
                    StudentNumber = number
                });
                MessageBox.Show("A student was added");
                this.Close();

            }
            catch (Exception ex)
            {
                textBox4.Text = "";
                MessageBox.Show("Enter the number");
            }
            
        }
    }
}
