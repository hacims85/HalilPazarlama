using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalilPazarlama
{
    public class BuzDolabi
    {
        public string Marka;
        public string Model;
        public double Fiyat;
        public int IcHacim;
        public int KapiSayisi;
        public bool BuzMakinasi;
        public BuzDolabi(string marka, string model, double fiyat, int icHacim, int kapiSayisi, bool buzMakinasi)
        {
            Marka = marka;
            Model = model;
            Fiyat = fiyat;
            IcHacim = icHacim;
            KapiSayisi = kapiSayisi;
            BuzMakinasi = buzMakinasi;
        }

        public string Yazdir()
        {
            return $"Marka={Marka} Model={Model}\nKapi Sayisi={KapiSayisi} Buz Makinası={BuzMakinasi}\nFiyat={Fiyat}";
        }
    }
}
