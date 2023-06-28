using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int c = 0;
            var mas = new List<int>();
            Console.WriteLine("Введите длину списка:");
            int list_len = Convert.ToInt32(Console.ReadLine());
            while(i < list_len)
            {
                Console.WriteLine("Введите элемент списка");
                int b = Convert.ToInt32(Console.ReadLine());
                mas.Add(b);
                i++;
            }
            foreach(int a in mas)
            {
                c = c + a;
            }
            Console.WriteLine(c / mas.Count());
            Console.WriteLine((double)c / mas.Count());
            Console.WriteLine(Math.Round(Convert.ToDecimal(c) / mas.Count()));
        }
    }
}
