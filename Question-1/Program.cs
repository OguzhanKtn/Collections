using System;
using System.Collections.Generic;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> prime = new List<int>();
            List<int> nonPrime = new List<int>();


            for (int i = 0; i < 20; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                while (n < 0)
                {
                    Console.Write("Lutfen pozitif bir tam sayi giriniz :");
                    n = Convert.ToInt32(Console.ReadLine());
                }

                if (n % 2 == 1)
                {
                    nonPrime.Add(n);
                }
                else
                {
                    prime.Add(n);
                }
            }
            prime.Sort();
            prime.Reverse();
            nonPrime.Sort();
            nonPrime.Reverse();
            Console.WriteLine("Asal sayilar :");
            foreach (var item in prime)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Asal olmayan sayilar :");
            foreach (var item in nonPrime)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Asal olan dizinin eleman sayisi : " + prime.Count);
            
            int a = 0;
            foreach (var item in prime)
            {
                a += item;
            }
            Console.WriteLine("Asal dizinin ortalamasi : " + a / prime.Count);
            
            Console.WriteLine("Asal olmayan dizinin eleman sayisi : " + nonPrime.Count);

            int b = 0;
            foreach (var item in nonPrime)
            {
                b += item;
            }
            Console.WriteLine("Asal olmayan dizinin ortalamasi : " + b / nonPrime.Count);
        }
    }
}
