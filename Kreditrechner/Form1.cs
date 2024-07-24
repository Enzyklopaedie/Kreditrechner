using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kredit_fuss1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double schulden, rate, zinssatz, zinsen, kosten, gerundet, zwischi;
            int monat;
            monat = 0; kosten = 0;

            if (textBox2.Text != "" && textBox1.Text != "" && textBox3.Text != "")
            {
                schulden = Convert.ToDouble(textBox1.Text);
                zinssatz = Convert.ToDouble(textBox3.Text);
                rate = Convert.ToDouble(textBox2.Text);
                zwischi = schulden * (zinssatz / 100);
                if (zwischi >= rate)
                {
                    label4.Text = "Die Rate darf nicht mehr als der Zinssatz sein";
                }
                else
                {
                    do
                    {
                        zinsen = schulden * (zinssatz / 100);
                        schulden = schulden + zinsen - rate;
                        kosten = kosten + zinsen;
                        monat++;

                    } while (schulden > 0);
                    gerundet = Math.Round(kosten, 2);
                    label4.Text = "Nach " + monat + " Monaten sind alle Schulden abbezahlt\r\n mit zusätzlichen Kosten von " + gerundet + "€.";
                }
            }
        }
    }
}
