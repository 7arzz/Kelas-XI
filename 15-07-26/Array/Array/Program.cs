Console.WriteLine("ARRAY DAN LIST DASAR");

// ARRAY adalah tempat menyimpan banyak data dalam 1 tempat dan biasanya memiliki tipe data yang sama

string[] namaOrang = { "ucup", "surucup", "otong", "surotong" }; // tanda [] menunjukkan bahwa ini array

// ambil data dari array
// index array dimulai dari 0
// ucup = 0, surucup = 1, dan selanjutnya
Console.WriteLine(namaOrang[0]);

// gunakan foreach agar lebih efisien untuk menampilkan data
foreach (string nama in namaOrang) // variable nama mengambil data dari variable yang bernama namaOrang
{
    Console.WriteLine(nama);
}






// LIST adalah koleksi data yang lebih fleksible dari array
List<string> namaBuah = new List<string>();

namaBuah.Add("pisang"); // .Add digunakan untuk menambahkan data pada list
namaBuah.Add("mangga");
namaBuah.Add("manggis");

/*
 
 Bedanya dengan array adalah ukuran dari list yang lebih fleksibel daripada array yang memiliki ukuran tetap 
dan lebih cocok untuk data yang berubah-ubah atau dinamis
 
 */

// untuk memanggil kita akan gunakan foreach

foreach (string buah in namaBuah)
{
    Console.WriteLine(buah);
}