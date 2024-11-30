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
            //1
            int summa = 0;
            int[] numbers = { 1, 2, 3, 6, 4 };
            for (int i = 0; i < numbers.Length; i++)
            {
                summa = summa + numbers[i];

                if (i == numbers.Length - 1)
                {
                    Console.WriteLine(summa);
                }

            }
            //2
            int[] nam = { 1, -9, 300, 45, 15 };
            int max = nam[0];
            for (int i = 1; i < nam.Length; i++)
            {
                if (nam[i] > max)
                {
                    max = nam[i];
                }
            }
            Console.WriteLine(max);
            //3
            int[] rev = { 1, 2, 3, 4, 5 };
            Array.Reverse(rev);
            foreach (int i in rev)
            {
                Console.WriteLine(i);
            }
            //4
            int[] ch = { 9, 24, 36, 666, 52, 42, 69, 938 };
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] % 2 == 0)
                {
                    Console.WriteLine(ch[i]);
                }
            }
            //5
            int[] nat = { -23, -42, 3, 55, -63 };
            int st = 0;
            for (int i = 0; i < nat.Length; i++)
            {
                if (nat[i] < 0)
                {
                    st++;
                }
            }
            Console.WriteLine(st);
            //6
            int[] a = { 9, 0, 3, 2, 6 };
            Console.WriteLine("Введите требуемое число:");
            int b = int.Parse(Console.ReadLine());
            bool art = false;
            for(int i = 0; i < a.Length ; i++)
            {
                if (a[i] == b)
                {
                    art = true;
                }              
            }
            if (art == true)
            {
                Console.WriteLine($"Число {b} найдено в массиве");
            }
            else if (art == false)
            {
                Console.WriteLine($"К сожалению, число {b} не найдено в массиве");
            }
            //7
            int[] car = { 3, 7, 45, 28, 0, 87 };
            for (int i = 0; i < car.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(car[i]);
                }
            }
            //8
            int[] mer = { -1, 2, -3, 4, -5, 6 };
            int max1 = mer[0];
            int min1 = mer[0];
            for (int i = 1; i < mer.Length; i++)
            {
                if (mer[i] > max1)
                {
                    max1 = mer[i];
                }
                if (mer[i] < min1)
                {
                    min1 = mer[i];
                }
            }
            Console.WriteLine(max1);
            Console.WriteLine(min1);
            //9
            int[] sor = { 23, 2, 34, 4, -1 };
            Array.Sort(sor);
            foreach (int f in sor)
            {
                Console.WriteLine(f);
            }
            //10
            int[] nul = { 1, -2, 3, -4, 5, -6 };
            for (int i = 0; i < nul.Length; i++)
            {
                if (nul[i] > 0)
                {
                    Console.WriteLine(nul[i]);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
