using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemParkirMall
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Inisialisasi Increment (Penghitung Kendaraan)
            int totalKendaraan = 0;
            bool lanjut = true; // Penanda untuk loop


            while (lanjut)
            {
                //Input jenis kendaraan
                Console.WriteLine("Masukkan jenis kendaraan : ");
                Console.WriteLine("1.Motor");
                Console.WriteLine("2.Mobil");
                Console.WriteLine("Ketik \'selesai\' untuk keluar");
                string jenis = Console.ReadLine();

                // Cek apakah user mau berhenti
                if (jenis.ToLower() == "selesai")
                {
                    lanjut = false; // Menghentikan loop
                    continue; // Skip sisa kode di bawah dan langsung cek kondisi while
                }

                //Input durasi parkir
                Console.WriteLine("Masukkan durasi parkir");
                int durasi = Convert.ToInt32(Console.ReadLine());

                double tarif;

                switch (jenis)
                {
                    case "1":
                        tarif = durasi * 2000;
                        Console.WriteLine($"Biaya Parkir Motor: Rp {tarif}");
                        totalKendaraan++; //Increment: Tambah jumlah kendaraan
                        break;
                    case "2":
                        tarif = durasi * 5000;
                        Console.WriteLine($"Biaya Parkir Mobil: Rp {tarif}");
                        totalKendaraan++; //Increment: Tambah jumlah kendaraan
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid.");
                        break;
                }
            }

            Console.WriteLine($"Total kendaraan hari ini: {totalKendaraan}");

            Console.ReadLine();
        }
    }
}
