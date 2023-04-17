using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = -2.235;
            double y = 2.23;
            double z = 15.221;
            double f = 39.669;
            double f = Math.Exp(Math.Abs(x - y) * Math.Pow(Math.Abs(x - y), x + y) / (Math.Atan(x) + Math.Atan(z) + Math.Pow(Math.Pow(x, 6), 1.0 / 3.0) + Math.Pow(Math.Log(y), 2)));
            Console.WriteLine("Получилось число: ");
            Console.WriteLine(f);
        }
    }
}