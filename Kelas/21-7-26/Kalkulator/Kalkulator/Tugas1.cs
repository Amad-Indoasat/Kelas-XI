namespace tugas1
{
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
}