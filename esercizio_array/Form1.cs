using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esercizio_array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_nomi_Click(object sender, EventArgs e)
        {
            string[] nomi = { "Rossi Mario", "Bianchi Luigi", "Belli Giulia", "Dotti Fabio", "Merli Gianna", "Zeri Giulio", "Botti Maria" };
            for (int i = 0; i < nomi.Length; i++)
            {
                lst_nomi.Items.Add(nomi[i]);
            }
            btn_nomi.Enabled = false;
        }

        private void btn_numero_Click(object sender, EventArgs e)
        {
            string[] conti = { "11264", "99780", "00342", "03419", "34562", "09887", "02341" };
            for (int i = 0; i < conti.Length; i++) 
            { 
            lst_conti.Items.Add(conti[i]);
            }
            btn_numero.Enabled = false;
        }

        private void btn_saldo_Click(object sender, EventArgs e)
        {
            int[] saldi = { 11534, -2345, 3451, 127, 45673, -13, 3452 };
            for (int i = 0; i < saldi.Length; i++) 
            {
                lst_saldi.Items.Add(saldi[i]);
            }
            btn_saldo.Enabled = false;
        }

        private void btn_persaldo_Click(object sender, EventArgs e)
        {
            string[] nomi = { "Rossi Mario", "Bianchi Luigi", "Belli Giulia", "Dotti Fabio", "Merli Gianna", "Zeri Giulio", "Botti Maria" };
            string[] conti = { "11264", "99780", "00342", "03419", "34562", "09887", "02341" };
            int[] saldi = { 11534, -2345, 3451, 127, 45673, -13, 3452 };
            string  conto = txt_conto.Text;
            bool trovato = false;
            int i = 0;
            while (i < 7 && !trovato)
            {
                if (conti[i] == conto)
                {
                    trovato = true;
                }
                else
                {
                    i++;
                }
               
            }
            if (trovato)
            {
                lbl_nomisaldo.Text = ("persona: " + nomi[i] + "\nsaldo: " + saldi[i]);
            }
            else
            {
                MessageBox.Show("numero di conto non valido");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] nomi = { "Rossi Mario", "Bianchi Luigi", "Belli Giulia", "Dotti Fabio", "Merli Gianna", "Zeri Giulio", "Botti Maria" };
            string[] conti = { "11264", "99780", "00342", "03419", "34562", "09887", "02341" };
            int[] saldi = { 11534, -2345, 3451, 127, 45673, -13, 3452 };
            string persona = txt_nome.Text;
            bool trovato = false;
            int i = 0;
            while (i < 7 && !trovato)
            {
                if (nomi[i] == persona)
                {
                    trovato = true;
                }
                else
                {
                    i++;
                }

            }
            if (trovato)
            {
                lbl_contosaldo.Text = ("conto: " + conti[i] + "\nsaldo: " + saldi[i]);
            }
            else
            {
                MessageBox.Show("nome e cognome della persona non valido");
            }
        }

        private void btn_neg_Click(object sender, EventArgs e)
        {
            string[] nomi = { "Rossi Mario", "Bianchi Luigi", "Belli Giulia", "Dotti Fabio", "Merli Gianna", "Zeri Giulio", "Botti Maria" };
            int[] saldi = { 11534, -2345, 3451, 127, 45673, -13, 3452 };
            lbl_neg.Text = "persone: ";

            for ( int i =0; i < saldi.Length; i++)
            {
                if (saldi[i] < 0)
                {
                    lbl_neg.Text += "\n" + nomi[i];
                }
            }

        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            string[] nomi = { "Rossi Mario", "Bianchi Luigi", "Belli Giulia", "Dotti Fabio", "Merli Gianna", "Zeri Giulio", "Botti Maria" };
            int[] saldi = { 11534, -2345, 3451, 127, 45673, -13, 3452 };
            int max = 0;
     

            for ( int i=0; i < saldi.Length; i++)
            {
                if (i == 0)
                {
                    max = saldi[i];
                }
                else if (saldi[i] > max)
                {
                    max = saldi[i];
                    lbl_max.Text = "persona: \n" + nomi[i];
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] saldi = { 11534, -2345, 3451, 127, 45673, -13, 3452 };
            int tot = 0;
            double media;
            for ( int i = 0; i < saldi.Length; i++)
            {
                tot = tot + saldi[i];
            }
            media = tot / saldi.Length;
            lbl_media.Text ="media: " + media.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] nomi = { "Rossi Mario", "Bianchi Luigi", "Belli Giulia", "Dotti Fabio", "Merli Gianna", "Zeri Giulio", "Botti Maria" };
            int[] saldi = { 11534, -2345, 3451, 127, 45673, -13, 3452 };
        }
    }
}
