using System;

namespace Jadwal
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Jadwal Harian (Pilih Jadwal Sesuai Angka) :");
                Console.WriteLine("1. Senin");
                Console.WriteLine("2. Selasa");
                Console.WriteLine("3. Rabu");
                Console.WriteLine("4. Kamis");
                Console.WriteLine("5. Jumat");
                Console.WriteLine("0. Keluar");
                Console.Write("Pilih Hari : ");

                string pilihan = Console.ReadLine();
                Console.Clear();

                switch (pilihan)
                {
                    case "1":
                        Senin senin = new Senin();
                        senin.Sesi1();
                        senin.Sesi2();
                        senin.Sesi3();
                        TampilkanTombolBack();
                        break;
                    case "2":
                        Selasa selasa = new Selasa();
                        selasa.Sesi1();
                        selasa.Sesi2();
                        selasa.Sesi3();
                        TampilkanTombolBack();
                        break;
                    case "3":
                        Rabu rabu = new Rabu();
                        rabu.Sesi1();
                        rabu.Sesi2();
                        rabu.Sesi3();
                        TampilkanTombolBack();
                        break;
                    case "4":
                        Kamis.Sesi1();
                        Kamis.Sesi2();
                        Kamis.Sesi3();
                        TampilkanTombolBack();
                        break;
                    case "5":
                        Jumat.Sesi1();
                        Jumat.Sesi2();
                        TampilkanTombolBack();
                        break;
                    case "0":
                        running = false;
                        Console.WriteLine("Terima kasih! Program selesai.");
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid!");
                        TampilkanTombolBack();
                        break;
                }
            }
        }

        static void TampilkanTombolBack()
        {
            Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
            Console.ReadLine();
        }
    }

    public class Senin
    {
        public void Sesi1()
        {
            Console.WriteLine("Sesi 1 :");
            Console.WriteLine("Bahasa Jepang (07.00 - 08.10)");
            Console.WriteLine("Bahasa Inggris (08.10 - 09.20)");
            Console.WriteLine("Matematika (09.20 - 09.55)");
            Console.WriteLine("Istirahat1 (09.55 - 10.30)");
        }
        public void Sesi2()
        {
            Console.WriteLine("Sesi 2 :");
            Console.WriteLine("Matematika (10.30 - 11.40)");
            Console.WriteLine("Istirahat2 (11.40 - 12.30)");
        }
        public void Sesi3()
        {
            Console.WriteLine("Sesi 3 :");
            Console.WriteLine("PPLG (12.30 - 14.30)");
        }
    }

    public class Selasa
    {
        public void Sesi1()
        {
            Console.WriteLine("Sesi 1 :");
            Console.WriteLine("PKWU / KIK (07.00 - 08.10)");
            Console.WriteLine("PJOK (08.10 - 09.20)");
            Console.WriteLine("Istirahat1 (09.20 - 09.35)");
        }
        public void Sesi2()
        {
            Console.WriteLine("Sesi 2 :");
            Console.WriteLine("Bahasa Indonesia (09.35 - 11.05)");
            Console.WriteLine("PPLG (11.05 - 11.35)");
            Console.WriteLine("Istirahat2 (11.35 - 12.30)");
        }
        public void Sesi3()
        {
            Console.WriteLine("Sesi 3 :");
            Console.WriteLine("PPLG (12.30 - 14.30)");
        }
    }

    public class Rabu
    {
        public void Sesi1()
        {
            Console.WriteLine("Sesi 1 :");
            Console.WriteLine("PPLG (07.00 - 09.20)");
            Console.WriteLine("Istirahat1 (09.20 - 09.35)");
        }
        public void Sesi2()
        {
            Console.WriteLine("Sesi 2 :");
            Console.WriteLine("PPLG (09.35 - 11.35)");
            Console.WriteLine("Istirahat2 (11.35 - 12.30)");
        }
        public void Sesi3()
        {
            Console.WriteLine("Sesi 3 :");
            Console.WriteLine("PPLG (12.30 - 13.20)");
            Console.WriteLine("BK (13.30 - 14.00)");
        }
    }

    public class Kamis
    {
        public static void Sesi1()
        {
            Console.WriteLine("Sesi 1 :");
            Console.WriteLine("Bahasa Jerman (07.00 - 08.10)");
            Console.WriteLine("Bahasa Jawa (08.10 - 09.20)");
            Console.WriteLine("Istirahat1 (09.20 - 09.35)");
        }
        public static void Sesi2()
        {
            Console.WriteLine("Sesi 2 :");
            Console.WriteLine("PKWU / KIK (09.35 - 11.35)");
            Console.WriteLine("Istirahat2 (11.35 - 12.30)");
        }
        public static void Sesi3()
        {
            Console.WriteLine("Sesi 3 :");
            Console.WriteLine("PAI (12.30 - 13.30)");
        }
    }

    public class Jumat
    {
        public static void Sesi1()
        {
            Console.WriteLine("Sesi 1 :");
            Console.WriteLine("Bahasa Inggris (06.30 - 08.30)");
            Console.WriteLine("Sejarah (08.30 - 09.30)");
            Console.WriteLine("Istirahat1 (09.30 - 09.45)");
        }
        public static void Sesi2()
        {
            Console.WriteLine("Sesi 2 :");
            Console.WriteLine("Pancasila (09.45 - 11.15)");
        }
    }
}