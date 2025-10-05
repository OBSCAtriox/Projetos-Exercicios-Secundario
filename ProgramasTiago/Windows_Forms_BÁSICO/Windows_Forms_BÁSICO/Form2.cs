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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "O Cadima é NOOB no Clash Royale";
            label2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
