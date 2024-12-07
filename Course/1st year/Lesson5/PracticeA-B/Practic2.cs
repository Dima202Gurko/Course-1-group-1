using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _30._11._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Практика A2
            int[] num = { 2, 3, 1, 3, 2, 4};
            Array.Sort(num);
            int a = 0;
            int b = 0;
            for(int i = 0; i < num.Length; i++)
            {
                for(int j = 0; j < num.Length;  j++)
                {
                    if (num[i] == num[j])
                    {
                        a++;                       
                    }
                    if (a == 1 && j == num.Length-1)
                    {
                        b++;
                    }
                    if(j == num.Length - 1)
                    {
                        a = 0;
                    }
                }
            }
            foreach(int i in num)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine($"\nКоличество уникальных элементов:{b}");
        }
    }
}
