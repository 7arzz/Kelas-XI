using System;

namespace Matematika 
{ 

    class Home
    {
        static void Main(String[] args)
        {
            Console.WriteLine("==== BELAJAR PBO ====");
            

            Kalkulator k = new Kalkulator();
            //BangunDatar bd = new BangunDatar();
            BangunRuang br = new BangunRuang();


            k.Penjumlahan();
            BangunDatar.LLingkaran();
            br.VTabung();


            
        }
    }

    class Kalkulator
    {
        public void Penjumlahan()
        {
            Console.WriteLine("==== Penjumlahan ====");
        }
        public void Pengurangan()
        {
            Console.WriteLine("==== Pengurangan ====");
        }
        public void Perkalian()
        {
            Console.WriteLine("==== Perkalian =====");
        }
        public void Pembagian()
        {
            Console.WriteLine("==== Pembagian ====");
        }
    }

    class BangunDatar 
    {
        public static void KPersegiPanjang()
        {
            Console.WriteLine("=== Keliling Persegi Panjang ===");
        }

        public static void KLingkaran()
        {
            Console.WriteLine("=== Keliling Lingkaran ===");
        }

        public static void LPersegiPanjang()
        {
            Console.WriteLine("=== Luas Persegi Panjang ===");
        }

        public static void LLingkaran()
        {
            Console.WriteLine("=== Luas Lingkaran ===");
        }
    }

    class BangunRuang 
    {
        public void VBalok()
        {
            Console.WriteLine("=== Volume Balok ===");
        }

        public void VTabung()
        {
            Console.WriteLine("=== Volume Tabung ===");
        }

        public void VPiramid()
        {
            Console.WriteLine("=== Volume Piramid ===");
        }
    }
}
