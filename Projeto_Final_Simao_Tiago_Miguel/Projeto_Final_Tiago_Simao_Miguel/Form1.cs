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
    public partial class Form1 : Form
    {
        System.Timers.Timer t;
        int h, m, s;
        int vidas = 5;
        int test = 2;
        int test2 = 2;
        int test3 = 2;
        int test4 = 2;
        int test5 = 2;
        
        

        public Form1()
        {
            InitializeComponent();


        
            
            
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            checkBox1.Checked = true;
            test5 = 1;
            if (test == 1 && test2 == 1 && test3 == 1 && test4 == 1 && test5 == 1)
            {
                panel3.Visible = true;
                label1.Text = "Parabéns!";
                label2.Text = "Passou o primeiro nível";
                button1.Visible = true;
                button2.Visible = true;
                button5.Visible = false;
                button6.Visible = false;
                t.Stop();

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            checkBox2.Checked = true;
            test4 = 1;
            if (test == 1 && test2 == 1 && test3 == 1 && test4 == 1 && test5 == 1)
            {
                panel3.Visible = true;
                label1.Text = "Parabéns!";
                label2.Text = "Passou o primeiro nível";
                button1.Visible = true;
                button2.Visible = true;
                button5.Visible = false;
                button6.Visible = false;
                t.Stop();
                
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        public CheckState Checked { get; private set; }
        private void Form1_Load(object sender, EventArgs e)
        {



            //pictureBox1.Location = label4.Location;
            if (vidas == 5)
            {
                labelvidas.Text = "Vidas: 5 !";
            }
            Random random = new Random();
           System.Drawing.Image img1;
          System.Drawing.Image[] n = new System.Drawing.Image[20];
            
           
            n[0] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\cozinha\relogio.png");
            n[1] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\cozinha\cabide_mural.png");
            n[2] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\cozinha\chavena.png");
            n[3] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\cozinha\laranja.png");
            n[4] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\cozinha\saco.png");
            n[5] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\cozinha\frangito.png");
            n[6] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\cozinha\baguete.png");
            n[7] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\cozinha\flores.png");
            n[8] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\cozinha\tabua.png");
            n[9] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\cozinha\torradeira.png");
            n[10] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\cozinha\bule.png");
            n[11] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\cozinha\saleiro_acucareiro.png");
       
           




            for (int i = 0; i < 10; i++)
            {
               int num1 =  random.Next(0, 2);
                pictureBox4.BackgroundImage = (n[num1]);
                checkBox3.BackgroundImage = pictureBox4.BackgroundImage;
                int num2 = random.Next(2, 5);
                pictureBox1.BackgroundImage = (n[num2]);
                checkBox1.BackgroundImage = pictureBox1.BackgroundImage;
                int num3 = random.Next(5, 10);
                pictureBox2.BackgroundImage = (n[num3]);
                checkBox2.BackgroundImage = pictureBox2.BackgroundImage;
                int num4 = random.Next(10, 12);
                pictureBox5.BackgroundImage = (n[num4]);
                checkBox4.BackgroundImage = pictureBox5.BackgroundImage;
                int num5 = random.Next(2, 5);
                pictureBox6.BackgroundImage = (n[num5]);
                checkBox5.BackgroundImage = pictureBox6.BackgroundImage;







            }

           
            
        

            t = new System.Timers.Timer();
            t.Interval = 10;
            t.Elapsed += OnTimeEvent;
            t.Start();
            if (h == 1 && m == 30)
            {
                panel3.Visible = true;
                t.Stop();
                label1.Text = "Que Pena";
                label2.Text = "O seu tempo acabou, deseja recomeçar ?";
            }














        }
    
        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
             Invoke(new Action(() =>
                {
                    s += 1;
                    if (s == 60)
                    {
                        s = 0;
                        m += 1;
                    }
                    if (m == 60)
                    {
                        m = 0;
                        h += 1;
                    }
                    Timer.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
                   
                  
                }));

        
            

        }
        
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            checkBox3.Checked = true;
            test = 1;
            if (test == 1 && test2 ==1 && test3 == 1 && test4 == 1 && test5 == 1)
            {
                panel3.Visible = true;
                label1.Text = "Parabéns!";
                label2.Text = "Passou o primeiro nível";
                button1.Visible = true;
                button2.Visible = true;
                button5.Visible = false;
                button6.Visible = false;
                t.Stop();
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            checkBox4.Checked = true;
            test2 = 1;
            if (test == 1 && test2 == 1 && test3 ==1 && test4==1 && test5 == 1)
            {
                panel3.Visible = true;
                label1.Text = "Parabéns!";
                label2.Text = "Passou o primeiro nível";
                button1.Visible = true;
                button2.Visible = true;
                button5.Visible = false;
                button6.Visible = false;
                t.Stop();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            Form1 form1 = new Form1();
            form1.Hide();
            form1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void HitBox1_Click(object sender, EventArgs e)
        {
            vidas = vidas -1;
            panel4.Visible = true;
            label3.Text = "Atenção, perdeu uma vida !";

            if (vidas == 0)
            {
                panel3.Visible = true;
                label1.Text = "Que Pena";
                label2.Text = "Suas Vidas acabaram. Deseja recomeçar ?";
                button5.Visible = false;
                button6.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
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

        private void Hitbox4_Click(object sender, EventArgs e)
        {
            vidas = vidas - 1;
            panel4.Visible = true;
            label3.Text = "Atenção, perdeu uma vida !";

            if (vidas == 0)
            {
                panel3.Visible = true;
                label1.Text = "Que Pena";
                label2.Text = "Suas Vidas acabaram. Deseja recomeçar ?";
                button5.Visible = false;
                button6.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
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

        private void HitBox5_Click(object sender, EventArgs e)
        {
            vidas = vidas - 1;
            panel4.Visible = true;
            label3.Text = "Atenção, perdeu uma vida !";

            if (vidas == 0)
            {
                panel3.Visible = true;
                label1.Text = "Que Pena";
                label2.Text = "Suas Vidas acabaram. Deseja recomeçar ?";
                button5.Visible = false;
                button6.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
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

        private void HitBox2_Click(object sender, EventArgs e)
        {
            vidas = vidas - 1;
            panel4.Visible = true;
            label3.Text = "Atenção, perdeu uma vida !";

            if (vidas == 0)
            {
                panel3.Visible = true;
                label1.Text = "Que Pena";
                label2.Text = "Suas Vidas acabaram. Deseja recomeçar ?";
                button5.Visible = false;
                button6.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
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

        private void HitBox6_Click(object sender, EventArgs e)
        {
            vidas = vidas - 1;
            panel4.Visible = true;
            label3.Text = "Atenção, perdeu uma vida !";

            if (vidas == 0)
            {
                panel3.Visible = true;
                label1.Text = "Que Pena";
                label2.Text = "Suas Vidas acabaram. Deseja recomeçar ?";
                button5.Visible = false;
                button6.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
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

        private void HitBox7_Click(object sender, EventArgs e)
        {
            vidas = vidas - 1;
            panel4.Visible = true;
            label3.Text = "Atenção, perdeu uma vida !";

            if (vidas == 0)
            {
                panel3.Visible = true;
                label1.Text = "Que Pena";
                label2.Text = "Suas Vidas acabaram. Deseja recomeçar ?";
                button5.Visible = false;
                button6.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
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

        private void HitBox8_Click(object sender, EventArgs e)
        {
            vidas = vidas - 1;
            panel4.Visible = true;
            label3.Text = "Atenção, perdeu uma vida !";

            if (vidas == 0)
            {
                panel3.Visible = true;
                label1.Text = "Que Pena";
                label2.Text = "Suas Vidas acabaram. Deseja recomeçar ?";
                button5.Visible = false;
                button6.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
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

        private void HitBox9_Click(object sender, EventArgs e)
        {
            vidas = vidas - 1;
            panel4.Visible = true;
            label3.Text = "Atenção, perdeu uma vida !";

            if (vidas == 0)
            {
                panel3.Visible = true;
                label1.Text = "Que Pena";
                label2.Text = "Suas Vidas acabaram. Deseja recomeçar ?";
                button5.Visible = false;
                button6.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
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

        private void HitBox10_Click(object sender, EventArgs e)
        {
            vidas = vidas - 1;
            panel4.Visible = true;
            label3.Text = "Atenção, perdeu uma vida !";

            if (vidas == 0)
            {
                panel3.Visible = true;
                label1.Text = "Que Pena";
                label2.Text = "Suas Vidas acabaram. Deseja recomeçar ?";
                button5.Visible = false;
                button6.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
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

        private void vidalabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            checkBox5.Checked = true;
            test3 = 1;
            if (test == 1 && test2 == 1 && test3 == 1 && test4 == 1 && test5 == 1)
            {
                panel3.Visible = true;
                label1.Text = "Parabéns!";
                label2.Text = "Passou o primeiro nível";
                button1.Visible = true;
                button2.Visible = true;
                button5.Visible = false;
                button6.Visible = false;
                t.Stop();
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox5_CheckStateChanged(object sender, EventArgs e)
        {
          
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cruz_Click_1(object sender, EventArgs e)
        {
            panel4.Visible = false;

        }

        private void labelvidas_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Refresh();

        }



         


}

}
