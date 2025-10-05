using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Projeto_Final_Tiago_Simao_Miguel
{
    public partial class Form3 : Form
    {
       
        int test = 2;
        int test2 = 2;
        int test3 = 2;
        int test4 = 2;
        int test5 = 2;
        int test6 = 2;
        int vidas = 5;
        
        System.Timers.Timer t;
        int m, s, ms;
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            checkBox1.Checked = true;
            test = 1;
            if (test == 1 && test2 == 1 && test3 == 1 && test4 == 1 && test5 == 1 && test6 == 1)
            {
                panel3.Visible = true;
                label1.Text = "Parabéns!";
                label2.Text = "Passou o segundo nível";
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = false;
                button4.Visible = false;
                t.Stop();

            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            checkBox5.Checked = true;
            test5 = 1;
            if (test == 1 && test2 == 1 && test3 == 1 && test4 == 1 && test5 == 1 && test6 == 1)
            {
                panel3.Visible = true;
                label1.Text = "Parabéns!";
                label2.Text = "Passou o segundo nível";
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = false;
                button4.Visible = false;
                t.Stop();

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PrincipalHitBox_Click(object sender, EventArgs e)
        {
            vidas = vidas - 1;
            panel4.Visible = true;
            label3.Text = "Atenção, perdeu uma vida !";

            if (vidas == 0)
            {
                panel3.Visible = true;
                label1.Text = "Que Pena";
                label2.Text = "Suas Vidas acabaram. Deseja recomeçar ?";
                button3.Visible = false;
                button4.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
                t.Stop();
            }
            if (vidas == 5)
            {
                labelvidas.Text = "Vidas: 5 !";
            }
            if (vidas == 4)
            {
                labelvidas.Text = "Vidas: 4 !";

            }
            if (vidas == 3)
            {
                labelvidas.Text = "Vidas: 3 !";
            }
            if (vidas == 2)
            {
                labelvidas.Text = "Vidas: 2 !";

            }
            if (vidas == 1)
            {
                labelvidas.Text = "Vidas: 1 !";


            }
            if (vidas == 0)
            {
                labelvidas.Text = "Vidas: 0 !";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void HitBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void HitBox10_Click(object sender, EventArgs e)
        {

        }

        private void cruz_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            checkBox4.Checked = true;
            test4 = 1;
            if (test == 1 && test2 == 1 && test3 == 1 && test4 == 1 && test5 == 1 && test6 == 1)
            {
                panel3.Visible = true;
                label1.Text = "Parabéns!";
                label2.Text = "Passou o segundo nível";
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = false;
                button4.Visible = false;
                t.Stop();

            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            checkBox6.Checked = true;
            test6 = 1;
            if (test == 1 && test2 == 1 && test3 == 1 && test4 == 1 && test5 == 1 && test6 == 1)
            {
                panel3.Visible = true;
                label1.Text = "Parabéns!";
                label2.Text = "Passou o segundo nível";
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = false;
                button4.Visible = false;
                t.Stop();

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            checkBox3.Checked = true;
            test3 = 1;
            if (test == 1 && test2 == 1 && test3 == 1 && test4 == 1 && test5 == 1 && test6 == 1)
            {
                panel3.Visible = true;
                label1.Text = "Parabéns!";
                label2.Text = "Passou o segundo nível";
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = false;
                button4.Visible = false;
                t.Stop();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            checkBox2.Checked = true;
            test2 = 1;
            if (test == 1 && test2 == 1 && test3 == 1 && test4 == 1 && test5 == 1 && test6 == 1)
            {
                panel3.Visible = true;
                label1.Text = "Parabéns!";
                label2.Text = "Passou o segundo nível";
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = false;
                button4.Visible = false;
                t.Stop();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Hide();
            form3.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 10;
            t.Elapsed += OnTimeEvent;
            t.Start();
            if (m == 1 )
            {
                panel3.Visible = true;
                t.Stop();
                label1.Text = "Que Pena";
                label2.Text = "O seu tempo acabou, deseja recomeçar ?";
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = true;
                button4.Visible = true;

            }
            if (vidas == 5)
            {
                labelvidas.Text = "Vidas: 5 !";
            }
            t = new System.Timers.Timer();
            t.Interval = 10;
            t.Elapsed += OnTimeEvent;

            Random random = new Random();
            System.Drawing.Image img1;
            System.Drawing.Image[] n = new System.Drawing.Image[20];



            n[0] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\quarto\despertador.png");
            n[1] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\quarto\luz_presença.png");
            n[2] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\quarto\oculos.png");
            n[3] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\quarto\garrafa_agua.png");
            n[4] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\quarto\telemovel.png");
            n[5] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\quarto\escova_cabelo.png");
            n[6] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\quarto\lanterna.png");
            n[7] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\quarto\livro.png");
            n[8] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\quarto\vaso_flores.png");
            n[9] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\quarto\peluche.png");

            for (int i = 0; i < 10; i++)
            {
                int num1 = random.Next(0, 2);
                pictureBox1.BackgroundImage = (n[num1]);
                checkBox1.BackgroundImage = pictureBox1.BackgroundImage;
                int num2 = random.Next(2, 5);
                pictureBox2.BackgroundImage = (n[num2]);
                checkBox2.BackgroundImage = pictureBox2.BackgroundImage;
                int num3 = random.Next(5, 10);
                pictureBox3.BackgroundImage = (n[num3]);
                checkBox3.BackgroundImage = pictureBox3.BackgroundImage;
                int num4 = random.Next(8, 10);
                pictureBox4.BackgroundImage = (n[num4]);
                checkBox4.BackgroundImage = pictureBox4.BackgroundImage;
                int num5 = random.Next(2, 5);
                pictureBox5.BackgroundImage = (n[num5]);
                checkBox5.BackgroundImage = pictureBox5.BackgroundImage;
                int num6 = random.Next(2, 5);
                pictureBox6.BackgroundImage = (n[num6]);
                checkBox6.BackgroundImage = pictureBox6.BackgroundImage;
            }
            }
        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        { Invoke(new Action(() =>
                      {
                          ms += 1;
                          if (ms == 60)
                          {
                              ms = 0;
                              s += 1;
                          }
                          if (s == 60)
                          {
                              s = 0;
                              m += 1;
                          }
                          Timer.Text = string.Format("{0}:{1}:{2}", m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'), ms.ToString().PadLeft(2, '0'));
                          t.Start();
                          if (m == 1)
                          {
                              panel3.Visible = true;
                              t.Stop();
                              label1.Text = "Que Pena";
                              label2.Text = "O seu tempo acabou";
                              button1.Visible = false;
                              button2.Visible = false;
                              button3.Visible = true;
                              button4.Visible = true;

                          }
                      }));
        }
    }
}

