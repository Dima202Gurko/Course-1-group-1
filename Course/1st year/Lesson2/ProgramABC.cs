using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._11._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Практика A
            Console.WriteLine("Привет введи своё имя, пожалуйста:");
            string a = Console.ReadLine();
            Console.WriteLine("Привет, " + a + "! Введи, пожалуйста, свой год рождения:");
            int b = int.Parse(Console.ReadLine());
            int age = 2024 - b;
            Console.WriteLine("В этом году тебе - " + age);            
            //Практика B
            Console.WriteLine("Введи наименование контакта:");
            string name = Console.ReadLine();
            Console.WriteLine("Введи номер телефона:");
            string nomer = Console.ReadLine();
            Console.Write("Имя контакта - " + name);
            Console.Write(" Номер контакта - " + nomer);
            
            //Практика B1
            Console.WriteLine("Введите число:");
            int namb = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ещё число:");
            int namb1 = int.Parse(Console.ReadLine());
            if(namb > namb1) 
            {
                Console.WriteLine(namb + " " + namb1);
            }
            else
            {
                Console.WriteLine(namb1 + " " + namb);
            }            
            //Практика C
            Console.WriteLine("Введи число:");
            int cas = int.Parse(Console.ReadLine());
            Console.WriteLine("Колличество сотен:" + cas/100);
            Console.WriteLine("Колличество десятков:" + cas % 100 / 10);
            Console.WriteLine("Колличество единиц:" + cas % 10);
        }
    }
}
