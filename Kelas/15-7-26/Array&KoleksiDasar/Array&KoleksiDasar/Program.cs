// Array & Koleksi Dasar | Array,List

//Array

string[] namaBuah = {"Apel","Jeruk","Mangga","Pisang"};

// tanda [] di menunjukkan variabel adalah array

// Ambil data Array
Console.WriteLine(namaBuah[0]); // hasilnya adalah apel, karena array dimulai dari 0

// Array juga serimg digunakan dgn foreach
foreach (string buah in namaBuah)
{
    Console.WriteLine(buah);
}

//Koleksi Dasar:List

 List<string> namaSiswa = new List<string>();

//Tambah data ke List
namaSiswa.Add("Dayat");
namaSiswa.Add("Ahmad");

//tampilkan hasil
foreach (String siswa in namaSiswa) 
{
    Console.WriteLine(siswa);
}