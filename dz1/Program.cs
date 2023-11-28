using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение X: ");
            double x = double.Parse(Console.ReadLine());
            double S = 0;
            double A = 10/x;
            int n = 0;
            const double E = 0.001;
            do
            {
                S += A;
                n++;
                A = A * 1/n;
            }
            while (A >= E);
            Console.WriteLine($"Сумма: {S:f6} Число итераций: {n}");
        }
    }
}
