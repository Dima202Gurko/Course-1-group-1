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
            int[] a = { 1, 4, 6, 8 };
            int[] b = {2, 5, 7, 9 };
            int[] d = new int[8];
            int f = 0;
            for (int i = 0; i < a.Length; i++) 
            {
                d[i] = a[i];
                f++;               
            }
            for (int u = 0; u < b.Length; u++)
            {
                d[f + u] = b[u];
            }
            foreach (int i in d)
            {
                Console.WriteLine(i);
            }
            //2
            int[] nas = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Введите число для ротации:");
            int con = int.Parse(Console.ReadLine());
            for (int i = 0; i < con; i++)
            {
                int last = nas[nas.Length - 1];  
                for (int j = nas.Length - 1; j > 0; j--)
                    nas[j] = nas[j - 1];
                nas[0] = last;
            }
            foreach (int m in nas)
            {
                Console.WriteLine(m);
            }
        }
    }
}
