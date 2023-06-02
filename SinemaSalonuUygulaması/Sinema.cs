using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaSalonuUygulaması
{
    public class Sinema
    {
        public string SinemaAd { get; set; }
        public int boşKoltukSayısı { get; set; }
        public double bakiye { get; set; }
       


        const double TAM = 15;
        const double İNDİRİMLİ = 10;

        public Sinema(string _SinemaAd,int _koltukSayısı)
        {
            SinemaAd = _SinemaAd;
            boşKoltukSayısı = _koltukSayısı;

            bakiye = 0;
        }
        
       
        public void BiletSat(bool indirimliMi)
        {
            
            if (indirimliMi)
            {               
                bakiye += İNDİRİMLİ;
                boşKoltukSayısı--;
                
            }
            else
            {
                bakiye += TAM;
                boşKoltukSayısı--;
            }

        }
        public void BiletİptaL(bool indirimliMi)
        {
            if (indirimliMi)
            {
                bakiye -= İNDİRİMLİ;
                boşKoltukSayısı++;
            }
            else
            {
                bakiye-=TAM;
                boşKoltukSayısı++;
            }
        }
        
    }
}
