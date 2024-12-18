using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._12._2024
{
    internal class Program
    {
        static void QuickSort(int[] arr, int st, int en)
        {
            if (st < en)
            {
                int pivot = arr[en];
                int i = (st - 1);

                for (int j = st; j < en; j++)
                {
                    if (arr[j] < pivot)
                    {
                        i++;
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                int tempPivot = arr[i + 1];
                arr[i + 1] = arr[en];
                arr[en] = tempPivot;

                int pi = i + 1;

                QuickSort(arr, st, pi - 1);
                QuickSort(arr, pi + 1, en);
            }
        }
        static void Main(string[] args)
        {            
            int[] mas = { 1, 9, 3, 6 };
            Program.QuickSort(mas, 0, mas.Length - 1);
            foreach(int a in mas)
            {
                Console.WriteLine(a);
            }
        }
    }
}
