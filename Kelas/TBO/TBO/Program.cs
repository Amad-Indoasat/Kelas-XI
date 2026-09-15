using System;
namespace Matematika
{
    class Home
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Belajar PBO");

            Kalkulator kal = new Kalkulator();
            //BangunDatar Bd = new BangunDatar();
            BangunRuang Br = new BangunRuang();

            kal.penjumlahan();
            BangunDatar.LuasLingkaran();
            Br.volumeTabung();
        }
    }
    class Kalkulator
    {
        public void penjumlahan()
        {
            Console.WriteLine("penjumlahan");
        }
        public void pengurangan()
        {
            Console.WriteLine("pengurangan");
        }
        public void perkalian()
        {
            Console.WriteLine("perkalian");
        }
        public void pembagian()
        {
            Console.WriteLine("pembagian");
        }
    }

    class BangunDatar
    {
        public static void kelilingPersegiPanjang()
        {
            Console.WriteLine("Keliling Persegi Panjang");
        }
        public static void kelingLingkaran()
        {
            Console.WriteLine("keliling Lingkaran");
        }
        public static void LuasPersegiPanjang()
        {
            Console.WriteLine("Luar Persegi Panjang");
        }
        public static void LuasLingkaran()
        {
            Console.WriteLine("Luas Lingkaran");
        }
    }

    class BangunRuang
    {
        public void volumeBalok()
        {
            Console.WriteLine("volume Balok");
        }
        public void volumeTabung()
        {
            Console.WriteLine("volume Tabung");
        }
      public void volumePiramid()
        {
            Console.WriteLine("volume piramid");
        }
    }


}
