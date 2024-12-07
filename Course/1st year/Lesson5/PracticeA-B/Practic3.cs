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
            //Практика A3
            int[] num = { 1, 2, 1, 4, 4, 1, 6, 7, 7, 7, 8 };
            Array.Sort(num);
            int[] copynum = new int[num.Length + 1];
            int max = 0;
            for(int i = 0; i < num.Length; i++)
            {
                int a = 0;
                if (i == 0 || num[i] != num[i - 1])
                {
                    for (int j = 0; j < num.Length; j++)
                    {
                        if (num[j] == num[i])
                        {
                            a++;
                        }
                        copynum[i + 1] = a;
                        if(max < a)
                        {
                            max = a;
                        }
                    }
                }               
            }
            for(int i = 0; i < copynum.Length; i++)
            {
                if (copynum[i] == max)
                {
                    Console.WriteLine($"{i}: {copynum[i]}");
                }
            }          
        }
    }
}
