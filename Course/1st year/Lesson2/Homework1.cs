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
            //Дз 1
            Console.WriteLine("Введите число:");
            int namb = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ещё число:");
            int namb1 = int.Parse(Console.ReadLine());
            int sum = namb + namb1;
            Console.WriteLine("Сумма равна " + sum);
                 
        }
    }
}
