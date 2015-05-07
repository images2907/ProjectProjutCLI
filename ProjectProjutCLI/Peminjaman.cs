﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProjutCLI
{
    class Peminjaman
    {
        public static void MainPeminjaman()
        {
            Int16 pilihPinjamMenu = 0;
            do
            {
                printmenuPeminjaman();
                pilihPinjamMenu = Convert.ToInt16(Console.ReadLine());
                if (pilihPinjamMenu > 0 && pilihPinjamMenu < 7)
                {
                    continue;
                }
                Console.WriteLine("Pilihan yang anda masukan salah!");
                Console.WriteLine("Tekan sembarang untuk memilih kembali...");
                Console.ReadLine();
            } while (pilihPinjamMenu < 1 || pilihPinjamMenu > 6);

            switch (pilihPinjamMenu)
            {
                case 1:
                    pinjamBuku();
                    break;
                case 2:
                    lihatOverdue();
                    break;
                case 3:
                    tagihOverdue();
                    break;
                case 4:
                    tagihMahasiswa();
                    break;
                case 5:
                    kembaliBuku();
                    break;
                case 6:
                    Program.Main();
                    break;
                default:
                    break;
            }
            
        }
        static void printmenuPeminjaman()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\tMenu Peminjaman");
            Console.WriteLine("\t\t\t\t===============\n");
            Console.WriteLine("1. Pinjam buku\n");
            Console.WriteLine("2. Lihat buku yang overdue\n");
            Console.WriteLine("3. Tagih buku yang overdue\n");
            Console.WriteLine("4. Tagih mahasiswa tertentu\n");
            Console.WriteLine("5. Kembali buku\n");
            Console.WriteLine("6. Kembali ke menu utama\n");
            Console.Write("Masukan pilihan anda : ");
        }

        static void pinjamBuku()
        {
            int nim;
            string judul;
            string edisi;
            Console.Clear();
            Console.WriteLine("\t\t\t\tMenu Pinjam Buku");
            Console.WriteLine("\t\t\t\t================\n");
            Console.Write("Masukan judul buku : ");
            judul = Console.ReadLine();
            Console.Write("Masukan edisi buku : ");
            edisi = Console.ReadLine();

            //coding cek buku apakah available
            
            //jika buku not available
            Console.WriteLine("Buku tidak bisa dipinjam karena lagi dipinjam orang lain");
            Console.WriteLine("Tekan sembarang untuk kembali ke menu...");
            Console.Read();
            MainPeminjaman();

            //jika buku available
            Console.Write("Masukan NIM mahasiswa : ");
            nim = int.Parse(Console.ReadLine());
                //jika nim tidak valid
                Console.WriteLine("Tidak ada mahaiswa dengan NIM tersebut!");
                Console.Write("Tekan sembarang untuk kembali ke menu...");
                Console.Read();
                MainPeminjaman();

                //jika sudah meminjam 5 buku
                Console.WriteLine("Maaf mahasiswa ini sudah meminjam 5 buku");
                Console.Write("Tekan sembarang untuk kembali ke menu...");
                Console.Read();
                MainPeminjaman();

                //jika telat mengembalikan buku
                Console.WriteLine("Maaf, mahasiswa ini ada buku yang sudah overdue belum dikembalikan");
                Console.Write("Tekan sembarang untuk kembali ke menu...");
                Console.Read();
                MainPeminjaman();
        }

        static void lihatOverdue()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\tLihat Pinjaman Overdue");
            Console.WriteLine("\t\t\t\t======================\n");
            Console.WriteLine("Judul\t Pengarang\t Edisi\t Tanggal Pinjam\t NIM Peminjam ");

            Console.Write("Tekan sembarang untuk kembali ke menu...");
            Console.Read();
            MainPeminjaman();
        }

        static void tagihOverdue()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\tTagih Pinjaman Overdue");
            Console.WriteLine("\t\t\t\t======================\n");
            Console.WriteLine("Nama Peminjam  : ");
            Console.WriteLine("Judul Buku     : ");
            Console.WriteLine("Penulis Buku   : ");
            Console.WriteLine("Edisi          : ");
            Console.WriteLine("Hari terlambat : ");
            Console.WriteLine("Jumlah Denda   : ");
        }

        static void tagihMahasiswa()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\tTagih Pinjaman Overdue");
            Console.WriteLine("\t\t\t\t======================\n");
            Console.WriteLine("Masukan Nama Mahasiswa yang ingin ditagih /n Nama Mahasiswa: ");
        }

        static void kembaliBuku()
        {

        }
    }
}
