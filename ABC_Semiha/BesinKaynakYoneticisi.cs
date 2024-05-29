using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Semiha

    // Bu sınıfım ile bir miktar besin kaynağı oluşturupladım.Ve en iyisini seçtp her besin kaynağının fit değerini hesaim.
{
    class BesinKaynakYoneticisi
    {
        private BesinKaynak[] besinler;
        int besin_kaynak;
        int altSinir;
        int ustSinir;
        internal BesinKaynak[] Besinler { get => besinler; set => besinler = value; }

        public BesinKaynakYoneticisi(int yemekKaynak, int altSinir, int ustSinir)
        {
            this.besin_kaynak = yemekKaynak;
            this.altSinir = altSinir;
            this.ustSinir = ustSinir;
            Besinler = new BesinKaynak[yemekKaynak];

        }

        public void besinOlustur()
        {
            for (int i = 0; i < besin_kaynak; i++)
            {
                Besinler[i] = new BesinKaynak(altSinir, ustSinir);
            }
        }
        
       public void olasilik_hesabi_isci_ari()
        {
            ABC_Semiha.BesinKaynak.olasiklikDegerleriVer(Besinler);
        }
    
        public BesinKaynak bestBesin()
        {
            BesinKaynak best = Besinler[0];
            for (int i = 1; i < Besinler.Length; i++)
            {
                if (best.fit < Besinler[i].fit)
                {
                    best = Besinler[i];
                }
            }
            return best;
        }

    }
}
