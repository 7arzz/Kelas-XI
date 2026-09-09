using System;

namespace Jadwal
{
    class program 
    { 
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();


                Console.WriteLine("==== LIHAT JADWAL ====");
                Console.WriteLine("1. Senin");
                Console.WriteLine("2. Selasa");
                Console.WriteLine("3. Rabu");
                Console.WriteLine("4. Kamis");
                Console.WriteLine("5. Jumat");


                Console.Write("Pilih Hari : ");
                int hari = Convert.ToInt32(Console.ReadLine());

                switch (hari) 
                {
                    case 1:
                        Console.Clear();
                        Senin senin = new Senin();
                        senin.sesi1();
                        istirahat.istirahatSenin1();
                        senin.sesi2();
                        istirahat.istirahatSenin2();
                        senin.sesi3();

                        Console.WriteLine("\n Tekan enter untuk keluar");
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.Clear();
                        Selasa selasa = new Selasa();
                        selasa.sesi1();
                        istirahat.istirahat1();
                        selasa.sesi2();
                        istirahat.istirahat2();
                        selasa.sesi3();

                        Console.WriteLine("\n Tekan enter untuk keluar");
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.Clear();
                        Rabu rabu = new Rabu();
                        rabu.sesi1();
                        istirahat.istirahat1();
                        rabu.sesi2();
                        istirahat.istirahat2();
                        rabu.sesi3();

                        Console.WriteLine("\n Tekan enter untuk keluar");
                        Console.ReadLine();
                        break;

                    case 4:
                        Console.Clear();
                        Kamis.sesi1();
                        istirahat.istirahat1();
                        Kamis.sesi2();
                        istirahat.istirahat2();
                        Kamis.sesi3();

                        Console.WriteLine("\n Tekan enter untuk keluar");
                        Console.ReadLine();
                        break;

                    case 5:
                        Console.Clear();
                        Jumat.sesi1();
                        istirahat.istirahatJumat1();
                        Jumat.sesi2();

                        Console.WriteLine("\n Tekan enter untuk keluar");
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Pilihan tidak ada");
                        break;
                }

            }
        }
    }

    class istirahat 
    {
        public static void istirahatSenin1()
        {
            Console.WriteLine("\n\n Istirahat  : 09.20 - 09.55 \n\n");
        }

        public static void istirahatSenin2()
        {
            Console.WriteLine("\n\n Istirahat  : 11.40 - 12.30 \n\n");
        }

        public static void istirahat1()
        {
            Console.WriteLine("\n\nIstirahat  : 09.20 - 09.35 \n\n");
        }

        public static void istirahat2()
        {
            Console.WriteLine("\n\n Istirahat  : 11.35 - 12.30 \n\n");
        }

        public static void istirahatJumat1()
        {
            Console.WriteLine("\n\nIstirahat  : 09.30 - -9.45\n\n");
        }
    }

    class Senin
    {
        public void sesi1()
        {
            Console.WriteLine("=== SESI 1 ===");
            Console.WriteLine("B. Jepang  : 07.00 - 08.10");
            Console.WriteLine("B. Inggris : 08.10 - 09.20");
            Console.WriteLine("MTK        : 09.20 - 09.55");
        }

        public void sesi2()
        {
            Console.WriteLine("=== SESI 2 ===");
            Console.WriteLine("MTK        : 10.10 - 11.40");
        }

        public void sesi3()
        {
            Console.WriteLine("=== SESI 3 ===");
            Console.WriteLine("PPLG       : 12.30 - 15.00");
        }
    }

    class Selasa
    {
        public void sesi1()
        {
            Console.WriteLine("=== SESI 1 ===");
            Console.WriteLine("PKWU / KIK  : 07.00 - 08.10");
            Console.WriteLine("PJOK        : 08.10 - 09.20");
        }

        public void sesi2()
        {
            Console.WriteLine("=== SESI 2 ===");
            Console.WriteLine("B. Indonesia: 09.35 - 11.05");
            Console.WriteLine("PPLG        : 11.05 - 11.35");
        }

        public void sesi3()
        {
            Console.WriteLine("=== SESI 3 ===");
            Console.WriteLine("PPLG        : 12.30 - 14.30");
        }
    }

    class Rabu
    {
        public void sesi1()
        {
            Console.WriteLine("=== SESI 1 ===");
            Console.WriteLine("PPLG        : 07.00 - 09.20");
        }

        public void sesi2()
        {
            Console.WriteLine("=== SESI 2 ===");
            Console.WriteLine("PPLG        : 09.35 - 11.35");
        }

        public void sesi3()
        {
            Console.WriteLine("=== SESI 3 ===");
            Console.WriteLine("PPLG        : 12.30 - 13.30");
            Console.WriteLine("BK          : 13.30 - 13.30");
        }
    }

    class Kamis
    {
        public static void sesi1()
        {
            Console.WriteLine("=== SESI 1 ===");
            Console.WriteLine("B. Jerman   : 07.00 - 08.10");
            Console.WriteLine("B. Jawa     : 08.10 - 09.20");
        }

        public static void sesi2()
        {
            Console.WriteLine("=== SESI 2 ===");
            Console.WriteLine("PKWU / KIK   : 09.35 - 11.35");
        }

        public static void sesi3()
        {
            Console.WriteLine("=== SESI 3 ===");
            Console.WriteLine("PAI          : 12.30 - 14.30");
        }
    }

    class Jumat
    {
        public static void sesi1()
        {
            Console.WriteLine("=== SESI 1 ===");
            Console.WriteLine("B. Inggris   : 06.30 - 08.30");
            Console.WriteLine("Sejarah      : 08.30 - 09.30");
        }

        public static void sesi2()
        {
            Console.WriteLine("=== SESI 2 ===");
            Console.WriteLine("Pendidikan Pancasila : 09.45 - 11.15");
        }
    }
}
