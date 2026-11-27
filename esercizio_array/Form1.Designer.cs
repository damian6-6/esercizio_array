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
            this.btn_consaldo = new System.Windows.Forms.Button();
            this.lst_nomi = new System.Windows.Forms.ListBox();
            this.lst_conti = new System.Windows.Forms.ListBox();
            this.lst_saldi = new System.Windows.Forms.ListBox();
            this.btn_neg = new System.Windows.Forms.Button();
            this.btn_max = new System.Windows.Forms.Button();
            this.btn_media = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txt_conto = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_nomisaldo = new System.Windows.Forms.Label();
            this.lbl_contosaldo = new System.Windows.Forms.Label();
            this.lbl_neg = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_media = new System.Windows.Forms.Label();
            this.lbl_max = new System.Windows.Forms.Label();
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
            // btn_consaldo
            // 
            this.btn_consaldo.BackColor = System.Drawing.Color.MistyRose;
            this.btn_consaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consaldo.ForeColor = System.Drawing.Color.Blue;
            this.btn_consaldo.Location = new System.Drawing.Point(64, 361);
            this.btn_consaldo.Name = "btn_consaldo";
            this.btn_consaldo.Size = new System.Drawing.Size(103, 47);
            this.btn_consaldo.TabIndex = 1;
            this.btn_consaldo.Text = "Visualizza conto \r\ne saldo";
            this.btn_consaldo.UseVisualStyleBackColor = false;
            this.btn_consaldo.Click += new System.EventHandler(this.button2_Click);
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
            // btn_neg
            // 
            this.btn_neg.BackColor = System.Drawing.Color.MistyRose;
            this.btn_neg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_neg.ForeColor = System.Drawing.Color.Blue;
            this.btn_neg.Location = new System.Drawing.Point(331, 182);
            this.btn_neg.Name = "btn_neg";
            this.btn_neg.Size = new System.Drawing.Size(105, 53);
            this.btn_neg.TabIndex = 5;
            this.btn_neg.Text = "Visualizza persone con \r\nconto negativo";
            this.btn_neg.UseVisualStyleBackColor = false;
            this.btn_neg.Click += new System.EventHandler(this.btn_neg_Click);
            // 
            // btn_max
            // 
            this.btn_max.BackColor = System.Drawing.Color.MistyRose;
            this.btn_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_max.ForeColor = System.Drawing.Color.Blue;
            this.btn_max.Location = new System.Drawing.Point(557, 277);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(102, 54);
            this.btn_max.TabIndex = 6;
            this.btn_max.Text = "Visualizza persona con \r\nsaldo massimo";
            this.btn_max.UseVisualStyleBackColor = false;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_media
            // 
            this.btn_media.BackColor = System.Drawing.Color.MistyRose;
            this.btn_media.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_media.ForeColor = System.Drawing.Color.Blue;
            this.btn_media.Location = new System.Drawing.Point(557, 183);
            this.btn_media.Name = "btn_media";
            this.btn_media.Size = new System.Drawing.Size(102, 52);
            this.btn_media.TabIndex = 7;
            this.btn_media.Text = "Visualizza media saldi";
            this.btn_media.UseVisualStyleBackColor = false;
            this.btn_media.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MistyRose;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Blue;
            this.button6.Location = new System.Drawing.Point(331, 277);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 63);
            this.button6.TabIndex = 8;
            this.button6.Text = "Visualizza persona con saldo crescente";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
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
            // lbl_neg
            // 
            this.lbl_neg.AutoSize = true;
            this.lbl_neg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_neg.Location = new System.Drawing.Point(442, 183);
            this.lbl_neg.Name = "lbl_neg";
            this.lbl_neg.Size = new System.Drawing.Size(56, 13);
            this.lbl_neg.TabIndex = 15;
            this.lbl_neg.Text = "persone:";
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
            // lbl_media
            // 
            this.lbl_media.AutoSize = true;
            this.lbl_media.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_media.Location = new System.Drawing.Point(672, 183);
            this.lbl_media.Name = "lbl_media";
            this.lbl_media.Size = new System.Drawing.Size(74, 13);
            this.lbl_media.TabIndex = 17;
            this.lbl_media.Text = "media saldi:";
            // 
            // lbl_max
            // 
            this.lbl_max.AutoSize = true;
            this.lbl_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_max.Location = new System.Drawing.Point(672, 282);
            this.lbl_max.Name = "lbl_max";
            this.lbl_max.Size = new System.Drawing.Size(56, 13);
            this.lbl_max.TabIndex = 18;
            this.lbl_max.Text = "persona:";
            // 
            // btn_nomi
            // 
            this.btn_nomi.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_nomi.Location = new System.Drawing.Point(224, 72);
            this.btn_nomi.Name = "btn_nomi";
            this.btn_nomi.Size = new System.Drawing.Size(75, 38);
            this.btn_nomi.TabIndex = 19;
            this.btn_nomi.Text = "STAMPA NOMI";
            this.btn_nomi.UseVisualStyleBackColor = false;
            this.btn_nomi.Click += new System.EventHandler(this.btn_nomi_Click);
            // 
            // btn_numero
            // 
            this.btn_numero.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_numero.Location = new System.Drawing.Point(457, 72);
            this.btn_numero.Name = "btn_numero";
            this.btn_numero.Size = new System.Drawing.Size(75, 38);
            this.btn_numero.TabIndex = 20;
            this.btn_numero.Text = "STAMPA CONTI";
            this.btn_numero.UseVisualStyleBackColor = false;
            this.btn_numero.Click += new System.EventHandler(this.btn_numero_Click);
            // 
            // btn_saldo
            // 
            this.btn_saldo.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_saldo.Location = new System.Drawing.Point(713, 72);
            this.btn_saldo.Name = "btn_saldo";
            this.btn_saldo.Size = new System.Drawing.Size(75, 38);
            this.btn_saldo.TabIndex = 21;
            this.btn_saldo.Text = "STAMPA SALDI";
            this.btn_saldo.UseVisualStyleBackColor = false;
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
            this.Controls.Add(this.lbl_max);
            this.Controls.Add(this.lbl_media);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_neg);
            this.Controls.Add(this.lbl_contosaldo);
            this.Controls.Add(this.lbl_nomisaldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_conto);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btn_media);
            this.Controls.Add(this.btn_max);
            this.Controls.Add(this.btn_neg);
            this.Controls.Add(this.lst_saldi);
            this.Controls.Add(this.lst_conti);
            this.Controls.Add(this.lst_nomi);
            this.Controls.Add(this.btn_consaldo);
            this.Controls.Add(this.btn_persaldo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_persaldo;
        private System.Windows.Forms.Button btn_consaldo;
        private System.Windows.Forms.ListBox lst_nomi;
        private System.Windows.Forms.ListBox lst_conti;
        private System.Windows.Forms.ListBox lst_saldi;
        private System.Windows.Forms.Button btn_neg;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.Button btn_media;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txt_conto;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_nomisaldo;
        private System.Windows.Forms.Label lbl_contosaldo;
        private System.Windows.Forms.Label lbl_neg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_media;
        private System.Windows.Forms.Label lbl_max;
        private System.Windows.Forms.Button btn_nomi;
        private System.Windows.Forms.Button btn_numero;
        private System.Windows.Forms.Button btn_saldo;
    }
}

