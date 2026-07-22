//using System;

//namespace CalculatorConsole
//{
//    internal class CalculatorRuang1
//    {
//        public void Menu()
//        {
//            Console.Clear();
//            Console.WriteLine("=== CALCULATOR BANGUN RUANG ===");
//            Console.WriteLine("1. Kubus");
//            Console.WriteLine("2. Balok");
//            Console.WriteLine("3. Tabung");
//            Console.Write("Pilih Bangun Ruang : ");

//            int pilih = Convert.ToInt32(Console.ReadLine());

//            switch (pilih)
//            {
//                case 1:
//                    Kubus();
//                    break;

//                case 2:
//                    Balok();
//                    break;

//                case 3:
//                    Tabung();
//                    break;

//                default:
//                    Console.WriteLine("Pilihan tidak tersedia.");
//                    break;
//            }
//        }

//        void Kubus()
//        {
//            Console.Clear();
//            Console.WriteLine("=== KUBUS ===");
//            Console.WriteLine("1. Volume");
//            Console.WriteLine("2. Luas Permukaan");
//            Console.Write("Pilih : ");

//            int pilih = Convert.ToInt32(Console.ReadLine());

//            Console.Write("Masukkan sisi : ");
//            double sisi = Convert.ToDouble(Console.ReadLine());

//            switch (pilih)
//            {
//                case 1:
//                    Console.WriteLine("Volume = " + (sisi * sisi * sisi));
//                    break;

//                case 2:
//                    Console.WriteLine("Luas Permukaan = " + (6 * sisi * sisi));
//                    break;

//                default:
//                    Console.WriteLine("Pilihan salah.");
//                    break;
//            }
//        }

//        void Balok()
//        {
//            Console.Clear();
//            Console.WriteLine("=== BALOK ===");
//            Console.WriteLine("1. Volume");
//            Console.WriteLine("2. Luas Permukaan");
//            Console.Write("Pilih : ");

//            int pilih = Convert.ToInt32(Console.ReadLine());

//            Console.Write("Masukkan Panjang : ");
//            double p = Convert.ToDouble(Console.ReadLine());

//            Console.Write("Masukkan Lebar : ");
//            double l = Convert.ToDouble(Console.ReadLine());

//            Console.Write("Masukkan Tinggi : ");
//            double t = Convert.ToDouble(Console.ReadLine());

//            switch (pilih)
//            {
//                case 1:
//                    Console.WriteLine("Volume = " + (p * l * t));
//                    break;

//                case 2:
//                    Console.WriteLine("Luas Permukaan = " + (2 * ((p * l) + (p * t) + (l * t))));
//                    break;

//                default:
//                    Console.WriteLine("Pilihan salah.");
//                    break;
//            }
//        }

//        void Tabung()
//        {
//            Console.Clear();
//            Console.WriteLine("=== TABUNG ===");
//            Console.WriteLine("1. Volume");
//            Console.WriteLine("2. Luas Permukaan");
//            Console.Write("Pilih : ");

//            int pilih = Convert.ToInt32(Console.ReadLine());

//            Console.Write("Masukkan Jari-jari : ");
//            double r = Convert.ToDouble(Console.ReadLine());

//            Console.Write("Masukkan Tinggi : ");
//            double t = Convert.ToDouble(Console.ReadLine());

//            switch (pilih)
//            {
//                case 1:
//                    Console.WriteLine("Volume = " + (3.14 * r * r * t));
//                    break;

//                case 2:
//                    Console.WriteLine("Luas Permukaan = " + (2 * 3.14 * r * (r + t)));
//                    break;

//                default:
//                    Console.WriteLine("Pilihan salah.");
//                    break;
//            }
//        }
//    }
//}