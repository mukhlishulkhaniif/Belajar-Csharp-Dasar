using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorScoreGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input nama pemain
            Console.Write("Masukkan nama Pemain : ");
            string nama = Console.ReadLine();

            //Input score babak 1
            Console.Write("Masukkan score ke 1 : ");
            int Score1 = Convert.ToInt32(Console.ReadLine());

            //Input score babak 2
            Console.Write("Masukkan score ke 2 : ");
            int Score2 = Convert.ToInt32(Console.ReadLine());

            //Input score babak 3
            Console.Write("Masukkan score ke 3 : ");
            int Score3 = Convert.ToInt32(Console.ReadLine());

            double rata = (double)(Score1 + Score2 + Score3) / 3;

            //Menampilkan rata-rata score
            Console.WriteLine("rata-rata skor adalah : " + rata);


            //Memanggil method
            grade(rata);

            Console.ReadLine();
        }

        //Method untuk mengetahui grade
        static void grade(double skor)
        {

            if (skor > 80)
            {
                Console.WriteLine("Hebat");
            }
            else if (skor >= 50 && skor <= 80)
            {
                Console.WriteLine("Boleh Juga");
            }
            else
            {
                Console.WriteLine("Belajar lagi");
            }
        }
    }
}
