using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace romaliasker
{
    public partial class frmAsker : Form
    {
        public frmAsker()
        {
            InitializeComponent();
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int askerSayisi = Convert.ToInt16(txtAskerSayisi.Text);
            int adimSayisi = Convert.ToInt16(txtAdimSayisi.Text);
            string asama = "";
            lblIlkDeger.Text = "Girilen Asker Sayısı " + askerSayisi.ToString() + "\nGirilen Adım Sayısı" + adimSayisi.ToString();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            //hesaplama yaparken tekrar değer girmemesi için
            txtAdimSayisi.Enabled = true;
            txtAskerSayisi.Enabled = true;
            int[] kisiler = new int[askerSayisi];
            for (int i = 0; i < askerSayisi; i++)
            {
                kisiler[i] = 1;//hepsi yaşıyor
            }
            int oluAskerSayisi = 0, j = -1, k = 0;

            while (oluAskerSayisi != (askerSayisi - 2))
            {
                while (k != askerSayisi)
                {
                    j++;
                    if (j == askerSayisi)
                        j = 0;
                    if (kisiler[j] == 1)
                        k++;
                }
                oluAskerSayisi++;
                k = 0;
                kisiler[j] = 0;
                for (int i = 0; i < askerSayisi; i++)
                {
                    asama += kisiler[i].ToString() + " - ";
                    lblDegerler.Text = asama;
                }
                asama += "\n";
            }
            string sonuc = "";
            for (int i = 0; i < askerSayisi; i++)
            {
                if (kisiler[i] == 1)
                    sonuc += (i + 1).ToString() + " ";
                lblKalanAsker.Text = sonuc;
            }
            txtAskerSayisi.Text = "";
            txtAdimSayisi.Text = "";
            sw.Stop();
            lblGecenSure.Text = sw.ElapsedMilliseconds.ToString();
        }
        private void txtAskerSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAdimSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void frmAsker_Load(object sender, EventArgs e)
        {

        }
    }
}
