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
    public partial class Form5 : Form
    {
        System.Timers.Timer t;
        int m, s, ms;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 10;
            t.Elapsed += OnTimeEvent;
            
            Random random = new Random();
            System.Drawing.Image img1;
            System.Drawing.Image[] n = new System.Drawing.Image[20];



            n[0] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\garagem\prego.png");
            n[1] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\garagem\calendario.png");
            n[2] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\garagem\escultura.png");
            n[3] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\garagem\mini_carro.png");
            n[4] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\garagem\martelo.png");
            n[5] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\garagem\ferramentas.png");
            n[6] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\garagem\tesoura_jardim.png");
            n[7] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\garagem\ficha_eletrica.png");
            n[8] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\garagem\motoserra.png");
            n[9] = Image.FromFile(@"E:\Imagens_Projeto_PSI_Tiago_Simao_Miguel\garagem\pneu.png");
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
                     if (m == 1 && s == 30)
                     {
                         panel3.Visible = true;
                         t.Stop();
                         label1.Text = "Que Pena";
                         label2.Text = "O seu tempo acabou";

                     }
                 }));
        }
        }
}
