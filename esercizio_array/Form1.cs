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
                if (trovato)
                {
                    lbl_nomisaldo.Text = ("persona: " + nomi[i] + "\nsaldo: " + saldi[i]);
                }
                else
                {
                    MessageBox.Show("numero di conto non valido");
                }
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] nomi = { "Rossi Mario", "Bianchi Luigi", "Belli Giulia", "Dotti Fabio", "Merli Gianna", "Zeri Giulio", "Botti Maria" };
            string[] conti = { "11264", "99780", "00342", "03419", "34562", "09887", "02341" };
            int[] saldi = { 11534, -2345, 3451, 127, 45673, -13, 3452 };
            string persona = txt_nome.Text;
            bool trovato = false;
            for (int i = 0; i < 7; i++)
            {
                if (nomi[i] == persona)
                {
                    lbl_contosaldo.Text = ("conto: " + conti[i] + "\nsaldo: " + saldi[i]);
                    trovato = true;
                }
                if (!trovato)
                {
                    MessageBox.Show("inserire una persona valido");
                    i = 6;
                }


            }
        }
    }
}
