using System;
using tugas1;

class Program
{
    static void Main(String[] args)
    {
        kalkulator calc = new kalkulator();
        bangunDatar bd = new bangunDatar();
        bangunRuang br = new bangunRuang();

        Console.WriteLine("MAIN MENU");
        Console.WriteLine("Pilih Aplikasi Yang Ingin Digunakan");
        Console.WriteLine("1.Kalkulator");
        Console.WriteLine("2.Bangun Datar");
        Console.WriteLine("3.Bangun Ruang");
        Console.WriteLine("Masukkan pilihan 1-3: ");
        string pilihan = Console.ReadLine();

        Console.WriteLine("\n---------------------------");

        switch (pilihan)
        {
            case "1":
                MenuKalkulator(calc);
                break;
            case "2":
                MenuBangunDatar(bd);
                break;
            case "3":
                MenuBangunRuang(br);
                break;
            default:
                Console.WriteLine("Pilihan tidak valid.");
                break;
        }
    }

    //Kalku
    static void MenuKalkulator(kalkulator calc)
    {
        Console.WriteLine("Kalkulator");
        Console.WriteLine("1.Tambah");
        Console.WriteLine("2.Kurang");
        Console.WriteLine("3.Kali");
        Console.WriteLine("4.Bagi");
        Console.WriteLine("Pilih Operasi (1-4)");
        string operasi = Console.ReadLine();

        Console.Write("Masukkan angka pertama: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Masukkan angka kedua: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double hasil = 0;
        try
        {
            switch (operasi)
            {
                case "1":
                    hasil = calc.Tambah(a, b);
                    break;
                case "2":
                    hasil = calc.Kurang(a, b);
                    break;
                case "3":
                    hasil = calc.Kali(a, b);
                    break;
                case "4":
                    hasil = calc.Bagi(a, b);
                    break;
                default:
                    Console.WriteLine("Operasi tidak valid.");
                    return;
            }
            Console.WriteLine($"Hasil: {hasil}");

        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");

        }

    }
    static void MenuBangunDatar(bangunDatar bd)
    {
        Console.WriteLine("[ MENU BANGUN DATAR ]");
        Console.WriteLine("1. Luas Persegi");
        Console.WriteLine("2. Luas Persegi Panjang");
        Console.WriteLine("3. Luas Lingkaran");
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

    static void MenuBangunRuang(bangunRuang br)
    {
        Console.WriteLine("[ MENU BANGUN RUANG ]");
        Console.WriteLine("1. Volume Kubus");
        Console.WriteLine("2. Volume Balok");
        Console.WriteLine("3. Volume Tabung");
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
}