namespace Pauta_Escolar_Projeto_Final
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.aviso2 = new System.Windows.Forms.Button();
            this.aviso1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 82);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sim";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1277, 550);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 132);
            this.button2.TabIndex = 4;
            this.button2.Text = "Não";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(499, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 196);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(179, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 82);
            this.button3.TabIndex = 7;
            this.button3.Text = "Não";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 51);
            this.label1.TabIndex = 9;
            this.label1.Text = "Neste Programma pode ver a Pauta Escolar de um aluno \r\ndo Curso de Informática at" +
    "é ao módulo 7. ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 57);
            this.label2.TabIndex = 10;
            this.label2.Text = "Se dejeja ver a pauta escolha uma das seguintes opções.\r\nSe Não o programa vai fe" +
    "char.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 364);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 197);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.aviso2);
            this.panel2.Controls.Add(this.aviso1);
            this.panel2.Location = new System.Drawing.Point(221, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 169);
            this.panel2.TabIndex = 13;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(82, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dejeja mesmo fechar o programa?";
            // 
            // aviso2
            // 
            this.aviso2.Location = new System.Drawing.Point(243, 124);
            this.aviso2.Name = "aviso2";
            this.aviso2.Size = new System.Drawing.Size(75, 23);
            this.aviso2.TabIndex = 1;
            this.aviso2.Text = "NÃO";
            this.aviso2.UseVisualStyleBackColor = true;
            this.aviso2.Click += new System.EventHandler(this.aviso2_Click);
            // 
            // aviso1
            // 
            this.aviso1.Location = new System.Drawing.Point(40, 124);
            this.aviso1.Name = "aviso1";
            this.aviso1.Size = new System.Drawing.Size(75, 23);
            this.aviso1.TabIndex = 0;
            this.aviso1.Text = "SIM";
            this.aviso1.UseVisualStyleBackColor = true;
            this.aviso1.Click += new System.EventHandler(this.aviso1_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(299, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 41);
            this.label4.TabIndex = 18;
            this.label4.Text = "Pauta Escolar";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 647);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button aviso2;
        private System.Windows.Forms.Button aviso1;
        private System.Windows.Forms.Label label4;
    }
}