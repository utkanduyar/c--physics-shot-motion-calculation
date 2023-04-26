using System;

namespace proje_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float UcusSuresi;
            float Menzil;
            float hMax;
            float g = 9.81f;
            double Vxo;
            double Vyo;
            float FirlatmaHizi = 0, FirlatmaAcisi = 0;

            Console.Write("Fırlatma Hızı Giriniz :");
            FirlatmaHizi = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Fırlatma Hızı : {0} m/sn", FirlatmaHizi);

            Console.Write("Fırlatma Açısını Giriniz :");
            FirlatmaAcisi = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Fırlatma Açısı : {0} derece", FirlatmaAcisi);

            Vxo = FirlatmaHizi * Math.Cos(FirlatmaAcisi * Math.PI / 180);
            Vyo = FirlatmaHizi * Math.Sin(FirlatmaAcisi * Math.PI / 180);

            UcusSuresi = Convert.ToSingle(2 * Vyo / g);
            Menzil = Convert.ToSingle(Vxo * UcusSuresi);
            hMax = Convert.ToSingle((Vyo * Vyo) / (2 * g));

            Console.WriteLine("Uçuş Süresi : {0} saniye", UcusSuresi);
            Console.WriteLine("Maksimum Yüksekliği : {0} metre", hMax);
            Console.WriteLine("Menzili : {0} metre", Menzil);

            /* Matrisi uygulayan Kodlarım */
            object[,] grafik = new object[10, 10];
            for (int a = 0; a < 10; a++)
            {
                grafik[a, 0] = "|";
            }
            for (int b = 1; b < 10; b++)
            {
                grafik[9, b] = "_";
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    grafik[i, j] = "-";
                }
            }

            /* Yükseklik ayarlama Kısmı */
            double Number1 = hMax;
            double Number2 = Number1;
            double hesap1 = Number2 / 5;
            double hesap2 = hesap1;
            double sayac = hesap2 * 6;
            double sayac3 = hesap2 * 6;
            double[] siralama = new double[5];
            double gecicisiralama;
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 != 0)
                {
                    grafik[i, 0] = Math.Round(sayac, 2);
                    sayac = sayac - hesap2;
                }
            }

            /* Yıldızları sıralama kodu */
            for (int i = 0; i < 5; i++)
            {
                siralama[i] = sayac3;
                sayac3 = sayac3 - hesap2;
            }

            for (int i = 0; i < 5; i++)
            {
                for (int t = 0; t < 5; t++)
                {
                    if (siralama[t] > siralama[i])
                    {

                        gecicisiralama = siralama[i];

                        siralama[i] = siralama[t];

                        siralama[t] = gecicisiralama;

                    }
                }
            }

            if (siralama[3] > hMax && siralama[2] <= hMax)
            {
                grafik[4, 5] = "*"; /* Tepe noktasına yıldız ekleyen koordinat */


                grafik[8, 1] = "*";
                grafik[7, 1] = "*";
                grafik[5, 3] = "*";


                grafik[8, 9] = "*";
                grafik[7, 7] = "*";
                grafik[5, 6] = "*";
            }
            else if (siralama[4] > hMax && siralama[3] <= hMax)
            {
                grafik[2, 5] = "*"; /* Tepe noktasına yıldız ekleyen koordinat */


                grafik[3, 2] = "*";
                grafik[3, 6] = "*";

                grafik[5, 1] = "*";
                grafik[5, 7] = "*";

                grafik[8, 1] = "*";
                grafik[8, 9] = "*";

            }
            else if (siralama[2] > hMax && siralama[1] <= hMax)
            {
                grafik[6, 5] = "*"; /* Tepe noktasına yıldız ekleyen koordinat */


                grafik[8, 1] = "*";
                grafik[7, 3] = "*";


                grafik[7, 7] = "*";
                grafik[8, 8] = "*";

            }
            else if (siralama[1] > hMax && siralama[0] <= hMax)
            {
                grafik[8, 5] = "*"; /* Tepe noktasına yıldız ekleyen koordinat */
            }
            else if (hMax < 0)
            {
                Console.WriteLine("maksimum yükseklik sıfırın altında");
            }
            /* YÖNERGEYİ EKRANA YAZDIRMA KODU */
            for (int z = 0; z < 10; z++)
            {
                for (int x = 0; x < 10; x++)

                    Console.Write(" {0} ", grafik[z, x]);

                Console.WriteLine();
            }

            /* Menzil Ayarlama Kısmı*/
            double Menzil1 = Menzil;
            double Menzil2 = Math.Round(Menzil1, 1);
            double hesap3 = Menzil2 / 2;
            double hesap4 = Math.Round(hesap3, 1);
            int sayac2 = Convert.ToInt32(hesap4);
            int[] sayilar = new int[3];
            for (int i = 0; i < 3; i++)
            {
                sayac2 = sayac2 - Convert.ToInt32(hesap2);
                sayilar[i] = sayac2;
            }
            Console.Write("              {0}       {1}", hesap3, Menzil2); /* burdaki boşluklar bilerek konulmuşutur bu şekilde çalışması gerekiyor*/
            Console.WriteLine();
        }
    }
}
