using System;

namespace Odevler
{
    class Program
    {
        static void Main(string[] args)
        {
            TekCift();
            Karsilastirma();
            Cevirici();
            Sorgulama();
        }
        static void TekCift()
        {
            int sayi;

            Console.Write("Bir sayi giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi % 2 == 0)
            {
                Console.WriteLine("girdiginiz sayi cift");
            }
            else
            {
                Console.WriteLine("girdiginiz sayi tek");
            }
        }
        static void Cevirici()
        {
            int sayi;

            Console.Write("100 luk sisteme gore notunuzu giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi == 100)
            {
                Console.WriteLine("Notunuz 5");
            }
            else if (sayi < 100 && sayi >= 80)
            {
                Console.WriteLine("Notunuz 4");
            }
            else if (sayi < 80 && sayi >= 60)
            {
                Console.WriteLine("Notunuz 3");
            }
            else if (sayi < 60 && sayi >= 45)
            {
                Console.WriteLine("Notunuz 2");
            }
            else
            {
                Console.WriteLine("Notunuz 1");
            }

        }
        static void Karsilastirma()
        {
            int n;
            int enBuyuk = 0;
            Console.Write("Kac tane sayi girmek istiyorsunuz:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Bir sayi giriniz:");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
                if (sayilar[i] > enBuyuk)
                {
                    enBuyuk = sayilar[i];
                }
            }
            Console.WriteLine("Girdiginiz sayilardan en buyuk olan sayi=" + enBuyuk);

        }
        static void Sorgulama()
        {
            char c, n;
            int y;

            Console.Write("Yasinizi Giriniz:");
            y = Convert.ToInt32(Console.ReadLine());
        CHECKPOİNT1:
            Console.Write("Cinsiyetinizi giriniz(E/K):");
            c = Convert.ToChar(Console.ReadLine());



            if (c == 'E' || c == 'e' && y >= 20)
            {
            CHECKPOİNT:
                Console.Write("Askerliginizi yaptınız mı?(E/H)");
                n = Convert.ToChar(Console.ReadLine());
                if (n == 'E' || n == 'e')
                {
                    Console.WriteLine("Askerligini yapmis");
                }
                else if (n == 'H' || n == 'h')
                {
                    Console.WriteLine("Askerligini yapmamis");
                }
                else
                {
                    Console.WriteLine("Lutfen tekrar giriniz!");
                    goto CHECKPOİNT;
                }
            }
            else if (c == 'K' || c == 'k')
            {
                Console.WriteLine("Kadın");
            }
            else
            {
                Console.WriteLine("Lutfen tekrar giriniz!");
                goto CHECKPOİNT1;
            }

        }
    }
}
