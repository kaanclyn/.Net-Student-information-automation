using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netsunu
{
    internal class Odevnet
    {
        public static List<Odevnet> Ogrenciler = new List<Odevnet>();

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int OgrenciNo { get; set; }
        public string DogumTarihi { get; set; }
        public int KisaSinav { get; set; }
        public int Vize1 { get; set; }
        public int Vize2 { get; set; }
        public int Final { get; set; }
        public double Ortalama { get; set; }

        public Odevnet(string ad, string soyad, int ogrenciNo, string dogumTarihi, int kisaSinav, int vize1, int vize2, int final)
        {
            Ad = ad;
            Soyad = soyad;
            OgrenciNo = ogrenciNo;
            DogumTarihi = dogumTarihi;
            KisaSinav = kisaSinav;
            Vize1 = vize1;
            Vize2 = vize2;
            Final = final;
            try
            {
                Ortalama = HesaplaOrtalama(KisaSinav, Vize1, Vize2, Final);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                Ortalama = 0;
            }
            Ogrenciler.Add(this);
        }

        public double HesaplaOrtalama(int KisaSinav, int Vize1, int Vize2, int Final)
        {
            double ortalama = KisaSinav * 0.1 + Vize1 * 0.2 + Vize2 * 0.2 + Final * 0.5;
            if (ortalama < 0 || ortalama > 100)
            {
                throw new ArgumentException("Ortalama 0-100 arasında olmalıdır.");
            }
            return ortalama;
        }
    }
}
