using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine("Квадрат числа {0} равен {1}", i,i*i);
            }
            Console.ReadKey();
        }
    }
}
