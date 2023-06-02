using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaSalonuUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonBoşKoltuk.Enabled = false;
            buttonBiletİptal.Enabled = false;
            buttonBiletSat.Enabled = false;
            buttonBakiye.Enabled = false;
        }

        Sinema salon;
        private void buttonSinema_Click(object sender, EventArgs e)
        {
            int koltukSayısı = 0;
            bool result = Int32.TryParse(textBoxKoltuSayı.Text, out koltukSayısı);
            if (textBoxSalonAdı.Text == "")
            {
                MessageBox.Show("Lütfen Salon Adını Boş Geçmeyiniz!");
                return;
            }
            else
            {
                if (result)
                {
                    salon = new Sinema(textBoxSalonAdı.Text, int.Parse(textBoxKoltuSayı.Text));
                    buttonSinema.Enabled = false;
                    buttonBakiye.Enabled = true;
                    buttonBiletSat.Enabled = true;
                    buttonBiletİptal.Enabled = true;
                    buttonBoşKoltuk.Enabled = true;
                    labelInfo.ForeColor = Color.Red;
                    labelInfo.Text= "Sinema Salonu Oluşturuldu.";

                }
                else
                {
                    MessageBox.Show("Lütfen Koltuk sayısını sayısal değer Giriniz!");
                }
            }

        }

        private void buttonBiletSat_Click(object sender, EventArgs e)
        {
            if (salon.boşKoltukSayısı > 0)
            {
                salon.BiletSat(checkBoxİndirim.Checked);
                labelInfo.Text = "Bilet Satıldı. Kalan Boş Koltuk:" + salon.boşKoltukSayısı.ToString();
            }
            else
                labelInfo.Text = "Boş Koltuk  Yok!";
        }

        private void buttonBiletİptal_Click(object sender, EventArgs e)
        {
            if (salon.bakiye > 0)
            {
                salon.BiletİptaL(checkBoxİndirim.Checked);
                labelInfo.Text = "Bilet İptal Edildi!";
            }
            else
                labelInfo.Text = "Bakiye eksi Olamaz!";
        }

        private void buttonBakiye_Click(object sender, EventArgs e)
        {
            labelInfo.Text="Bakiye:"+salon.bakiye;
        }

        private void buttonBoşKoltuk_Click(object sender, EventArgs e)
        {
            labelInfo.Text = "Boş Koltuk Sayısı:" + salon.boşKoltukSayısı.ToString();
        }
    }
}
