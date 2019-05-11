using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tekCiftToplamı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int deger = 0;
            int tektoplam = 0;
            int cifttoplam = 0;

            while (deger<=100)
            {
                if (deger % 2 == 0)
                {
                    cifttoplam += deger;
                }
                else
                {
                    tektoplam += deger;
                }

                deger++;
            }

            textBox1.Text = tektoplam.ToString();
            textBox2.Text = cifttoplam.ToString();
        } //Tek ve Çift sayı toplamları While döngüsü

        private void Button2_Click(object sender, EventArgs e)
        {
            int deger = 1;
            string metin = "Merhaba";

            while (deger<=100)
            {
                listBox1.Items.Add(string.Format("{0}-{1}",deger,metin));
                deger++;
            }

            label3.Text = listBox1.Items.Count.ToString();
        } //Listbox içerisine yazdırma ve adet bulma While döngüsü

        private void Hesapla_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi = Convert.ToInt32(nmSayi.Value);
                int faktoriyel = 1;
                string fakt = "";

                while (sayi > 0)
                {
                    fakt = fakt + sayi + "*";
                    faktoriyel *= sayi;
                    sayi--;
                }
                lblSayilar.Text = fakt;

                lblSonuc.Text = faktoriyel.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }  //Faktoriyel Hesaplama While döngüsü
    }
}
