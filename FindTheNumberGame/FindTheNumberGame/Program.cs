using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace FindTheNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите начальное число: ");
            int a;
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите конечное число: ");
            int b;
            b = Convert.ToInt32(Console.ReadLine());

            if (b > a)
            {
                (a,b) = (b,a);
            }
        }
    }
}
