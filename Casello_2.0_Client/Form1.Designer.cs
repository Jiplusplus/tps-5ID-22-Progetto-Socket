
namespace Casello_2._0
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mancante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.invio_contanti = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.invio_carta = new System.Windows.Forms.Button();
            this.txt_pin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.list_eventi = new System.Windows.Forms.ListBox();
            this.connetti = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(48, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 430);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.mancante);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_num);
            this.panel2.Controls.Add(this.invio_contanti);
            this.panel2.Location = new System.Drawing.Point(26, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 377);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "IMPORTO MANCANTE";
            // 
            // mancante
            // 
            this.mancante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mancante.Location = new System.Drawing.Point(23, 171);
            this.mancante.Name = "mancante";
            this.mancante.Size = new System.Drawing.Size(221, 22);
            this.mancante.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "IMPORTO INSERITO";
            // 
            // txt_num
            // 
            this.txt_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num.Location = new System.Drawing.Point(25, 86);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(221, 22);
            this.txt_num.TabIndex = 15;
            // 
            // invio_contanti
            // 
            this.invio_contanti.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.invio_contanti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invio_contanti.Location = new System.Drawing.Point(83, 247);
            this.invio_contanti.Name = "invio_contanti";
            this.invio_contanti.Size = new System.Drawing.Size(92, 56);
            this.invio_contanti.TabIndex = 14;
            this.invio_contanti.Text = "INVIO";
            this.invio_contanti.UseVisualStyleBackColor = false;
            this.invio_contanti.Click += new System.EventHandler(this.invio_contanti_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(453, 198);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(323, 430);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel4.Controls.Add(this.invio_carta);
            this.panel4.Controls.Add(this.txt_pin);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(26, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(265, 377);
            this.panel4.TabIndex = 0;
            // 
            // invio_carta
            // 
            this.invio_carta.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.invio_carta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invio_carta.Location = new System.Drawing.Point(93, 247);
            this.invio_carta.Name = "invio_carta";
            this.invio_carta.Size = new System.Drawing.Size(92, 56);
            this.invio_carta.TabIndex = 21;
            this.invio_carta.Text = "INVIO";
            this.invio_carta.UseVisualStyleBackColor = false;
            this.invio_carta.Click += new System.EventHandler(this.invio_carta_Click_1);
            // 
            // txt_pin
            // 
            this.txt_pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pin.Location = new System.Drawing.Point(26, 129);
            this.txt_pin.Name = "txt_pin";
            this.txt_pin.Size = new System.Drawing.Size(221, 22);
            this.txt_pin.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "IMPORTO INSERITO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(80, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 31);
            this.label6.TabIndex = 19;
            this.label6.Text = "CONTANTI";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkCyan;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(49, 128);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(322, 73);
            this.panel5.TabIndex = 21;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkCyan;
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(454, 128);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(322, 73);
            this.panel6.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(98, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 31);
            this.label8.TabIndex = 19;
            this.label8.Text = "CARTA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(162, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 2;
            // 
            // list_eventi
            // 
            this.list_eventi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_eventi.FormattingEnabled = true;
            this.list_eventi.ItemHeight = 16;
            this.list_eventi.Location = new System.Drawing.Point(445, 21);
            this.list_eventi.Name = "list_eventi";
            this.list_eventi.Size = new System.Drawing.Size(330, 68);
            this.list_eventi.TabIndex = 24;
            // 
            // connetti
            // 
            this.connetti.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.connetti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connetti.Location = new System.Drawing.Point(135, 30);
            this.connetti.Name = "connetti";
            this.connetti.Size = new System.Drawing.Size(173, 56);
            this.connetti.TabIndex = 25;
            this.connetti.Text = "CONNETTI";
            this.connetti.UseVisualStyleBackColor = false;
            this.connetti.Click += new System.EventHandler(this.connetti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(828, 703);
            this.Controls.Add(this.connetti);
            this.Controls.Add(this.list_eventi);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button invio_contanti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mancante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_pin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox list_eventi;
        private System.Windows.Forms.Button invio_carta;
        private System.Windows.Forms.Button connetti;
    }
}

