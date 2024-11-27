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
            //Практика A
            int[] first = new int[5];
            first[0] = 34;
            first[3] = 52;
            first[4] = 42;
            //Практика B
            int[] num = { 1, 2, 4, 5, 6 };
            Console.WriteLine(num[2]);
            num[3] = 100;
            Console.WriteLine(num.Length);
            //Практика C
            int[] second = new int[4];
            int[] tap = { 1, 2, 3, 4, 5 };
            string[] main = { "Dima", "Ilia", "Olga", "Amgalan", "Slava" };
        }
    }
}
