using DsaChapter1_1_2.Entities;
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
    public partial class Form3 : Form
    {
        
        
        public Form3()
        {
            InitializeComponent();
            label1.Text = $"Please input the number between 1 to {Form1.customDatalist.Lenght}";
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string index = textBox1.Text;
            try
            {
                int i = int.Parse(index);
                if (i <= 0 || i > Form1.customDatalist.Lenght)
                {
                    textBox1.Text = "";
                    MessageBox.Show("Index out of list");
                }
                else
                {
                    Form1.customDatalist.RemoveByIndex(i - 1);
                    
                    MessageBox.Show("A student is removed");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                textBox1.Text = "";
                MessageBox.Show("Enter the number");
            }
        }
    }
}
