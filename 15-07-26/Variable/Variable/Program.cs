Console.WriteLine("variable, tipe data, dan operator sederhana");


int umur = 17; // <-- ini variable
string // <-- ini type data
    nama // <-- ini nama variable
    = "Otong"; // <-- ini isi variable

// ======================================
// TYPE DATA YANG SERING DIGUNAKAN DI C#
// ======================================

// Integer / angka bulat  (int)
int bulan = 1;

// double / float || angka decimal
double tinggi = 100.5;

// Char , satu karakter (tidak bisa lebih dari 1 karakter/huruf)
char nilai  = 'A';// perbedaan dengan string adalah pengunaan '  ' untuk char dan "  " untuk string

//String,  kumpulan angka, huruf, dll
string alamat = "Sidoarjo, Buduran, jalan no.12";

// Bool (boolean), yaitu variable yang terdiri dari True dan False
bool belajar = false;
bool belajarlagi = true;



// ===================
// OPERATOR SEDERHANA
// ===================

int a = 10;
int b = 50;

// penjumlahan
int hasil = a + b;
Console.WriteLine("hasil dari ", a, "+", b, "=", hasil);

// pengurangan
int hasilkurang = b - a;
Console.WriteLine("hasil dari ", b, "-", a, "=", hasilkurang);

// mengali
int hasilkali = a * b;
Console.WriteLine("hasil dari ", a, "x", b, "=", hasilkali);

// membagi
double c = 30;
double d = 10;
double hasilbagi = c / d;
Console.WriteLine("hasil dari ", b, "/", a, "=", hasilbagi);