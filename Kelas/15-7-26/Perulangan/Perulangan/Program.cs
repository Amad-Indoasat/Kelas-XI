// Perulngn For, While, Dn Foreach

// For

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Perulangan ke - " + i);
}

// While loop

int angka = 1;

while (angka <= 5)
{
    Console.WriteLine("Angka: " + angka);
    angka++;
}

// Foreach loop

string[] namabuah = { "Apel", "Pisang", "Jeruk", "Mangga" };

foreach (string buah in namabuah)
{
    Console.WriteLine("Nama Buah: " + buah);
}