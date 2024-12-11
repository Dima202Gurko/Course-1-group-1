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
            int Summa(int a, int b)
            {
                return a + b;
            }
            Console.WriteLine(Summa(2, 15));
            //2
            string Hello(string name)
            {
                return name;             
            }
            Console.WriteLine("Введите своё имя:");
            string nam = Console.ReadLine();
            Console.WriteLine(Hello($"Здравствуй, {nam}!"));
            //3
            int Max(int a, int b)
            {
                int x = 0;
                if(a > b)
                {
                    x = a;
                }
                else
                {
                    x = b;
                }
                return x;
            }
            Console.WriteLine(Max(2, 5));
            //4
            string Chet(int a)
            {               
                if( a % 2 == 0)
                {
                    return "true";
                }
                return "false";
            }
            Console.WriteLine(Chet(5));
            
            //5
            double Temper(double a)
            {
                double n = a * 1.8 + 32;
                return n;
            }
            //6 
            string Strock(string str)
            {
                string one = "";
                for (int i = str.Length -1; i >= 0; i--)
                {
                    one += str[i];
                }
                return one;
            }
            //7
            int Podschet(string a)
            {
                int b = a.Length;
                return b;
            }
            Console.WriteLine($"Количество символов = {Podschet("Привет")}");
            //8
            int Fact(int a)
            {
                int b = 1;
                for(int i = a; i > 0; i--)
                {
                    b *= i;
                }
                return b;
            }
            Console.WriteLine(Fact(5));
            //9
            string Prosto(int a)
            {
                int b = 0;              
                for (int i = 2; i < a; i++)
                {
                    if (a  % i == 0)
                    {
                        b++;
                    }
                }
                if(b == 0)
                {
                    return "Число является простым.";
                }
                else
                {
                    return "Число не является простым.";
                }
            }
            Console.WriteLine(Prosto(6));
            //10
            int Random(int a, int b)
            {
                Random random = new Random();
                return random.Next(a, b);
            }
            Console.WriteLine(Random(2, 25));

        }
    }
}
