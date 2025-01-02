using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._01._2025
{
    internal class Program
    {
        //Lesson6 PrC
        static void VariantNum(int[] num, int a)
        {
            if(a == num.Length - 1)
            {
                foreach(int i in num)
                {
                    Console.WriteLine(i + " ");
                }
                Console.WriteLine("\n");
                return;
            }
            for(int i = a; i < num.Length; i++)
            {
                int b = num[a];
                num[a] = num[i];
                num[i] = b;
                VariantNum(num, a + 1);
                b = num[a];
                num[a] = num[i];
                num[i] = b;
            }
        }
        static void Main(string[] args)
        {
            //PrC
            int[] man = { 1, 4, 7, 9 };
            Program.VariantNum(man, 0);
        }
    }
}
