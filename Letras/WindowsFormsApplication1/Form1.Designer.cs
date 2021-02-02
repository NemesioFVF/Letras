namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bl = new System.Windows.Forms.Button();
            this.badd = new System.Windows.Forms.Button();
            this.nome = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.list = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.consoantes = new System.Windows.Forms.Label();
            this.vogais = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.palindrome = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // bl
            // 
            this.bl.BackColor = System.Drawing.Color.Black;
            this.bl.ForeColor = System.Drawing.Color.White;
            this.bl.Location = new System.Drawing.Point(429, 150);
            this.bl.Name = "bl";
            this.bl.Size = new System.Drawing.Size(119, 31);
            this.bl.TabIndex = 25;
            this.bl.Text = "LIMPAR";
            this.bl.UseVisualStyleBackColor = false;
            this.bl.Click += new System.EventHandler(this.bl_Click);
            // 
            // badd
            // 
            this.badd.BackColor = System.Drawing.Color.Black;
            this.badd.ForeColor = System.Drawing.Color.White;
            this.badd.Location = new System.Drawing.Point(276, 150);
            this.badd.Name = "badd";
            this.badd.Size = new System.Drawing.Size(105, 31);
            this.badd.TabIndex = 23;
            this.badd.Text = "ADICIONAR";
            this.badd.UseVisualStyleBackColor = false;
            this.badd.Click += new System.EventHandler(this.badd_Click);
            // 
            // nome
            // 
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.ForeColor = System.Drawing.Color.Black;
            this.nome.Location = new System.Drawing.Point(175, 104);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(408, 26);
            this.nome.TabIndex = 22;
            this.nome.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.nota_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(76, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "NOMES";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Menu;
            this.panel5.Controls.Add(this.list);
            this.panel5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel5.Location = new System.Drawing.Point(16, 182);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(206, 268);
            this.panel5.TabIndex = 20;
            // 
            // list
            // 
            this.list.BackColor = System.Drawing.SystemColors.InfoText;
            this.list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list.ForeColor = System.Drawing.Color.Yellow;
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 20;
            this.list.Location = new System.Drawing.Point(12, 11);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(179, 244);
            this.list.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "DIGITE OS NOMES:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel4.Location = new System.Drawing.Point(-2, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(614, 10);
            this.panel4.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Location = new System.Drawing.Point(-3, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(615, 10);
            this.panel3.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Location = new System.Drawing.Point(-8, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 10);
            this.panel2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(261, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "NOMES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel1.Location = new System.Drawing.Point(-4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 10);
            this.panel1.TabIndex = 14;
            // 
            // consoantes
            // 
            this.consoantes.AutoSize = true;
            this.consoantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoantes.ForeColor = System.Drawing.Color.Yellow;
            this.consoantes.Location = new System.Drawing.Point(516, 360);
            this.consoantes.Name = "consoantes";
            this.consoantes.Size = new System.Drawing.Size(14, 20);
            this.consoantes.TabIndex = 30;
            this.consoantes.Text = "-";
            // 
            // vogais
            // 
            this.vogais.AutoSize = true;
            this.vogais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vogais.ForeColor = System.Drawing.Color.Yellow;
            this.vogais.Location = new System.Drawing.Point(516, 319);
            this.vogais.Name = "vogais";
            this.vogais.Size = new System.Drawing.Size(14, 20);
            this.vogais.TabIndex = 29;
            this.vogais.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Menu;
            this.label5.Location = new System.Drawing.Point(282, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "INICIAM COM CONSOANTES:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Menu;
            this.label4.Location = new System.Drawing.Point(282, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "INICIAM COM VOGAIS:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // palindrome
            // 
            this.palindrome.AutoSize = true;
            this.palindrome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.palindrome.ForeColor = System.Drawing.Color.Yellow;
            this.palindrome.Location = new System.Drawing.Point(516, 273);
            this.palindrome.Name = "palindrome";
            this.palindrome.Size = new System.Drawing.Size(14, 20);
            this.palindrome.TabIndex = 32;
            this.palindrome.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Menu;
            this.label7.Location = new System.Drawing.Point(282, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Nº DE PALÍNDROME:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(276, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 31);
            this.button1.TabIndex = 33;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(608, 462);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.palindrome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.consoantes);
            this.Controls.Add(this.vogais);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bl);
            this.Controls.Add(this.badd);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bl;
        private System.Windows.Forms.Button badd;
        private System.Windows.Forms.MaskedTextBox nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label consoantes;
        private System.Windows.Forms.Label vogais;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label palindrome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}

