using System;

namespace CalculatorConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculatorSederhana sederhana = new CalculatorSederhana();
            CalculatorDatar datar = new CalculatorDatar();
            CalculatorRuang ruang = new CalculatorRuang();
            CalculatorZodiak zodiak = new CalculatorZodiak();

            bool jalan = true;

            while (jalan)
            {
                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine("      CALCULATOR CONSOLE");
                Console.WriteLine("====================================");
                Console.WriteLine("1. Calculator Sederhana");
                Console.WriteLine("2. Calculator Bangun Datar");
                Console.WriteLine("3. Calculator Bangun Ruang");
                Console.WriteLine("4. Cari Zodiak");
                Console.WriteLine("5. Keluar");
                Console.WriteLine("====================================");
                Console.Write("Pilih Menu : ");

                int pilih = Convert.ToInt32(Console.ReadLine());

                if (pilih == 5)
                {
                    Console.WriteLine("Terima kasih telah menggunakan Calculator Console.");
                    break;
                }

                bool ulang = true;

                while (ulang)
                {
                    Console.Clear();

                    switch (pilih)
                    {
                        case 1:
                            sederhana.Menu();
                            break;

                        case 2:
                            datar.Menu();
                            break;

                        case 3:
                            ruang.Menu();
                            break;

                        case 4:
                            zodiak.Menu();
                            break;

                        default:
                            Console.WriteLine("Menu tidak tersedia!");
                            ulang = false;
                            continue;
                    }

                    Console.WriteLine();
                    Console.WriteLine("==========================");
                    Console.WriteLine("1. Ulangi");
                    Console.WriteLine("2. Menu Utama");
                    Console.Write("Pilih : ");

                    int pilihan = Convert.ToInt32(Console.ReadLine());

                    if (pilihan == 1)
                    {
                        continue;
                    }
                    else if (pilihan == 2)
                    {
                        ulang = false;
                    }
                    else
                    {
                        Console.WriteLine("Pilihan tidak tersedia!");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}