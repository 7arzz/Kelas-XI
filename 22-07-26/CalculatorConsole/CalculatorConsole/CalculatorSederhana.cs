using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorConsole
{
    internal class CalculatorSederhana
    {
        public void Menu()
        {
            Console.WriteLine("=== CALCULATOR SEDERHANA ===");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            Console.Write("Pilih : ");
            int pilih = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Angka Pertama : ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan Angka Kedua : ");
            double b = Convert.ToDouble(Console.ReadLine());

            switch (pilih)
            {
                case 1:
                    Console.WriteLine("Hasil = " + (a + b));
                    break;

                case 2:
                    Console.WriteLine("Hasil = " + (a - b));
                    break;

                case 3:
                    Console.WriteLine("Hasil = " + (a * b));
                    break;

                case 4:
                    if (b == 0)
                        Console.WriteLine("Tidak bisa dibagi nol!");
                    else
                        Console.WriteLine("Hasil = " + (a / b));
                    break;

                default:
                    Console.WriteLine("Pilihan salah.");
                    break;
            }
        }
    }
}
