using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double p, S;
            Console.WriteLine("Введите значение а:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение c:");
            c = Convert.ToDouble(Console.ReadLine());
            p = (a + b + c) / 2;
            S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Ответ " + S);
            Console.ReadKey();
        }
    }
}
    