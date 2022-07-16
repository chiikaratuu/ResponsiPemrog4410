using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsi
{
    class Program
    {
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();
        static Mahasiswa mhs = new Mahasiswa();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        TampilMahasiswa();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("Pilihan Menu Aplikasi\n");
            Console.WriteLine("1. Tambah Mahasiswa");
            Console.WriteLine("2. Tampilkan Mahasiswa");
            Console.WriteLine("3. Keluar\n");
        }

        static void TambahMahasiswa()
        {
            Console.Clear();
            mhs = new Mahasiswa();
            Console.WriteLine("Tambah Data Mahasiswa\n");
            Console.Write("NIM   : ");
            mhs.NIM = Console.ReadLine();
            Console.Write("Nama  : ");
            mhs.NAMA = Console.ReadLine();
            Console.Write("Jenis Kelamin [L/P]   : ");
            mhs.JenisK = Console.ReadLine() == "L" ? "Laki-laki" : "Perempuan";
            Console.Write("IPK   : ");
            mhs.IPK = Console.ReadLine();
            daftarMahasiswa.Add(mhs);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }


        static void TampilMahasiswa()
        {
            Console.Clear();

            int no = 1;
            Console.WriteLine("Data Mahasiswa\n");
            foreach (Mahasiswa objmhs in daftarMahasiswa)
            {
                Console.WriteLine("{0}.{1},{2},{3},{4}", no, objmhs.NIM, objmhs.NAMA, objmhs.JenisK, objmhs.IPK);
                no++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
