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
                        // =========== CALCULATOR SEDERHANA ===========
                        case 1:
                            sederhana.MenuSederhana();
                            //Console.WriteLine("=== CALCULATOR SEDERHANA ===");
                            //Console.WriteLine("1. Penjumlahan");
                            //Console.WriteLine("2. Pengurangan");
                            //Console.WriteLine("3. Perkalian");
                            //Console.WriteLine("4. Pembagian");

                            //Console.Write("Pilih : ");
                            //int pilih1 = Convert.ToInt32(Console.ReadLine());

                            //Console.Write("Masukkan Angka Pertama : ");
                            //double a = Convert.ToDouble(Console.ReadLine());

                            //Console.Write("Masukkan Angka Kedua : ");
                            //double b = Convert.ToDouble(Console.ReadLine());

                            //switch (pilih1)
                            //{
                            //    case 1:
                            //        Console.WriteLine("Hasil = " + (a + b));
                            //        break;

                            //    case 2:
                            //        Console.WriteLine("Hasil = " + (a - b));
                            //        break;

                            //    case 3:
                            //        Console.WriteLine("Hasil = " + (a * b));
                            //        break;

                            //    case 4:
                            //        if (b == 0)
                            //            Console.WriteLine("Tidak bisa dibagi nol!");
                            //        else
                            //            Console.WriteLine("Hasil = " + (a / b));
                            //        break;

                            //    default:
                            //        Console.WriteLine("Pilihan salah.");
                            //        break;
                            //}
                            break;

                        case 2:
                            datar.MenuDatar();
                        // =========== CALCULATOR BANGUN DATAR ===========
                            //Console.WriteLine("=== CALCULATUR BANGUN DATAR ===");

                            //Console.WriteLine("1. Persegi");
                            //Console.WriteLine("2. Persegi Panjang ");
                            //Console.WriteLine("3. Lingkaran");

                            //Console.WriteLine("Pilih Bangun Datar : ");
                            //int pilih2 = Convert.ToInt32(Console.ReadLine());

                            //switch (pilih2)
                            //{
                            //    case 1:
                            //        Persegi();
                            //        break;

                            //    case 2:
                            //        PersegiPanjang();
                            //        break;

                            //    case 3:
                            //        Lingkaran();
                            //        break;

                            //    default:
                            //        Console.WriteLine("Pilihan tidak tersedia.");
                            //        break;
                            //}

                            //void Persegi()
                            //{
                            //    Console.Clear();
                            //    Console.WriteLine("=== PERSEGI ===");
                            //    Console.WriteLine("1. Luas");
                            //    Console.WriteLine("2. Keliling");
                            //    Console.Write("Pilih : ");

                            //    int pilih = Convert.ToInt32(Console.ReadLine());

                            //    Console.Write("Masukkan sisi : ");
                            //    double sisi = Convert.ToDouble(Console.ReadLine());

                            //    switch (pilih)
                            //    {
                            //        case 1:
                            //            Console.WriteLine("Luas = " + (sisi * sisi));
                            //            break;

                            //        case 2:
                            //            Console.WriteLine("Keliling = " + (4 * sisi));
                            //            break;

                            //        default:
                            //            Console.WriteLine("Pilihan salah.");
                            //            break;
                            //    }
                            //}

                            //void PersegiPanjang()
                            //{
                            //    Console.Clear();
                            //    Console.WriteLine("=== PERSEGI PANJANG ===");
                            //    Console.WriteLine("1. Luas");
                            //    Console.WriteLine("2. Keliling");
                            //    Console.Write("Pilih : ");

                            //    int pilih = Convert.ToInt32(Console.ReadLine());

                            //    Console.Write("Masukkan panjang : ");
                            //    double panjang = Convert.ToDouble(Console.ReadLine());

                            //    Console.Write("Masukkan lebar : ");
                            //    double lebar = Convert.ToDouble(Console.ReadLine());

                            //    switch (pilih)
                            //    {
                            //        case 1:
                            //            Console.WriteLine("Luas = " + (panjang * lebar));
                            //            break;

                            //        case 2:
                            //            Console.WriteLine("Keliling = " + (2 * (panjang + lebar)));
                            //            break;

                            //        default:
                            //            Console.WriteLine("Pilihan salah.");
                            //            break;
                            //    }
                            //}

                            //void Lingkaran()
                            //{
                            //    Console.Clear();
                            //    Console.WriteLine("=== LINGKARAN ===");
                            //    Console.WriteLine("1. Luas");
                            //    Console.WriteLine("2. Keliling");
                            //    Console.Write("Pilih : ");

                            //    int pilih = Convert.ToInt32(Console.ReadLine());

                            //    Console.Write("Masukkan jari-jari : ");
                            //    double r = Convert.ToDouble(Console.ReadLine());

                            //    switch (pilih)
                            //    {
                            //        case 1:
                            //            Console.WriteLine("Luas = " + (3.14 * r * r));
                            //            break;

                            //        case 2:
                            //            Console.WriteLine("Keliling = " + (2 * 3.14 * r));
                            //            break;

                            //        default:
                            //            Console.WriteLine("Pilihan salah.");
                            //            break;
                            //    }
                            //}
                            break;

                        case 3:
                            ruang.MenuRuang();
                        // =========== CALCULATOR BANGUN RUANG ===========
                            //Console.Clear();
                            //Console.WriteLine("=== CALCULATOR BANGUN RUANG ===");
                            //Console.WriteLine("1. Kubus");
                            //Console.WriteLine("2. Balok");
                            //Console.WriteLine("3. Tabung");
                            //Console.Write("Pilih Bangun Ruang : ");

                            //int pilih3 = Convert.ToInt32(Console.ReadLine());

                            //switch (pilih3)
                            //{
                            //    case 1:
                            //        Kubus();
                            //        break;

                            //    case 2:
                            //        Balok();
                            //        break;

                            //    case 3:
                            //        Tabung();
                            //        break;

                            //    default:
                            //        Console.WriteLine("Pilihan tidak tersedia.");
                            //        break;
                            //}
                            //void Kubus()
                            //{
                            //    Console.Clear();
                            //    Console.WriteLine("=== KUBUS ===");
                            //    Console.WriteLine("1. Volume");
                            //    Console.WriteLine("2. Luas Permukaan");
                            //    Console.Write("Pilih : ");

                            //    int pilih = Convert.ToInt32(Console.ReadLine());

                            //    Console.Write("Masukkan sisi : ");
                            //    double sisi = Convert.ToDouble(Console.ReadLine());

                            //    switch (pilih)
                            //    {
                            //        case 1:
                            //            Console.WriteLine("Volume = " + (sisi * sisi * sisi));
                            //            break;

                            //        case 2:
                            //            Console.WriteLine("Luas Permukaan = " + (6 * sisi * sisi));
                            //            break;

                            //        default:
                            //            Console.WriteLine("Pilihan salah.");
                            //            break;
                            //    }
                            //}

                            //void Balok()
                            //{
                            //    Console.Clear();
                            //    Console.WriteLine("=== BALOK ===");
                            //    Console.WriteLine("1. Volume");
                            //    Console.WriteLine("2. Luas Permukaan");
                            //    Console.Write("Pilih : ");

                            //    int pilih = Convert.ToInt32(Console.ReadLine());

                            //    Console.Write("Masukkan Panjang : ");
                            //    double p = Convert.ToDouble(Console.ReadLine());

                            //    Console.Write("Masukkan Lebar : ");
                            //    double l = Convert.ToDouble(Console.ReadLine());

                            //    Console.Write("Masukkan Tinggi : ");
                            //    double t = Convert.ToDouble(Console.ReadLine());

                            //    switch (pilih)
                            //    {
                            //        case 1:
                            //            Console.WriteLine("Volume = " + (p * l * t));
                            //            break;

                            //        case 2:
                            //            Console.WriteLine("Luas Permukaan = " + (2 * ((p * l) + (p * t) + (l * t))));
                            //            break;

                            //        default:
                            //            Console.WriteLine("Pilihan salah.");
                            //            break;
                            //    }
                            //}

                            //void Tabung()
                            //{
                            //    Console.Clear();
                            //    Console.WriteLine("=== TABUNG ===");
                            //    Console.WriteLine("1. Volume");
                            //    Console.WriteLine("2. Luas Permukaan");
                            //    Console.Write("Pilih : ");

                            //    int pilih = Convert.ToInt32(Console.ReadLine());

                            //    Console.Write("Masukkan Jari-jari : ");
                            //    double r = Convert.ToDouble(Console.ReadLine());

                            //    Console.Write("Masukkan Tinggi : ");
                            //    double t = Convert.ToDouble(Console.ReadLine());

                            //    switch (pilih)
                            //    {
                            //        case 1:
                            //            Console.WriteLine("Volume = " + (3.14 * r * r * t));
                            //            break;

                            //        case 2:
                            //            Console.WriteLine("Luas Permukaan = " + (2 * 3.14 * r * (r + t)));
                            //            break;

                            //        default:
                            //            Console.WriteLine("Pilihan salah.");
                            //            break;
                            //    }
                            //}
                            break;

                        case 4:
                            zodiak.MenuZodiak();
                        // =========== CALCULATOR ZODIAK ===========
                            //Console.Clear();
                            //Console.WriteLine("=== CALCULATOR ZODIAK ===");

                            //Console.Write("Masukkan tanggal lahir (1-31): ");
                            //int tanggal = Convert.ToInt32(Console.ReadLine());

                            //Console.Write("Masukkan bulan lahir (1-12): ");
                            //int bulan = Convert.ToInt32(Console.ReadLine());

                            //string zodiak;

                            //if ((bulan == 1 && tanggal >= 20) || (bulan == 2 && tanggal <= 18))
                            //    zodiak = "Aquarius";
                            //else if ((bulan == 2 && tanggal >= 19) || (bulan == 3 && tanggal <= 20))
                            //    zodiak = "Pisces";
                            //else if ((bulan == 3 && tanggal >= 21) || (bulan == 4 && tanggal <= 19))
                            //    zodiak = "Aries";
                            //else if ((bulan == 4 && tanggal >= 20) || (bulan == 5 && tanggal <= 20))
                            //    zodiak = "Taurus";
                            //else if ((bulan == 5 && tanggal >= 21) || (bulan == 6 && tanggal <= 20))
                            //    zodiak = "Gemini";
                            //else if ((bulan == 6 && tanggal >= 21) || (bulan == 7 && tanggal <= 22))
                            //    zodiak = "Cancer";
                            //else if ((bulan == 7 && tanggal >= 23) || (bulan == 8 && tanggal <= 22))
                            //    zodiak = "Leo";
                            //else if ((bulan == 8 && tanggal >= 23) || (bulan == 9 && tanggal <= 22))
                            //    zodiak = "Virgo";
                            //else if ((bulan == 9 && tanggal >= 23) || (bulan == 10 && tanggal <= 22))
                            //    zodiak = "Libra";
                            //else if ((bulan == 10 && tanggal >= 23) || (bulan == 11 && tanggal <= 21))
                            //    zodiak = "Scorpio";
                            //else if ((bulan == 11 && tanggal >= 22) || (bulan == 12 && tanggal <= 21))
                            //    zodiak = "Sagitarius";
                            //else if ((bulan == 12 && tanggal >= 22) || (bulan == 1 && tanggal <= 19))
                            //    zodiak = "Capricorn";
                            //else
                            //    zodiak = "Tanggal tidak valid";

                            //Console.WriteLine();
                            //Console.WriteLine("Zodiak Anda : " + zodiak);
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







    // SEDERHANA
    internal class CalculatorSederhana
    {
        public void MenuSederhana()
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






    //DATAR
    internal class CalculatorDatar
    {
        public void MenuDatar()
        {
            Console.WriteLine("=== CALCULATOR BANGUN DATAR ===");

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



    //RUANG
    internal class CalculatorRuang
    {
        public void MenuRuang()
        {
            Console.Clear();
            Console.WriteLine("=== CALCULATOR BANGUN RUANG ===");
            Console.WriteLine("1. Kubus");
            Console.WriteLine("2. Balok");
            Console.WriteLine("3. Tabung");
            Console.Write("Pilih Bangun Ruang : ");

            int pilih = Convert.ToInt32(Console.ReadLine());

            switch (pilih)
            {
                case 1:
                    Kubus();
                    break;

                case 2:
                    Balok();
                    break;

                case 3:
                    Tabung();
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    break;
            }
        }

        void Kubus()
        {
            Console.Clear();
            Console.WriteLine("=== KUBUS ===");
            Console.WriteLine("1. Volume");
            Console.WriteLine("2. Luas Permukaan");
            Console.Write("Pilih : ");

            int pilih = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan sisi : ");
            double sisi = Convert.ToDouble(Console.ReadLine());

            switch (pilih)
            {
                case 1:
                    Console.WriteLine("Volume = " + (sisi * sisi * sisi));
                    break;

                case 2:
                    Console.WriteLine("Luas Permukaan = " + (6 * sisi * sisi));
                    break;

                default:
                    Console.WriteLine("Pilihan salah.");
                    break;
            }
        }

        void Balok()
        {
            Console.Clear();
            Console.WriteLine("=== BALOK ===");
            Console.WriteLine("1. Volume");
            Console.WriteLine("2. Luas Permukaan");
            Console.Write("Pilih : ");

            int pilih = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Panjang : ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan Lebar : ");
            double l = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan Tinggi : ");
            double t = Convert.ToDouble(Console.ReadLine());

            switch (pilih)
            {
                case 1:
                    Console.WriteLine("Volume = " + (p * l * t));
                    break;

                case 2:
                    Console.WriteLine("Luas Permukaan = " + (2 * ((p * l) + (p * t) + (l * t))));
                    break;

                default:
                    Console.WriteLine("Pilihan salah.");
                    break;
            }
        }

        void Tabung()
        {
            Console.Clear();
            Console.WriteLine("=== TABUNG ===");
            Console.WriteLine("1. Volume");
            Console.WriteLine("2. Luas Permukaan");
            Console.Write("Pilih : ");

            int pilih = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Jari-jari : ");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan Tinggi : ");
            double t = Convert.ToDouble(Console.ReadLine());

            switch (pilih)
            {
                case 1:
                    Console.WriteLine("Volume = " + (3.14 * r * r * t));
                    break;

                case 2:
                    Console.WriteLine("Luas Permukaan = " + (2 * 3.14 * r * (r + t)));
                    break;

                default:
                    Console.WriteLine("Pilihan salah.");
                    break;
            }
        }
    }




    //====================
    //   ZODIAK
    //====================
    internal class CalculatorZodiak
    {
        public void MenuZodiak()
        {
            Console.Clear();
            Console.WriteLine("=== CALCULATOR ZODIAK ===");

            Console.Write("Masukkan tanggal lahir (1-31): ");
            int tanggal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan bulan lahir (1-12): ");
            int bulan = Convert.ToInt32(Console.ReadLine());

            string zodiak;

            if ((bulan == 1 && tanggal >= 20) || (bulan == 2 && tanggal <= 18))
                zodiak = "Aquarius";
            else if ((bulan == 2 && tanggal >= 19) || (bulan == 3 && tanggal <= 20))
                zodiak = "Pisces";
            else if ((bulan == 3 && tanggal >= 21) || (bulan == 4 && tanggal <= 19))
                zodiak = "Aries";
            else if ((bulan == 4 && tanggal >= 20) || (bulan == 5 && tanggal <= 20))
                zodiak = "Taurus";
            else if ((bulan == 5 && tanggal >= 21) || (bulan == 6 && tanggal <= 20))
                zodiak = "Gemini";
            else if ((bulan == 6 && tanggal >= 21) || (bulan == 7 && tanggal <= 22))
                zodiak = "Cancer";
            else if ((bulan == 7 && tanggal >= 23) || (bulan == 8 && tanggal <= 22))
                zodiak = "Leo";
            else if ((bulan == 8 && tanggal >= 23) || (bulan == 9 && tanggal <= 22))
                zodiak = "Virgo";
            else if ((bulan == 9 && tanggal >= 23) || (bulan == 10 && tanggal <= 22))
                zodiak = "Libra";
            else if ((bulan == 10 && tanggal >= 23) || (bulan == 11 && tanggal <= 21))
                zodiak = "Scorpio";
            else if ((bulan == 11 && tanggal >= 22) || (bulan == 12 && tanggal <= 21))
                zodiak = "Sagitarius";
            else if ((bulan == 12 && tanggal >= 22) || (bulan == 1 && tanggal <= 19))
                zodiak = "Capricorn";
            else
                zodiak = "Tanggal tidak valid";

            Console.WriteLine();
            Console.WriteLine("Zodiak Anda : " + zodiak);
        }
    }

}