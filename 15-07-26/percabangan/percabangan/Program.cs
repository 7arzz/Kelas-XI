using System.Diagnostics;

Console.WriteLine("percabangan if, else, else if, dan switch");


// IF & ELSE

int umur = 18;
if (umur <= 18) // untuk cek apakah kondisi true atau false
{
    Console.WriteLine("masih kecil");
}
else // jika hasil false maka akan lanjut menjalankan kode yang ada di dalam else
{
    Console.WriteLine("sudah dewasa");
}


// IF, ELSE, ELSE IF (bisa untuk banyak pengecekan)
int nilai = 100;

if (nilai == 100)
{
    Console.WriteLine("nilai sempurna : ", nilai);
} else if  (nilai >= 80)
{
    Console.WriteLine("nilai bagus : ", nilai);
} else
{
    Console.WriteLine("nilai kamu : ", nilai, "perbaiki lagi");
}


// SWITCH 

string role = "Admin";


switch (role) 
{
    case "Admin":
        Console.WriteLine("Hai, Admin");
        break;

    case "Kasir":
        Console.WriteLine("Hai, Kasir");
        break;

    default:
        Console.WriteLine("Pilih role dengan benar");
        break;
}
