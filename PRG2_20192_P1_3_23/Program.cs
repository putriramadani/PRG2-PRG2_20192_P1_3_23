using System;

namespace PRG2_20192_P1_3_23
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 10;
            int i;

            Console.WriteLine("=== Program Syair lagu anak ayam ===\n");
            Console.WriteLine("ANAK AYAM TURUN {0}\n", N);

            for (i = N; i > 1; i--) 
            {
                Console.Write("Anak Ayam turun {0},", i);
                Console.Write(" mati satu tinggal {0}",i-1);
                Console.Write("\n");
            }   
            Console.WriteLine("Anak Ayam turun 1, mati satu tinggal induknya");
        }
    }
}
