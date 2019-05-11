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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            for(int a = 10; a >= 1; a--)
            {
                listBox2.Items.Add(a);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int value = vScrollBar1.Value;
            listBox3.Items.Clear();

            for (int b = 1; b <= value; b++)
            {
                toplam += b;
                listBox3.Items.Add(toplam);
            }
        }

        private void VScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            label3.Text = vScrollBar1.Value.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            for(char ch = 'a'; ch < 'z'; ch++)
            {
                listBox4.Items.Add(string.Format("Harf:{0} - Kod:{1}", ch, Convert.ToInt32(ch)));
            }                   

        }

        private void BtnIslemYap_Click(object sender, EventArgs e)
        {

            int tekToplam = 0;
            int ciftToplam = 0;
            int fark = 0;

            for(int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    ciftToplam += i;
                }
                else
                {
                    tekToplam += i;
                }
            }
            fark = tekToplam - ciftToplam;

            listBox5.Items.Add(fark * fark);
        }

        private void CarpimTablosu_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    lstCarpimTablosu.Items.Add(string.Format("{0}x{1}={2}", i, j, i * j));
                }
            }
        }
    }
}