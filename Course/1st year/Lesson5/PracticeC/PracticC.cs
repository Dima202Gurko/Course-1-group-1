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
            //Практика C
            int[] num = { 3, 2, 0, 5, 1, 0, 1 };
            bool one = false;
            int a = 0;
            int prov = 0;
            int b = 0;
            for (int i = 0; i < num.Length;)
            {
                prov = num[i];
                if (prov == 0)
                {
                    i = num.Length;
                    b++;
                }
                a = i + prov;
                if (a >= num.Length - 1 && b == 0)
                {
                    one = true;
                }
                i = a;
            }
            if (one == true)
            {
                Console.WriteLine("Поздравляю! Данный массив можно пройти!");
            }
            else
            {
                Console.WriteLine("Увы:( Данный массив невозможно пройти.");
            }
        }
    }
}
