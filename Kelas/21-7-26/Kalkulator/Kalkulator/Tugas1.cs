using System;

namespace tugas1
{
    public class MenuApp
    {
        private kalkulator calc = new kalkulator();
        private bangunDatar bd = new bangunDatar();
        private bangunRuang br = new bangunRuang();
        private zodiak zodiak = new zodiak();
        public void TampilkanMenuUtama()
        {
            bool loop = true;

            while (loop)
            {
                Console.WriteLine("\n=== APLIKASI TUGAS ===");
                Console.WriteLine("Pilih Menu Utama:");
                Console.WriteLine("1. Kalkulator");
                Console.WriteLine("2. Bangun Datar");
                Console.WriteLine("3. Bangun Ruang");
                Console.WriteLine("4. Ramalan Zodiak");
                Console.WriteLine("5. Keluar");
                Console.Write("Masukkan pilihan (1-5): ");

                string pilihanUtama = Console.ReadLine();
                Console.WriteLine("\n------------------------");

                switch (pilihanUtama)
                {
                    case "1":
                        MenuKalkulator();
                        break;
                    case "2":
                        MenuBangunDatar();
                        break;
                    case "3":
                        MenuBangunRuang();
                        break;
                    case "4":
                        MenuZodiak();
                        break;
                    case "5":
                        Console.WriteLine("Terima kasih telah menggunakan aplikasi ini!");
                        loop = false; 
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid!");
                        break;
                }

                if (loop)
                {
                    Console.WriteLine("\nTekan Enter untuk kembali ke menu utama...");
                    Console.ReadLine();
                }
            }
        }

        private void MenuKalkulator()
        {
            Console.WriteLine("[ MENU KALKULATOR ]");
            Console.WriteLine("1. Tambah\n2. Kurang\n3. Kali\n4. Bagi");
            Console.Write("Pilih operasi (1-4): ");
            string operasi = Console.ReadLine();

            Console.Write("Masukkan angka pertama: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan angka kedua: ");
            double b = Convert.ToDouble(Console.ReadLine());

            try
            {
                double hasil = operasi switch
                {
                    "1" => calc.Tambah(a, b),
                    "2" => calc.Kurang(a, b),
                    "3" => calc.Kali(a, b),
                    "4" => calc.Bagi(a, b),
                    _ => throw new Exception("Pilihan operasi tidak valid!")
                };
                Console.WriteLine($"\nHasil : {hasil}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError: {ex.Message}");
            }
        }

        private void MenuBangunDatar()
        {
            Console.WriteLine("[ MENU BANGUN DATAR ]");
            Console.WriteLine("1. Luas Persegi\n2. Luas Persegi Panjang\n3. Luas Lingkaran");
            Console.Write("Pilih bentuk (1-3): ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Console.Write("Masukkan panjang sisi: ");
                    double s = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Hasil Luas Persegi : {bd.LuasPersegi(s)}");
                    break;
                case "2":
                    Console.Write("Masukkan panjang: ");
                    double p = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan lebar: ");
                    double l = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Hasil Luas Persegi Panjang : {bd.LuasPersegiPanjang(p, l)}");
                    break;
                case "3":
                    Console.Write("Masukkan jari-jari: ");
                    double r = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Hasil Luas Lingkaran : {bd.LuasLingkaran(r):F2}");
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid!");
                    break;
            }
        }

        private void MenuBangunRuang()
        {
            Console.WriteLine("[ MENU BANGUN RUANG ]");
            Console.WriteLine("1. Volume Kubus\n2. Volume Balok\n3. Volume Tabung");
            Console.Write("Pilih bentuk (1-3): ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Console.Write("Masukkan panjang sisi: ");
                    double s = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Hasil Volume Kubus : {br.VolumeKubus(s)}");
                    break;
                case "2":
                    Console.Write("Masukkan panjang: ");
                    double p = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan lebar: ");
                    double l = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan tinggi: ");
                    double t = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Hasil Volume Balok : {br.VolumeBalok(p, l, t)}");
                    break;
                case "3":
                    Console.Write("Masukkan jari-jari: ");
                    double r = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan tinggi: ");
                    double tt = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Hasil Volume Tabung : {br.VolumeTabung(r, tt):F2}");
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid!");
                    break;
            }
        }

        private void MenuZodiak()
        {
            Console.WriteLine("[ MENU RAMALAN ZODIAK ]");
            Console.Write("Masukkan Tanggal Lahir (1-31): ");
            int tanggal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Bulan Lahir (1-12): ");
            int bulan = Convert.ToInt32(Console.ReadLine());

            var hasil = zodiak.CekZodiak(tanggal, bulan);

            Console.WriteLine("\n==============================");
            Console.WriteLine($"Zodiak Kamu : {hasil.NamaZodiak}");
            Console.WriteLine($"Ramalan     : {hasil.Ramalan}");
            Console.WriteLine("==============================");
        }
    }
    public class kalkulator
    {
        public double Tambah(double a, double b) => a + b;
        public double Kurang(double a, double b) => a - b;
        public double Kali(double a, double b) => a * b;
        public double Bagi(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Pembagian dengan nol tidak diperbolehkan!");
            }
            return a / b;
        }
    }

    public class bangunDatar
    {
        public double LuasPersegi(double sisi) => sisi * sisi;
        public double KelilingPersegi(double sisi) => 4 * sisi;
        public double LuasPersegiPanjang(double p, double l) => p * l;
        public double KelilingPersegiPanjang(double p, double l) => 2 * (p + l);
        public double LuasLingkaran(double r) => Math.PI * r * r;
    }

    public class bangunRuang
    {
        public double VolumeKubus(double sisi) => Math.Pow(sisi, 3);
        public double VolumeBalok(double p, double l, double t) => p * l * t;
        public double VolumeTabung(double r, double t) => Math.PI * Math.Pow(r, 2) * t;
    }

    public class zodiak
    {
        public (string NamaZodiak, string Ramalan) CekZodiak(int tanggal, int bulan)
        {
            if ((bulan == 3 && tanggal >= 21) || (bulan == 4 && tanggal <= 19))
                return ("Aries", "Hari ini energi kamu meluap-luap! Waktunya menyelesaikan tugas yang tertunda.");
            if ((bulan == 4 && tanggal >= 20) || (bulan == 5 && tanggal <= 20))
                return ("Taurus", "Sabar adalah kunci. Keuangan kamu minggu ini akan stabil.");
            if ((bulan == 5 && tanggal >= 21) || (bulan == 6 && tanggal <= 20))
                return ("Gemini", "Komunikasi kamu sedang sangat bagus, cocok untuk berdiskusi dengan teman.");
            if ((bulan == 6 && tanggal >= 21) || (bulan == 7 && tanggal <= 22))
                return ("Cancer", "Fokus pada kesehatan fisik dan mentalmu hari ini. Istirahat yang cukup!");
            if ((bulan == 7 && tanggal >= 23) || (bulan == 8 && tanggal <= 22))
                return ("Leo", "Aura kepemimpinanmu sedang bersinar. Jadilah teladan bagi teman-temanmu.");
            if ((bulan == 8 && tanggal >= 23) || (bulan == 9 && tanggal <= 22))
                return ("Virgo", "Ketelitianmu membuat pekerjaan selesai sempurna hari ini.");
            if ((bulan == 9 && tanggal >= 23) || (bulan == 10 && tanggal <= 22))
                return ("Libra", "Cari keseimbangan antara bermain dan belajar agar tidak kaget di akhir minggu.");
            if ((bulan == 10 && tanggal >= 23) || (bulan == 11 && tanggal <= 21))
                return ("Scorpio", "Intuisi kamu sangat tajam hari ini, percayalah pada kata hatimu.");
            if ((bulan == 11 && tanggal >= 22) || (bulan == 12 && tanggal <= 21))
                return ("Sagitarius", "Petualangan baru sedang menunggumu! Tetap terbuka pada hal-hal baru.");
            if ((bulan == 12 && tanggal >= 22) || (bulan == 1 && tanggal <= 19))
                return ("Capricorn", "Kerja kerasmu mulai memperlihatkan hasil. Pertahankan!");
            if ((bulan == 1 && tanggal >= 20) || (bulan == 2 && tanggal <= 18))
                return ("Aquarius", "Ide-ide kreatifmu luar biasa, jangan ragu untuk membagikannya!");
            if ((bulan == 2 && tanggal >= 19) || (bulan == 3 && tanggal <= 20))
                return ("Pisces", "Kebaikan hatimu akan membawa keberuntungan besar hari ini.");

            return ("Tidak Valid", "Tanggal atau bulan yang dimasukkan tidak cocok!");
        }
    }
}