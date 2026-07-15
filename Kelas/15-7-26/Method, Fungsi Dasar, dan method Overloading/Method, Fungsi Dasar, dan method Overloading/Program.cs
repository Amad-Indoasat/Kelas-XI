// Method / Fungsi Sederhana

// Method
static void Salam()
{
    Console.WriteLine("Hello World");
}
// Cara memanggil
Salam();

// Method dengan parameter

static void Sapa(String nama) 
{ 
    Console.WriteLine("Hai " + nama);
}

//Cara memanggil 
Sapa("Ahmad");

// Method dgn Return Value
static int Tambah(int a, int b) // Method akan menghasilkan nilai bertipe int
{
    return a + b;
}

//Cara memanggil
Console.WriteLine(Tambah(5, 7));