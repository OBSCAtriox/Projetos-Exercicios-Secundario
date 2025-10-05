using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_BÁSICO
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

      

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Close1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbM_CheckedChanged(object sender, EventArgs e)
        {
            if (rbM.Checked == true)
            {
                label2.Text = "Male";
            }
            else
            {
                label2.Text = "Female";
            }
        }

        private void rbF_CheckedChanged(object sender, EventArgs e)
        {
            if (rbF.Checked == true)
            {
                label2.Text = "Female";
            }
            else
            {
                label2.Text = "Male";
            }
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }
    }
}
