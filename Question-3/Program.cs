using System;
using System.Collections.Generic;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            String n = Convert.ToString(Console.ReadLine());
            String vowels = "AaEeIiOoUu";
            List<String> voweLetters = new List<string>();
        
            for(int i = 0; i < n.Length; i++)
            {
                if(vowels.Contains(n[i]))
                {
                    voweLetters.Add(n[i]);
                }
            }
                foreach (var item in voweLetters)
                {
                    Console.WriteLine(item);
                }
            
        }
    }
}
