using System;

namespace DataSiswa
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("===== ANDARU ILHAM AMERTA =====");
                Console.WriteLine("1. Identitas");
                Console.WriteLine("2. Mata Pelajaran yang diikuti");
                Console.WriteLine("3. Riwayat Sekolah");
                Console.WriteLine("4. Nilai");
                Console.WriteLine("5. Absensi");
                Console.WriteLine("0. Keluar");

                Console.Write("\nPilih menu : ");
                int pilih = Convert.ToInt32(Console.ReadLine());

                switch (pilih)
                {
                

                    case 1:
                        Console.Clear();

                        Console.WriteLine("===== IDENTITAS =====");

                        Identitas id = new Identitas();
                        id.Siswa();

                        Console.WriteLine("\n===== DATA WALI =====");
                        id.Wali();

                        Console.WriteLine("\nTekan ENTER untuk kembali...");
                        Console.ReadLine();

                        break;



                    case 2:
                        Console.Clear();

                        Console.WriteLine("===== MATA PELAJARAN =====");

                        Console.WriteLine("\nProduktif :");
                        MataPelajaran.Produktif();

                        Console.WriteLine("\nNon Produktif :");
                        MataPelajaran.nonProduktif();

                        Console.WriteLine("\nTekan ENTER untuk kembali...");
                        Console.ReadLine();

                        break;



                    case 3:
                        Console.Clear();

                        Console.WriteLine("===== RIWAYAT SEKOLAH =====");

                        Identitas sekolah = new Identitas();
                        sekolah.Sekolah();

                        Console.WriteLine("\nTekan ENTER untuk kembali...");
                        Console.ReadLine();

                        break;


                 

                    case 4:
                        Console.Clear();
                            
                        Console.WriteLine("===== NILAI =====");

                        Console.WriteLine("\nProduktif :");
                        Nilai.nilaiProduktif();

                        Console.WriteLine("\nNon Produktif :");
                        Nilai.nilaiNonProduktif();

                        Console.WriteLine("\nTekan ENTER untuk kembali...");
                        Console.ReadLine();

                        break;


                   

                    case 5:
                        Console.Clear();

                        Absensi.Januari();
                        Absensi.Februari();
                        Absensi.Maret();
                        Absensi.April();
                        Absensi.Mei();
                        Absensi.Juni();
                        Absensi.Juli();
                        Absensi.September();
                        Absensi.Oktober();
                        Absensi.November();
                        Absensi.Desember();

                        Console.WriteLine("\nTekan ENTER untuk kembali...");
                        Console.ReadLine();
                        break;



                    case 0:
                        Console.WriteLine("\nProgram selesai.");
                        return;


                   

                    default:
                        Console.WriteLine("\nPilihan tidak tersedia.");
                        Console.WriteLine("Tekan ENTER untuk mencoba lagi...");
                        Console.ReadLine();

                        break;
                }
            }
        }
    }



    class Identitas
    {
        public void Siswa()
        {
            Console.WriteLine("Nama              : Andaru Ilham Amerta");
            Console.WriteLine("NISN              : 100");
            Console.WriteLine("Nama Panggilan    : Andaru");
            Console.WriteLine("Kelas             : XI - RPL");
            Console.WriteLine("Umur              : 17 Tahun");
            Console.WriteLine("Alamat            : GBN, Bangsri, Sukodono");
        }

        public void Wali()
        {
            Console.WriteLine("Nama              : Kuncoro");
            Console.WriteLine("Jenis Kelamin     : Laki - Laki");
            Console.WriteLine("Nomor             : 6212345678");
        }

        public void Sekolah()
        {
            Console.WriteLine("TK                : TK Muslimat NU");
            Console.WriteLine("SD                : SD Negeri Bringin Bendo 2");
            Console.WriteLine("SMP               : SMP Negeri 2 Sukodono");
            Console.WriteLine("SMK               : SMK Negeri 2 Buduran");
        }
    }



    class MataPelajaran
    {
        public static void Produktif()
        {
            Console.WriteLine("PPLG");
        }

        public static void nonProduktif()
        {
            Console.WriteLine("B. Jepang");
            Console.WriteLine("B. Inggris");
            Console.WriteLine("MTK");
            Console.WriteLine("PKWU / KIK");
            Console.WriteLine("PJOK");
            Console.WriteLine("B. Indonesia");
            Console.WriteLine("BK");
            Console.WriteLine("B. Jerman");
            Console.WriteLine("B. Jawa");
            Console.WriteLine("PAI");
            Console.WriteLine("Sejarah");
            Console.WriteLine("Pendidikan Pancasila");
        }
    }


    

    class Nilai
    {
        public static void nilaiProduktif()
        {
            Console.WriteLine("PPLG                  = 100");
        }

        public static void nilaiNonProduktif()
        {
            Console.WriteLine("B. Jepang             = 90");
            Console.WriteLine("B. Inggris            = 95");
            Console.WriteLine("MTK                   = 88");
            Console.WriteLine("PKWU / KIK            = 92");
            Console.WriteLine("PJOK                  = 90");
            Console.WriteLine("B. Indonesia          = 94");
            Console.WriteLine("BK                    = 90");
            Console.WriteLine("B. Jerman             = 89");
            Console.WriteLine("B. Jawa               = 91");
            Console.WriteLine("PAI                   = 93");
            Console.WriteLine("Sejarah               = 90");
            Console.WriteLine("Pendidikan Pancasila  = 95");
        }
    }


    class Absensi
    {
        public static void Januari()
        {
            Console.WriteLine("===== ABSENSI JANUARI =====");
            Console.WriteLine("Hadir : 20");
            Console.WriteLine("Sakit : 1");
            Console.WriteLine("Izin  : 1");
            Console.WriteLine("Alpha : 0");
        }

        public static void Februari()
        {
            Console.WriteLine("===== ABSENSI FEBRUARI =====");
            Console.WriteLine("Hadir : 18");
            Console.WriteLine("Sakit : 1");
            Console.WriteLine("Izin  : 1");
            Console.WriteLine("Alpha : 0");
        }

        public static void Maret()
        {
            Console.WriteLine("===== ABSENSI MARET =====");
            Console.WriteLine("Hadir : 21");
            Console.WriteLine("Sakit : 1");
            Console.WriteLine("Izin  : 0");
            Console.WriteLine("Alpha : 0");
        }

        public static void April()
        {
            Console.WriteLine("===== ABSENSI APRIL =====");
            Console.WriteLine("Hadir : 19");
            Console.WriteLine("Sakit : 1");
            Console.WriteLine("Izin  : 1");
            Console.WriteLine("Alpha : 0");
        }

        public static void Mei()
        {
            Console.WriteLine("===== ABSENSI MEI =====");
            Console.WriteLine("Hadir : 20");
            Console.WriteLine("Sakit : 0");
            Console.WriteLine("Izin  : 1");
            Console.WriteLine("Alpha : 0");
        }

        public static void Juni()
        {
            Console.WriteLine("===== ABSENSI JUNI =====");
            Console.WriteLine("Hadir : 19");
            Console.WriteLine("Sakit : 1");
            Console.WriteLine("Izin  : 1");
            Console.WriteLine("Alpha : 0");
        }

        public static void Juli()
        {
            Console.WriteLine("===== ABSENSI JULI =====");
            Console.WriteLine("Hadir : 15");
            Console.WriteLine("Sakit : 1");
            Console.WriteLine("Izin  : 0");
            Console.WriteLine("Alpha : 0");
        }

        public static void Agustus()
        {
            Console.WriteLine("===== ABSENSI AGUSTUS =====");
            Console.WriteLine("Hadir : 21");
            Console.WriteLine("Sakit : 1");
            Console.WriteLine("Izin  : 1");
            Console.WriteLine("Alpha : 0");
        }

        public static void September()
        {
            Console.WriteLine("===== ABSENSI SEPTEMBER =====");
            Console.WriteLine("Hadir : 20");
            Console.WriteLine("Sakit : 1");
            Console.WriteLine("Izin  : 1");
            Console.WriteLine("Alpha : 0");
        }

        public static void Oktober()
        {
            Console.WriteLine("===== ABSENSI OKTOBER =====");
            Console.WriteLine("Hadir : 21");
            Console.WriteLine("Sakit : 0");
            Console.WriteLine("Izin  : 1");
            Console.WriteLine("Alpha : 0");
        }

        public static void November()
        {
            Console.WriteLine("===== ABSENSI NOVEMBER =====");
            Console.WriteLine("Hadir : 20");
            Console.WriteLine("Sakit : 1");
            Console.WriteLine("Izin  : 0");
            Console.WriteLine("Alpha : 0");
        }

        public static void Desember()
        {
            Console.WriteLine("===== ABSENSI DESEMBER =====");
            Console.WriteLine("Hadir : 15");
            Console.WriteLine("Sakit : 1");
            Console.WriteLine("Izin  : 1");
            Console.WriteLine("Alpha : 0");
        }
    }
}