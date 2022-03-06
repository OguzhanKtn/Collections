using System;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi = new int[20];
            int n;
            for(int i = 0; i<20; i++)
            {
                 n = Convert.ToInt32(Console.ReadLine());
                 sayiDizisi[i] = n;
            }
           Array.Sort(sayiDizisi);

            int[] enKucuk = {sayiDizisi[0],sayiDizisi[1],sayiDizisi[2]};
            int[] enBuyuk = {sayiDizisi[17],sayiDizisi[18],sayiDizisi[19]};

            int sum1 = 0;
            int sum2 = 0;

            foreach (var item in enKucuk)
            {
                sum1 += item;
            }
            foreach (var item in enBuyuk)
            {
                sum2 += item;
            }

            float enKucukOrt = sum1 / enKucuk.Length;
            float enBuyukOrt = sum2 / enBuyuk.Length;
            float toplamOrt = enBuyukOrt + enKucukOrt;
            Console.WriteLine("En kucuk sayilarin ortalamasi : "+ enKucukOrt);
            Console.WriteLine("En buyuk sayilarin ortalamasi : "+ enBuyukOrt);
            Console.WriteLine("Ortalamalarin toplami : "+ toplamOrt);
            
        }
    }
}
