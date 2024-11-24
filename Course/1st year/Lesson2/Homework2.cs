using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _23._11._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дз 2
            int a = 21;
            bool var = true;
            bool var1 = true;
            Console.WriteLine("Я загадал число. Попробуй его отгадать, у тебя 3 попытки:");
            int b = int.Parse(Console.ReadLine());
            if (b < a)
            {
                Console.WriteLine("Неправильно! Больше");
            }
            else if (b > a)
            {
                Console.WriteLine("Неправильно! Меньше");

            }
            else
            {
                Console.WriteLine("Правильно! Молодец!");
                var = false;
            }

            if (var)
            {
                Console.WriteLine("Попробуй ещё раз! Осталось 2 попытки");
                b = int.Parse(Console.ReadLine());
                if (b < a)
                {
                    Console.WriteLine("Неправильно! Больше");
                    var1 = false;
                }
                else if (b > a)
                {
                    Console.WriteLine("Неправильно! Меньше");
                    var1 = false;
                }
                else
                {
                    Console.WriteLine("Правильно! Молодец!");

                }
            }
            if (!var1)
            {
                Console.WriteLine("Попробуй ещё раз! Осталось 1 попытка");
                b = int.Parse(Console.ReadLine());
                if (b < a)
                {
                    Console.WriteLine("Неправильно! Ты проиграл. Ответ 21.");
                }
                else if (b > a)
                {
                    Console.WriteLine("Неправильно! Ты проиграл. Ответ 21.");

                }
                else
                {
                    Console.WriteLine("Правильно! Молодец!");
                }
            }

        }
    }
}
