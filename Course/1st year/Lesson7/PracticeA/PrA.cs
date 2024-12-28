using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._12._2024
{
    internal class Program
    {
        //7
        static void Honoi(int q, char w, char e, char r)
        {            
            if (q >= 1)
            {
                Honoi(q - 1, w, r, e);
                Console.WriteLine($"Перемещаем диск с {w} стержня на {e} стержень");
                Honoi(q - 1, r, e, w);
            };
        }
        //8
        static void Mnoh(int[] mas, int ind, int[] mas1, int size)
        {
            if(ind == mas.Length)
            {
                Console.Write("{");
                for (int i = 0; i < size; i++)
                {
                    Console.Write($" {mas1[i]} ");
                }
                Console.WriteLine("}");
                return;
            }
            Mnoh(mas, ind + 1, mas1, size);
            mas1[size] = mas[ind];
            Mnoh(mas, ind + 1, mas1, size + 1);
        }
        //10
        static void Main(string[] args)
        {
            //1
            int b = int.Parse(Console.ReadLine());
            int Fact(int a)
            {
                if (a == 1)
                    return 1;
                return a * Fact(a - 1);
            }
            Console.WriteLine(Fact(b));
            //2
            int n = int.Parse(Console.ReadLine());
            int Fib(int fib)
            {
                if (n == 0)
                    return 0;
                if (fib <= 0)
                    return 1;
                return Fib(fib - 1) + Fib(fib - 2);
            }
            Console.WriteLine(Fib(n));
            //3
            string word = Console.ReadLine();
            string StrRev(string art)
            {
                if (art.Length > 0)
                {
                    return art[art.Length - 1] + StrRev(art.Substring(0, art.Length - 1));
                }
                else
                    return art;
            }
            Console.WriteLine(StrRev(word));
            //4
            int[] num = { 7, 9, 1, 5, 2, 8 };
            int MaxSum(int w)
            {
                int max = num[w];
                if (w == 0)
                {
                    return num[0];
                }
                return max + MaxSum(w - 1);
            }
            Console.WriteLine(MaxSum(num.Length - 1));
            //5
            Console.WriteLine("Первое число");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("Второе число");
            int d = int.Parse(Console.ReadLine());
            int NOD(int num1, int num2)
            {
                if (num2 == 0)
                    return num1;
                else
                    return NOD(num2, num1 % num2);
            }
            Console.WriteLine(NOD(l, d));
            //6
            string word1 = Console.ReadLine();
            string Proverk(string p)
            {
                if (StrRev(p) == word1)
                {
                    return p = "палиндром";
                }
                return p = "не палиндром";
            }
            Console.WriteLine($"Данное слово {Proverk(word)}");
            //7
            Program.Honoi(3, '1', '2', '3');
            //8
            int[] ms = { 2, 3, 4 };
            Program.Mnoh(ms, 0, new int[ms.Length], 0);
            //10
        }
    }
}
