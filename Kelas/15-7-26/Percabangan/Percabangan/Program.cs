// Percabangan

int umur = 16;

if (umur >= 17)
{
    Console.WriteLine("Anda sudah WNI seumur hidup.");
}
else
{
    Console.WriteLine("Anda masih di bawah umur.");
}

//Else if

int nilai = 67;

if (nilai >= 90)
{
    Console.WriteLine("Nilai Anda A");
}
else if (nilai >= 75)
{
    Console.WriteLine("Nilai Anda B");
}
else if (nilai >= 60)
{
    Console.WriteLine("Nilai Anda C");
}
else
{
    Console.WriteLine("Nilai Anda D");
}

// Switch

string hari = "Rabu";

switch (hari)
{
    case "Senin":
        Console.WriteLine("Hari Pertama.");
        break;
    case "Minggu":
        Console.WriteLine("Hari Ketujuh.");
        break;
    default:
        Console.WriteLine("Hari Lainnya.");
        break;
}