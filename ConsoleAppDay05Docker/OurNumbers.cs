using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay05Docker
{
    public class OurNumbers
    {
        public static void Tables(int num)
        {
            Console.WriteLine($"Table of {num}");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num*i}");
                Thread.Sleep(500);
            }
        }
        public static void Counting(int lnum)
        {
            Console.WriteLine($"Count from 1 to {lnum}");
            for(int i = 1;i <= lnum; i++)
            {
                Console.Write($"{i}\t");
                Thread.Sleep(500);
            }
            Console.WriteLine();
        }
    }
}
