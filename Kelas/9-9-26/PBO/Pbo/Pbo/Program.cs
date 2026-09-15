using System;
namespace Matematika
{
    class Home
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BELAJAR PBO");

            Kalkulator Kal = new Kalkulator();
            //BangunDatar BDatar = new BangunDatar();
            BangunRuang BRuang = new BangunRuang();

            Kal.Pertambahan();
            BangunDatar.Lingkaran();
            BRuang.Kubus();
        }

    }

    class Kalkulator
    {
        public void Pertambahan()
        {
            Console.WriteLine("PERTAMBAHAN");
        }
        public void Pengurangan()
        {
            Console.WriteLine("PENGURANGAN");
        }
        public void Perkalian()
        {
            Console.WriteLine("PERKALIAN");
        }
        public void Pembagian()
        {
            Console.WriteLine("PEMBAGIAN");
        }
    }

    class BangunDatar
    {
        public static void Kotak()
        {
            Console.WriteLine("KOTAK");
        }
        public static void Segitiga()
        {
            Console.WriteLine("SEGITIGA");
        }
        public static void Lingkaran()
        {
            Console.WriteLine("LINGKARAN");
        }
        public static void Trapesium()
        {
            Console.WriteLine("TRAPESIUM");
        }
    }
    
    class BangunRuang
    {
        public void Kubus()
        {
            Console.WriteLine("KUBUS");
        }
        public void Piramida() 
        {
            Console.WriteLine("PIRAMIDA");
        }
        public void Tabung()
        {
            Console.WriteLine("TABUNG");
        }
    }
}