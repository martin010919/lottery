using System;

namespace lottomegadott_szamokkal
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = 77;
            int s2 = 15;
            int s3 = 44;
            int s4 = 69;
            int s5 = 26;
            Console.Write("A megtett számok:{0} {1} {2} {3} {4} ", s1, s2, s3, s4, s5);
            Console.WriteLine("\nE heti lottó számok: ");
            Random r = new Random();
            ///****///
            int talalat = 0;
            int szam;
            for (int i = 0; i < 5; i++)
            {
                szam = r.Next(1, 91);
                if (szam == s1 || szam == s2 || szam == s3 || szam == s4 || szam == s5)
                {
                    talalat++;
                }


                Console.WriteLine(" {0}", szam);

            }
            Console.Write("\n Találat: " + talalat);
        }
    }
}


