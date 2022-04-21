using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Úkol_3_řetězce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            label1.Text = "Počet slov: ";
            label2.Text = "Počet cifer: ";
            label3.Text = "Počet písmen: ";
            label4.Text = "Nejdelší slovo: ";
            label5.Text = "Upraveno: ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string retezec = textBox1.Text;
            retezec = retezec.Trim();
            int pocetSlov = retezec.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Length;
            string[] slova = retezec.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            char[] pismena = textBox1.Text.ToCharArray();
            string cisla = "0123456789";
            string nejvetsi = "";
            int pocetCifer = 0, pocetPismen = 0;

            foreach (string c in slova)
            {
                if (nejvetsi.Length < c.Length)
                {
                    nejvetsi = c;
                }
            }

            foreach (char c in retezec)
            {
                if (cisla.Contains(c))
                {
                    pocetCifer++;
                }
                if (c != ' ' && ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')))
                {
                    pocetPismen++;
                }
            }

            try
            {
                string posledni = retezec[retezec.Length - 1].ToString();
                string uprava;

                if (retezec.Length % 2 == 0)
                {
                    uprava = retezec.Insert(retezec.Length / 2, posledni);
                }
                else
                {
                    uprava = retezec.Insert((retezec.Length - 1) / 2, posledni);
                }

                label1.Text = "Počet slov: " + pocetSlov.ToString();
                label2.Text = "Počet cifer: " + pocetCifer.ToString();
                label3.Text = "Počet písmen: " + pocetPismen.ToString();
                label4.Text = "Nejdelší slovo: " + nejvetsi;
                label5.Text = "Upraveno: " + uprava;
            }
            catch
            {
                MessageBox.Show("Napište větu.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tento program rozloží větu a vypíše:\n-počet slov\n- počet písmen\n- počet cifer\n- nejdelší slovo\n- a vloží poslední znak doprostřed", "INFO:", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
