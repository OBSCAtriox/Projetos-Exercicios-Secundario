using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox_CheckBox_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = comboBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex >= 0)
            {
                label2.Text = listBox1.SelectedItem.ToString();
            }
            //label2.Text = listBox1.SelectedIndex.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label1.Text = "Email Sent";
            }
            else
            {
                label1.Text = "No Spam";
            }
        }
    }
}
