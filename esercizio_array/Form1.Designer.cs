namespace esercizio_array
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
            this.btn_persaldo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lst_nomi = new System.Windows.Forms.ListBox();
            this.lst_conti = new System.Windows.Forms.ListBox();
            this.lst_saldi = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txt_conto = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_nomisaldo = new System.Windows.Forms.Label();
            this.lbl_contosaldo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_nomi = new System.Windows.Forms.Button();
            this.btn_numero = new System.Windows.Forms.Button();
            this.btn_saldo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_persaldo
            // 
            this.btn_persaldo.BackColor = System.Drawing.Color.MistyRose;
            this.btn_persaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_persaldo.ForeColor = System.Drawing.Color.Blue;
            this.btn_persaldo.Location = new System.Drawing.Point(64, 282);
            this.btn_persaldo.Name = "btn_persaldo";
            this.btn_persaldo.Size = new System.Drawing.Size(103, 49);
            this.btn_persaldo.TabIndex = 0;
            this.btn_persaldo.Text = "Visualizza persona\r\n e saldo";
            this.btn_persaldo.UseVisualStyleBackColor = false;
            this.btn_persaldo.Click += new System.EventHandler(this.btn_persaldo_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MistyRose;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(64, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Visualizza conto \r\ne saldo";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lst_nomi
            // 
            this.lst_nomi.BackColor = System.Drawing.Color.MintCream;
            this.lst_nomi.FormattingEnabled = true;
            this.lst_nomi.Location = new System.Drawing.Point(64, 34);
            this.lst_nomi.Name = "lst_nomi";
            this.lst_nomi.Size = new System.Drawing.Size(143, 108);
            this.lst_nomi.TabIndex = 2;
            // 
            // lst_conti
            // 
            this.lst_conti.BackColor = System.Drawing.Color.MintCream;
            this.lst_conti.FormattingEnabled = true;
            this.lst_conti.Location = new System.Drawing.Point(316, 34);
            this.lst_conti.Name = "lst_conti";
            this.lst_conti.Size = new System.Drawing.Size(135, 108);
            this.lst_conti.TabIndex = 3;
            // 
            // lst_saldi
            // 
            this.lst_saldi.BackColor = System.Drawing.Color.MintCream;
            this.lst_saldi.FormattingEnabled = true;
            this.lst_saldi.Location = new System.Drawing.Point(546, 34);
            this.lst_saldi.Name = "lst_saldi";
            this.lst_saldi.Size = new System.Drawing.Size(149, 108);
            this.lst_saldi.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MistyRose;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(331, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 53);
            this.button3.TabIndex = 5;
            this.button3.Text = "Visualizza persone con \r\nconto negativo";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MistyRose;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(557, 277);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 54);
            this.button4.TabIndex = 6;
            this.button4.Text = "Visualizza persona con \r\nsaldo massimo";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MistyRose;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Blue;
            this.button5.Location = new System.Drawing.Point(557, 183);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 52);
            this.button5.TabIndex = 7;
            this.button5.Text = "Visualizza media saldi";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MistyRose;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Blue;
            this.button6.Location = new System.Drawing.Point(331, 277);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 54);
            this.button6.TabIndex = 8;
            this.button6.Text = "Visualizza persona con saldo crescente";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // txt_conto
            // 
            this.txt_conto.BackColor = System.Drawing.Color.Cyan;
            this.txt_conto.Location = new System.Drawing.Point(67, 189);
            this.txt_conto.Name = "txt_conto";
            this.txt_conto.Size = new System.Drawing.Size(100, 20);
            this.txt_conto.TabIndex = 9;
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.Color.Cyan;
            this.txt_nome.Location = new System.Drawing.Point(67, 238);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "inserisci numero conto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "inserisci nome cognome:";
            // 
            // lbl_nomisaldo
            // 
            this.lbl_nomisaldo.AutoSize = true;
            this.lbl_nomisaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomisaldo.Location = new System.Drawing.Point(173, 282);
            this.lbl_nomisaldo.Name = "lbl_nomisaldo";
            this.lbl_nomisaldo.Size = new System.Drawing.Size(56, 26);
            this.lbl_nomisaldo.TabIndex = 13;
            this.lbl_nomisaldo.Text = "persona:\r\nsaldo:\r\n";
            // 
            // lbl_contosaldo
            // 
            this.lbl_contosaldo.AutoSize = true;
            this.lbl_contosaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contosaldo.Location = new System.Drawing.Point(173, 361);
            this.lbl_contosaldo.Name = "lbl_contosaldo";
            this.lbl_contosaldo.Size = new System.Drawing.Size(43, 26);
            this.lbl_contosaldo.TabIndex = 14;
            this.lbl_contosaldo.Text = "conto:\r\nsaldo:\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(442, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "persone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(442, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "persona:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(672, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "media saldi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(672, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "persona:";
            // 
            // btn_nomi
            // 
            this.btn_nomi.Location = new System.Drawing.Point(222, 80);
            this.btn_nomi.Name = "btn_nomi";
            this.btn_nomi.Size = new System.Drawing.Size(75, 23);
            this.btn_nomi.TabIndex = 19;
            this.btn_nomi.Text = "button7";
            this.btn_nomi.UseVisualStyleBackColor = true;
            this.btn_nomi.Click += new System.EventHandler(this.btn_nomi_Click);
            // 
            // btn_numero
            // 
            this.btn_numero.Location = new System.Drawing.Point(457, 80);
            this.btn_numero.Name = "btn_numero";
            this.btn_numero.Size = new System.Drawing.Size(75, 23);
            this.btn_numero.TabIndex = 20;
            this.btn_numero.Text = "button8";
            this.btn_numero.UseVisualStyleBackColor = true;
            this.btn_numero.Click += new System.EventHandler(this.btn_numero_Click);
            // 
            // btn_saldo
            // 
            this.btn_saldo.Location = new System.Drawing.Point(713, 80);
            this.btn_saldo.Name = "btn_saldo";
            this.btn_saldo.Size = new System.Drawing.Size(75, 23);
            this.btn_saldo.TabIndex = 21;
            this.btn_saldo.Text = "button9";
            this.btn_saldo.UseVisualStyleBackColor = true;
            this.btn_saldo.Click += new System.EventHandler(this.btn_saldo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_saldo);
            this.Controls.Add(this.btn_numero);
            this.Controls.Add(this.btn_nomi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_contosaldo);
            this.Controls.Add(this.lbl_nomisaldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_conto);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lst_saldi);
            this.Controls.Add(this.lst_conti);
            this.Controls.Add(this.lst_nomi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_persaldo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_persaldo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lst_nomi;
        private System.Windows.Forms.ListBox lst_conti;
        private System.Windows.Forms.ListBox lst_saldi;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txt_conto;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_nomisaldo;
        private System.Windows.Forms.Label lbl_contosaldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_nomi;
        private System.Windows.Forms.Button btn_numero;
        private System.Windows.Forms.Button btn_saldo;
    }
}

