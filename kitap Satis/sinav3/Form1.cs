using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinav3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        double kasaFiyat = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int adetNutuk, adetAvci, adetHarry, adetToplam;
            double ucretNutuk, ucretAvci, ucretHarry, toplamFiyat, indirim;

            adetNutuk = Convert.ToInt32(textBox1.Text);
            adetAvci = Convert.ToInt32(textBox2.Text);
            adetHarry = Convert.ToInt32(textBox3.Text);

            ucretNutuk = Convert.ToDouble(textBox4.Text);
            ucretAvci = Convert.ToDouble(textBox5.Text);
            ucretHarry = Convert.ToDouble(textBox6.Text);

            adetToplam = adetNutuk + adetHarry + adetAvci;
            toplamFiyat = (adetNutuk * ucretNutuk) + (adetAvci * ucretAvci) + (adetHarry * ucretHarry);

            if (adetToplam >= 37)
            {
                indirim = toplamFiyat * 20 / 100;
                toplamFiyat = toplamFiyat - indirim;
                label4.Text  = toplamFiyat.ToString();
            }
            else
            {
                label4.Text = toplamFiyat.ToString();
            }
            kasaFiyat = kasaFiyat + toplamFiyat;
            label5.Text = kasaFiyat.ToString();
        }
    }
}
