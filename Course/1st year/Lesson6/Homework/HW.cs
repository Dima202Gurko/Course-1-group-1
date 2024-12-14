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
            //Дз1
            int Unic(int[] num)
            {
                Array.Sort(num);
                int[] copynum = new int[num.Length + 1];
                int max = 0;
                int elem = 0;
                for (int i = 0; i < num.Length; i++)
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
                            if (max < a)
                            {
                                max = a;
                            }
                        }
                    }
                }
                for (int m = 0; m < copynum.Length; m++)
                {
                    if (copynum[m] == max)
                    {
                        elem = m;
                    }
                }
                return elem;
            }
            int[] num1 = { 1, 2, 1, 4, 4, 1, 6, 7, 7, 8 };
            Console.WriteLine(Unic(num1));
            //Дз2
           
            int[,] matrix =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 },
            };
            int[,] transposed = Transposed(matrix);
            PrintMatrix(transposed);
            
            int[,] Transposed(int[,] matrix1)
            {
                int rows = matrix1.GetLength(0);
                int cols = matrix1.GetLength(1);
                int[,] result = new int[cols, rows];
                for(int i = 0; i <  rows; i++)
                {
                    for(int j = 0; j < cols; j++)
                    {
                        result[j, i] = matrix1[i, j];
                    }
                }
                return result;
            }
            void PrintMatrix(int[,] matrix2)
            {
                for (int i = 0; i < matrix2.GetLength(0); i++)
                {
                    for(int j = 0; j < matrix2.GetLength(1); j++)
                    {
                        Console.Write(matrix2[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        } 
    }
}
