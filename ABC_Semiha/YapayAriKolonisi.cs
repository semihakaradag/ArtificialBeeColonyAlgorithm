using System;
using System.Collections.Generic;

namespace ABC_Semiha
{
    class YapayAriKolonisi
    {
        int cevrimSayisi; // Toplam döngü sayısı (iterations)
        int yemekKaynak; // Yemek kaynaklarının sayısı
        int denemeSayisi; // Maksimum deneme sayısı

        int isciAri;
        int gozcuAri;

        public BesinKaynakYoneticisi besin;

        public double bestX;
        public double bestY;

        public List<double> fxDegerleri = new List<double>();

       
        public List<double> fit_degerleri = new List<double>();

        
        public List<double> bestXlist = new List<double>();
        public List<double> bestYlist = new List<double>();

        
        public static readonly Object kilit_obj = new Object(); // Eşzamanlılık için kilit objesi
        public static readonly Random rnd = new Random();


       

        int altSinir;
        int ustSinir;
        int koloniBoyutu;
        public YapayAriKolonisi(int koloniBoyutu, int altSinir, int ustSinir, int cevrimSayisi, int denemeSayisi)
        {
            this.koloniBoyutu = koloniBoyutu;

           
            this.yemekKaynak = koloniBoyutu / 2;
            this.isciAri = koloniBoyutu / 2;
            this.gozcuAri = koloniBoyutu / 2; 

            this.altSinir = altSinir;
            this.ustSinir = ustSinir;
            this.cevrimSayisi = cevrimSayisi;
            this.denemeSayisi = denemeSayisi;

            besin = new BesinKaynakYoneticisi(yemekKaynak, altSinir, ustSinir);

            
            besin.besinOlustur();

            // bu döngü her bir iterasyonunu temsil eder. Her bir iterasyonda,
            //   algoritma işçi arıları ve gözcü arıları kullanarak besin kaynaklarını araştırır ve günceller.
            for (int i = 0; i < cevrimSayisi; i++)
            {
               
                dgr_isci_ari();
                olasilik_isci_ari();
                dgr_gozcu_ari();

                // etkisiz besinleri yeniden oluşturur
                for (int j = 0; j < yemekKaynak; j++)
                {
                    if (besin.Besinler[j].etkisiz > denemeSayisi)
                    {
                        besin.Besinler[j] = new BesinKaynak(altSinir, ustSinir);
                    }
                }

                
                en_iyi_besin();
            }

        }

        // İşçi arıların davranışını taklit eden metod
        void dgr_isci_ari()
        {
            for (int i = 0; i < yemekKaynak; i++)
            {
                // Rastgele bir diğer işçi arının belirlediği besin kaynağını seçer
                int k = (int)rastege(0, yemekKaynak);

                // Rastgele bir boyut ve yön seç
                int j = (int)rastege(0, 2);

                // Rastgele bir değişim miktarı seç
                double fi = rastege(-1, 1);


                // Seçilen boyuta göre yeni çözümü hesabi
                double x = 0;
                double xDiger = 0;

                
                if (j == 0)
                {
                    x = besin.Besinler[i].X;
                }
                else
                {
                    x = besin.Besinler[i].Y;
                }

                
                if (j == 0)
                {
                    xDiger = besin.Besinler[k].X;
                }
                else
                {
                    xDiger = besin.Besinler[k].Y;
                }

                double sonuc = 0;


                double yeniSonucX = x + fi;
                yeniSonucX = fitFonksiyonu(yeniSonucX);

                double yeniSonucY = x - xDiger;
                yeniSonucY = fitFonksiyonu(yeniSonucY);

                sonuc = fitFonksiyonu(amacFonksiyonu(yeniSonucX, yeniSonucY));


                // Elde edilen çözüm, belirlenen sınırlar arasıda mi
                if (sonuc > ustSinir)
                {
                    sonuc = ustSinir;
                }
                else if (sonuc < altSinir)
                {
                    sonuc = altSinir;
                }

                if (sonuc < besin.Besinler[i].fit)
                {
                    // Eğer geliştirilemediyse sayaç arttırılır
                    besin.Besinler[i].etkisiz += 1;
                }
                else
                {
                    // Eğer geliştirilirdi ise yerine yazılır 
                    besin.Besinler[k].X = yeniSonucX;
                    besin.Besinler[k].Y = yeniSonucY;
                    besin.Besinler[k].fx = amacFonksiyonu(yeniSonucX, yeniSonucY);
                    besin.Besinler[k].fit = sonuc;
                }
            }
        }

        // gözcü arıların davranışını taklit eden metod
        public void dgr_gozcu_ari()
        {
            Random rnd = new Random();
            double randomDeger = 0;
            lock (kilit_obj)
            {
                randomDeger = rnd.Next();
            }
            for (int i = 0; i < yemekKaynak; i++)
            {
                if (besin.Besinler[i].olasilikDegeri > randomDeger)
                {
                    gozcuAriHesapla(i);
                }
            }
        }

       // belirli bir besin kaynağının gözcü arılar tarafından incelenmesini ve gerekli durumlarda güncellenmesini sağlayan metodum
        public void gozcuAriHesapla(int i)
        {
            

            Random rnd = new Random();

            
            int k = (int)rastege(0, yemekKaynak);
            
            int j = (int)rastege(0, 2);
           
            double fi = (int)rastege(-1, 1);

            double x = 0;
            double xDiger = 0;

            if (j == 0)
            {
                x = besin.Besinler[i].X;
            }
            else
            {
                x = besin.Besinler[i].Y;
            }

            if (j == 0)
            {
                xDiger = besin.Besinler[k].X;
            }
            else
            {
                xDiger = besin.Besinler[k].Y;
            }

            double sonuc = 0;


            double yeniSonucX = x + fi;
            yeniSonucX = fitFonksiyonu(yeniSonucX);

            double yeniSonucY = x - xDiger;
            yeniSonucY = fitFonksiyonu(yeniSonucY);

            sonuc = fitFonksiyonu(amacFonksiyonu(yeniSonucX, yeniSonucY));

            if (sonuc > ustSinir)
            {
                sonuc = ustSinir;
            }
            else if (sonuc < altSinir)
            {
                sonuc = altSinir;
            }


            if (sonuc < besin.Besinler[i].fit)
            {
                
                besin.Besinler[i].etkisiz += 1;
            }
            else
            {
               
                besin.Besinler[k].X = yeniSonucX;
                besin.Besinler[k].Y = yeniSonucY;
                besin.Besinler[k].fx = amacFonksiyonu(yeniSonucX, yeniSonucY);
                besin.Besinler[k].fit = sonuc;
            }

        }

        public void olasilik_isci_ari()
        {
            besin.olasilik_hesabi_isci_ari();
        }

        public double amacFonksiyonu(double x, double y)
        {
            //  fonksiyon: (1 + (x + y + 1)^2 * (19 - 14x + 3x^2 - 14y + 6xy + 3y^2)) * (30 + (2x - 3y)^2 * (18 - 32x + 12x^2 + 48y - 36xy + 27y^2))
            double term1 = (x + y + 1) * (x + y + 1);
            double term2 = 19 - 14 * x + 3 * x * x - 14 * y + 6 * x * y + 3 * y * y;
            double term3 = (2 * x - 3 * y) * (2 * x - 3 * y);
            double term4 = 18 - 32 * x + 12 * x * x + 48 * y - 36 * x * y + 27 * y * y;

            return (1 + term1 * term2) * (30 + term3 * term4);
        }

        public double fitFonksiyonu(double fi)
        {
            if (fi >= 0)
            {
                return 1 / (1 + fi);
            }
            else
            {
                return 1 + Math.Abs(fi);
            }
        }


        public void en_iyi_besin()
        {
            
            BesinKaynak best = besin.bestBesin();
            bestX = best.X;
            bestY = best.Y;
            bestXlist.Add(bestX);
            bestYlist.Add(bestY);
            fxDegerleri.Add(best.fx);
            fit_degerleri.Add(best.fit);
        }

        public double rastege(double minimum, double maximum)
        {
            
            lock (kilit_obj)
            {
                return rnd.NextDouble() * (maximum - minimum) + minimum;
            }
        }
    }
}