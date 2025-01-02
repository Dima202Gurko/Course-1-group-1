using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._01._2025
{
    internal class Program
    {
        //Lesson7 PrA 10
        static void VariantMnosh(char[] mnosh, int a)
        {
            if(a == mnosh.Length - 1)
            {                
                Console.WriteLine(mnosh);
                return;
            }
            for(int i = a; i < mnosh.Length; i++)
            {
                char b = mnosh[a];
                mnosh[a] = mnosh[i];
                mnosh[i] = b;
                VariantMnosh(mnosh, a + 1);
                b = mnosh[a];
                mnosh[a] = mnosh[i];
                mnosh[i] = b;
            }
        }
        static void Main(string[] args)
        {
            //10
            string word = "qwe";
            char[] man = word.ToCharArray();
            Program.VariantMnosh(man, 0);
        }
    }
}
