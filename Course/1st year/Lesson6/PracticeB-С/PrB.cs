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
            //Практика B-C
            int MaxMass(int[] nums, int start)
            {
                int maxSum = -1;
                int currentSum = 0;
                for (int i = 0; i <= nums.Length - start; i++)
                {
                   for(int j =0; j < start; j++)
                   {
                        currentSum += nums[j + i];
                   }
                   if(currentSum > maxSum)
                   {
                        maxSum = currentSum;
                   }
                    currentSum = 0;
                }
                return maxSum;
            }
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(MaxMass(num, 3));
        } //Как делать практику C не понял(вроде как не проходили)
    }
}
