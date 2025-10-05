using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Projeto_Final_Tiago_Simao_Miguel
{
    public partial class Form2 : Form
    {
        int vidas = 3;
        int test = 2;
        int test2 = 2;
        int test3 = 2;
        int test4 = 2;
        int test5 = 2;
        int test6 = 2;
        int test7 = 2;
        int test8 = 2;
        int test9 = 2;
        
        System.Timers.Timer t;
        int m, s, ms;
        public Form2()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void cruz_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 10;
            t.Elapsed += OnTimeEvent;
            t.Start();
            if (s == 45)
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
            if (vidas == 3)
            {
                labelvidas.Text = "Vidas: 3 !";
            }
            t = new System.Timers.Timer();
            t.Interval = 10;
            t.Elapsed += OnTimeEvent;

            Random random = new Random();
            System.Drawing.Image img1;
            System.Drawing.Image[] n = new System.Drawing.Image[22];

            n[0] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\Sala_de_Estar\bulacha_maria.png");
            n[1] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\Sala_de_Estar\commando_ps5.png");
            n[2] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\Sala_de_Estar\command_xbox.png");
            n[3] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\Sala_de_Estar\carrinho.png");
            n[4] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\Sala_de_Estar\carregador.png");
            n[5] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\Sala_de_Estar\creme.png");
            n[6] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\Sala_de_Estar\mealheiro.png");
            n[7] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\Sala_de_Estar\vela.png");
            n[8] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\Sala_de_Estar\relogio.png");
            n[9] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\Sala_de_Estar\garrafa_agua.png");
            n[10] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\Sala_de_Estar\manta_enrolada.png");
            n[11] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\Sala_de_Estar\saco.png");
            n[12] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\Sala_de_Estar\termometro.png");
            n[13] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\Sala_de_Estar\chapeu.png");
            n[14] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\Sala_de_Estar\luvas.png");
            n[15] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\Sala_de_Estar\luz_lava.png");
            n[16] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\Sala_de_Estar\flores.png");
            n[17] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\Sala_de_Estar\cadeira.png");
            n[18] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\Sala_de_Estar\buxo.png");
            n[19] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\Sala_de_Estar\cama_cao.png");
            n[20] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\Sala_de_Estar\candeeiro.png");
            n[21] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\Sala_de_Estar\xbox.png");

            for (int i = 0; i < 22; i++)
            {
                int num1 = random.Next(0, 12);
                pictureBox1.BackgroundImage = (n[num1]);
                checkBox1.BackgroundImage = pictureBox1.BackgroundImage;
                int num2 = random.Next(0, 12);
                pictureBox2.BackgroundImage = (n[num2]);
                checkBox2.BackgroundImage = pictureBox2.BackgroundImage;
                int num3 = random.Next(0, 12);
                pictureBox3.BackgroundImage = (n[num3]);
                checkBox3.BackgroundImage = pictureBox3.BackgroundImage;
                int num4 = random.Next(18, 19);
                pictureBox4.BackgroundImage = (n[num4]);
                checkBox4.BackgroundImage = (n[num4]);
                int num5 = random.Next(19, 21);
                pictureBox5.BackgroundImage = (n[num5]);
                checkBox5.BackgroundImage = (n[num5]);
                int num6 = random.Next(19, 22);
                pictureBox6.BackgroundImage = (n[num6]);
                checkBox6.BackgroundImage = pictureBox6.BackgroundImage;
                int num7 = random.Next(12, 17);
                pictureBox7.BackgroundImage = (n[num7]);
                checkBox7.BackgroundImage = pictureBox7.BackgroundImage;
                int num8 = random.Next(13, 17);
                pictureBox8.BackgroundImage = (n[num8]);
                checkBox8.BackgroundImage = (n[num8]);
                int num9 = random.Next(17, 18);
                pictureBox9.BackgroundImage = (n[num9]);
                checkBox9.BackgroundImage = pictureBox9.BackgroundImage;



            }





        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            checkBox2.Checked = true;
            test2 = 1;
            if (test == 1 && test2 == 1 && test3 == 1 && test4 == 1 && test5 == 1 && test6 == 1 && test7 == 1 && test8 ==1 && test9 == 1)
            {
                panel3.Visible = true;
                label1.Text = "Parabéns!";
                label2.Text = "Passou o ultimo nível!";
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
            if (test == 1 && test2 == 1 && test3 == 1 && test4 == 1 && test5 == 1 && test6 == 1 && test7 == 1 && test8 ==1 && test9 ==1)
            {
                panel3.Visible = true;
                label1.Text = "Parabéns!";
                label2.Text = "Passou o ultimo nível!";
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = false;
                button4.Visible = false;
                t.Stop();

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            checkBox4.Checked = true;
            test4 = 1;
            if (test == 1 && test2 == 1 && test3 == 1 && test4 == 1 && test5 == 1 && test6 == 1 && test7 == 1 && test8 == 1 && test9 == 1)
            {
                panel3.Visible = true;
                label1.Text = "Parabéns!";
                label2.Text = "Passou o ultimo nível!";
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = false;
                button4.Visible = false;
                t.Stop();

            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            checkBox7.Checked = true;
            test7 = 1;
            if (test == 1 && test2 == 1 && test3 == 1 && test4 == 1 && test5 == 1 && test6 == 1 && test7 == 1 && test8 == 1 && test9 == 1)
            {
                panel3.Visible = true;
                label1.Text = "Parabéns!";
                label2.Text = "Passou o ultimo nível!";
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = false;
                button4.Visible = false;
                t.Stop();

            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Visible = false;
            checkBox8.Checked = true;
            test8 = 1;
            if (test == 1 && test2 == 1 && test3 == 1 && test4 == 1 && test5 == 1 && test6 == 1 && test7 == 1 && test8 == 1 && test9 == 1)
            {
                panel3.Visible = true;
                label1.Text = "Parabéns!";
                label2.Text = "Passou o ultimo nível!";
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = false;
                button4.Visible = false;
                t.Stop();

            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Visible = false;
            checkBox9.Checked = true;
            test9 = 1;
            if (test == 1 && test2 == 1 && test3 == 1 && test4 == 1 && test5 == 1 && test6 == 1 && test7 == 1 && test8 == 1 && test9 == 1)
            {
                panel3.Visible = true;
                label1.Text = "Parabéns!";
                label2.Text = "Passou o ultimo nível!";
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
            if (test == 1 && test2 == 1 && test3 == 1 && test4 == 1 && test5 == 1 && test6 == 1 && test7 == 1 && test8 == 1 && test9 == 1)
            {
                panel3.Visible = true;
                label1.Text = "Parabéns!";
                label2.Text = "Passou o ultimo nível!";
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = false;
                button4.Visible = false;
                t.Stop();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            checkBox1.Checked = true;
            test = 1;
            if (test == 1 && test2 == 1 && test3 == 1 && test4 == 1 && test5 == 1 && test6 == 1 && test7 == 1 && test8 == 1 && test9 == 1)
            {
                panel3.Visible = true;
                label1.Text = "Parabéns!";
                label2.Text = "Passou o ultimo nível!";
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
            if (test == 1 && test2 == 1 && test3 == 1 && test4 == 1 && test5 == 1 && test6 == 1 && test7 == 1 && test8 == 1 && test9 == 1)
            {
                panel3.Visible = true;
                label1.Text = "Parabéns!";
                label2.Text = "Passou o ultimo nível!";
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = false;
                button4.Visible = false;
                t.Stop();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Hitbox_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Win win1 = new Win();
            win1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
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
                if (s == 50)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
