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
                Console.WriteLine("4. Keluar");
                Console.WriteLine("====================================");
                Console.Write("Pilih Menu : ");

                int pilih = Convert.ToInt32(Console.ReadLine());

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
                        jalan = false;
                        Console.WriteLine("Terima kasih telah menggunakan Calculator Console.");
                        break;

                    default:
                        Console.WriteLine("Menu tidak tersedia!");
                        break;
                }

                if (jalan)
                {
                    Console.WriteLine();
                    Console.WriteLine("Tekan ENTER untuk kembali ke menu utama...");
                    Console.ReadLine();
                }
            }
        }
    }
}