using System;

namespace ABC_Semiha
{
    class BesinKaynak
    {
        public static readonly Random rnd = new Random();
        public static readonly Object kilit_obj = new Object();
        public int etkisiz = 0;


        public double fit;
        public BesinKaynak(int altSinir, int ustSinir)
        {
            X = SayiGetir(altSinir, ustSinir);
            Y = SayiGetir(altSinir, ustSinir);
            fx = fonksiyonum(X, Y);
            fit = fit_fonk(fx);
        }

        public double X;
        public double Y;
        public double fx;
        public double fonksiyonum(double x, double y)
        {
            //  fonksiyon: (1 + (x + y + 1)^2 * (19 - 14x + 3x^2 - 14y + 6xy + 3y^2)) * (30 + (2x - 3y)^2 * (18 - 32x + 12x^2 + 48y - 36xy + 27y^2))
            double term1 = (x + y + 1) * (x + y + 1);
            double term2 = 19 - 14 * x + 3 * x * x - 14 * y + 6 * x * y + 3 * y * y;
            double term3 = (2 * x - 3 * y) * (2 * x - 3 * y);
            double term4 = 18 - 32 * x + 12 * x * x + 48 * y - 36 * x * y + 27 * y * y;

            return (1 + term1 * term2) * (30 + term3 * term4);
        }


        public static void olasiklikDegerleriVer(BesinKaynak[] besinler)
        {

            for (int i = 0; i < besinler.Length; i++)
            {
                double payda = 0;
                for (int j = 0; j < besinler.Length; j++)
                {
                    payda += besinler[i].fit;
                }
                besinler[i].olasilikDegeri = besinler[i].fit / payda;
            }
        }
        public double SayiGetir(double minimum, double maximum)
        {

            lock (kilit_obj)
            {
                return rnd.NextDouble() * (maximum - minimum) + minimum;
            }
        }

        public double fit_fonk(double fx)
        {
            if (fx >= 0)
            {
                return 1 / (1 + fx);
            }
            else
            {
                return 1 + Math.Abs(fx);
            }
        }
        public double olasilikDegeri;
       

      
    }
}
