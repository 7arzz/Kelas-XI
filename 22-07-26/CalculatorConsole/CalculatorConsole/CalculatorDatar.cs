using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorConsole
{
    internal class CalculatorDatar
    {
        public void Menu()
        {
            Console.WriteLine("=== CALCULATUR BANGUN DATAR ===");

            Console.WriteLine("1. Persegi");
            Console.WriteLine("2. Persegi Panjang ");
            Console.WriteLine("3. Lingkaran");

            Console.WriteLine("Pilih Bangun Datar : ");
            int pilih = Convert.ToInt32(Console.ReadLine());

            switch (pilih)
            {
                case 1:
                    Persegi();
                    break;

                case 2:
                    PersegiPanjang();
                    break;

                case 3:
                    Lingkaran();
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    break;
            }
        }

        void Persegi()
        {
            Console.Clear();
            Console.WriteLine("=== PERSEGI ===");
            Console.WriteLine("1. Luas");
            Console.WriteLine("2. Keliling");
            Console.Write("Pilih : ");

            int pilih = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan sisi : ");
            double sisi = Convert.ToDouble(Console.ReadLine());

            switch (pilih)
            {
                case 1:
                    Console.WriteLine("Luas = " + (sisi * sisi));
                    break;

                case 2:
                    Console.WriteLine("Keliling = " + (4 * sisi));
                    break;

                default:
                    Console.WriteLine("Pilihan salah.");
                    break;
            }
        }

        void PersegiPanjang()
        {
            Console.Clear();
            Console.WriteLine("=== PERSEGI PANJANG ===");
            Console.WriteLine("1. Luas");
            Console.WriteLine("2. Keliling");
            Console.Write("Pilih : ");

            int pilih = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan panjang : ");
            double panjang = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan lebar : ");
            double lebar = Convert.ToDouble(Console.ReadLine());

            switch (pilih)
            {
                case 1:
                    Console.WriteLine("Luas = " + (panjang * lebar));
                    break;

                case 2:
                    Console.WriteLine("Keliling = " + (2 * (panjang + lebar)));
                    break;

                default:
                    Console.WriteLine("Pilihan salah.");
                    break;
            }
        }

        void Lingkaran()
        {
            Console.Clear();
            Console.WriteLine("=== LINGKARAN ===");
            Console.WriteLine("1. Luas");
            Console.WriteLine("2. Keliling");
            Console.Write("Pilih : ");

            int pilih = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan jari-jari : ");
            double r = Convert.ToDouble(Console.ReadLine());

            switch (pilih)
            {
                case 1:
                    Console.WriteLine("Luas = " + (3.14 * r * r));
                    break;

                case 2:
                    Console.WriteLine("Keliling = " + (2 * 3.14 * r));
                    break;

                default:
                    Console.WriteLine("Pilihan salah.");
                    break;
            }
        }
    }
}
