using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._12._2024
{
    internal class Program
    {
        //HomeWork(base)
        static string loan_approval(int balance)
        {
            if (balance <= 0) return "Кредит одобрен!";
            else return "У вас достаточно средств, кредит не нужен.";
        }
        static int deposit_withdrawal(int deposit,int balance)
        {
            return balance - deposit;
        }
        //HomeWork(pro)
        static double calculate_compound_interest(int balance, int proc, int years)
        {
            double it_proc = (1 + (proc/100)); 
            for(int i = 1; i < years; i++)
            {
                it_proc *= (1 + (proc / 100));
            }
            return balance * it_proc + balance;
        }
        static void Main(string[] args)
        {
            string a = Program.loan_approval(2000);
            int b = Program.deposit_withdrawal(300, 2000);
            double c = calculate_compound_interest(2000, 20, 5);
            Console.WriteLine($"В данный момент {a}. Советуем положить часть ваших денег под депозит, к примеру 300 денег, тогда у вас останется на руках {b}, а вскоре ваш депозит вырастит или в худшем случае ваши деньги останутся в целости.");
            Console.WriteLine($"А лучше советуем положить ваши деньги под процент в нашем банке, тогда через 5 лет ваш баланс будет составлять {c} денег.");
        }
    }
}
