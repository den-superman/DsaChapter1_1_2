using DsaChapter1_1_2.Functionality;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DsaChapter1_1_2
{
    public partial class Form1 : Form
    {
        public static CustomDataList customDatalist = new CustomDataList();
        

        

        public Form1()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void PopulateBox()
        {
            listBox1.Items.Clear();
            foreach (var item in customDatalist.DisplayAll())
            {
                
                listBox1.Items.Add(item);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.txt"; 
            dialog.Multiselect = false; 
            if (dialog.ShowDialog() == DialogResult.OK) 
            {
                string path = dialog.FileName; 
                customDatalist.LoadFromFile(path);
                PopulateBox();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customDatalist != null & comboBox1.Text != "")
            {
                customDatalist.Sorting(comboBox2.Text, comboBox1.Text);
                PopulateBox();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(customDatalist != null & comboBox2.Text != "")
            {
                customDatalist.Sorting(comboBox2.Text, comboBox1.Text);
                PopulateBox();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(customDatalist.Lenght != 0)
            {
                customDatalist.RemoveFirst();
                PopulateBox();
            }
            else
            {
                MessageBox.Show("Data is not populated");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (customDatalist.Lenght != 0)
            {
                customDatalist.RemoveLast();
                PopulateBox();
            }
            else
            {
                MessageBox.Show("Data is not populated");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(customDatalist.Lenght != 0)
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Data is not populated");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (customDatalist.Lenght != 0)
            {
               

                Form3 form3 = new Form3();
                form3.FormClosed += new FormClosedEventHandler(Form3_FormClosed);
                form3.Show();

                
               
            }
            else
            {
                MessageBox.Show("Data is not populated");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.FormClosed += new FormClosedEventHandler(Form4_FormClosed);
            form4.Show();
        }
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            PopulateBox();
        }
        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            PopulateBox();
        }
    }
}
