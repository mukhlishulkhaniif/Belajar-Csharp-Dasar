using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemKasirSederhana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variabel Total transaksi
            int jumlahTransaksi = 0;

            //Variabel cek lanjut transaksi atau berhenti
            bool lanjut = true;

            //Variabel total jumlah pembayaran
            double totalBayar = 0;

            //Variabel bayar
            int bayar = 0;

            //Variabel harga
            int harga = 0;


            //Perulangan untuk lanjut transaksi atau berhenti
            while (lanjut)
            {
                //Menampilkan Daftar menu
                Console.WriteLine("==== Daftar Barang ====");
                Console.WriteLine("1.Buku");
                Console.WriteLine("2.Pensil");
                Console.WriteLine("3.Pulpen");
                Console.WriteLine("=======================");

                //Input memilih barang
                Console.Write("Masukkan nomer jenis barang yang dibeli : ");
                string barang = Console.ReadLine();

                //Input Jumlah barang yang dibeli
                Console.Write("Masukkan jumlah barang yang dibeli : ");
                int jumlahBarang = Convert.ToInt32(Console.ReadLine());

                switch (barang)
                {
                    case "1":
                        //Menentukan harga barang
                        harga = 10000;
                        // jumlahTransaksi++; // REVISI: baris ini dimatikan karena dipindah ke bawah
                        break;
                    case "2":
                        //Menentukan harga barang
                        harga = 5000;
                        // jumlahTransaksi++; // REVISI: baris ini dimatikan karena dipindah ke bawah
                        break;
                    case "3":
                        //Menentukan harga barang
                        harga = 7000;
                        // jumlahTransaksi++; // REVISI: baris ini dimatikan karena dipindah ke bawah
                        break;
                    default:
                        Console.WriteLine("Jenis barang tidak valid");
                        harga = 0; // REVISI: reset harga jadi 0 kalau input salah
                        break;
                }

                // REVISI: Tambahan pengecekan agar transaksi hanya dihitung jika barang valid (harga > 0)
                if (harga > 0)
                {
                    //Memanggil methods hitung pembayaran
                    bayar = hitung(harga, jumlahBarang);

                    //Menghitung diskon
                    if (bayar > 50000)
                    {
                        totalBayar = bayar * 0.90;
                    }
                    else
                    {
                        totalBayar = bayar * 1;
                    }

                    jumlahTransaksi++; // REVISI: Ini pindahan jumlahTransaksi++; agar lebih akurat

                    //Menampilkan yang harus dibayar
                    Console.WriteLine("=======================");
                    Console.WriteLine("Harga bayar sebelum diskon : " + bayar);
                    Console.WriteLine("Harga bayar setelah diskon : " + totalBayar);
                }

                //Input ingin lanjut transaksi atau berhenti
                Console.WriteLine("=======================");
                Console.Write("Apakah ingin lanjut transaksi (y/n) : ");
                string status = Console.ReadLine();

                //Menampilkan jumlah transaksi
                Console.WriteLine("Jumlah transaksi : " + jumlahTransaksi);

                //Cek apakah transaksi berhenti
                if (status.ToLower() == "n")
                {
                    lanjut = false;
                    continue;
                }
            }

            Console.ReadLine();
        }

        static int hitung(int a, int b)
        {
            return a * b;
        }
    }
}