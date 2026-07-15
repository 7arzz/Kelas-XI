Console.WriteLine("PERULANGAN : For, While, Foreach");

// FOR = perulangan jika jumlah perulangan diketahui

for (int i = 0; i <= 10; i++) // (variable, jumlah loop, perintah)
{
    Console.WriteLine("perulangan ke - " + i);
}

// WHILE = perulangan akan berjalan selama kondisi true

int nilai = 1;

while (nilai <= 5)
{
    Console.WriteLine("angka : " + nilai);
    nilai++;// agar nilai bisa bertambah maka gunakan increment         
}



// FOREACH

string[] namaOrang = { "Otong", "Surotong", "Ucup", "Surucup" };

foreach (string nama in namaOrang) // variable nama mengambil data dari data array namaOrang
{
    Console.WriteLine(nama);
}

