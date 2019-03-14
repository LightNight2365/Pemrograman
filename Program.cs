using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.Title = "=== Aplikasi Calkulator ===";

                Console.Write(" Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine()); //proses casting
                Console.Write(" Inputkan nilai b = ");
                int b = int.Parse(Console.ReadLine()); //proses casting
                Console.WriteLine(" Pilih menu calculator : \n");
                Console.WriteLine(" 1.Penjumlahan");
                Console.WriteLine(" 2.Pengurangan");
                Console.WriteLine(" 3.Perkalian");
                Console.WriteLine(" 4.Pembagian");

                Console.Write(" Inputkan nomor menu [1..4] : ");
                int i = int.Parse(Console.ReadLine());

                switch (i)
                {
                    case 1:
                        Console.WriteLine(" Hasil Penambahan " + a + " + " + b + " = " + penambahan(a, b));
                        break;
                    case 2:
                        Console.WriteLine(" Hasil Pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
                        break;
                    case 3:
                        Console.WriteLine(" Hasil Perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
                    break;

                }

                Console.WriteLine(" Hasil Pembagian {0} / {1} = {2}", a, b, pembagian(a, b));

                Console.WriteLine("\n Tekan Sembarang key untuk keluar");
                Console.ReadKey();
            }

            static int penambahan(int a, int b)
            {
            return a + b;
        }

        static int pengurangan(int a, int b)
        {
            return a - b;
        }

        static int perkalian(int a, int b)
        {
            return a * b;
        }

        static int pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
