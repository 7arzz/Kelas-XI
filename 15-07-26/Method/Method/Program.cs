Console.WriteLine("METHOD / FUNGSI SEDERHANA");

/*
 
 Method adalah wada untuk sekumpulan kode untuk menjalankan 
fungsi tertentu
Method membuat project kita menjadi lebih rapi, terstruktur, dan dapat di gunaan kembali tanpa menulis kodenya kembali
 
 */



// VOID METHOD : method yang tidak mengembalikan value, dia hanya melakukan tugasnya tanpa men
static void halo() // method ini bernama halo
{
    Console.WriteLine("HELLO WORLD"); //method ini bertugas untuk menampilkan "HELLO WORLD"
}


// memanggil method tanpa return dan parameter
halo();




// METHOD + PARAMETER 
static void sapa(string nama)
{
    Console.WriteLine("hai " + nama + " selamat datang");
}

// panggil method dengan menyertakan nama (parameter)
sapa("amerta");




// METHOD + RETURN + PARAMETER
static int tambah(int a, int b)
{
    return a + b; // digunakan untuk mengembalikan value / nilai, jika tanpa return maka kode error karena kita tidak menggunakan void

}

// memanggil method dengan return value
Console.WriteLine(tambah(10, 30));    