using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            Console.Write("Введи целое число больше ноля: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int sqN = N * N;
            int sum = 0;
            for (int i = 1; i < N+1; i++)
            {
                sum = sum + (i * 2 - 1);
                Console.WriteLine(sum);
            }
                Console.ReadKey();
        }
    }
}
