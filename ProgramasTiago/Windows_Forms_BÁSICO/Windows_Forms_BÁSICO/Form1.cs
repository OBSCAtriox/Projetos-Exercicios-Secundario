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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Óla";
            label1.Visible = true; // ocultar ou mostrar a label
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show(); // abrir form2
            
            this.Hide(); //esconder form1
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
