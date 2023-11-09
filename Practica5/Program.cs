using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    public class Program
    {
        static void Main(string[] args)
        {

      
            Console.WriteLine("Введите X:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Y:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Z:");
            double z = Convert.ToDouble(Console.ReadLine());
            
            double a= Math.Abs(Math.Cos(x) + Math.Cos(y));

            double b = 1 + 2 * Math.Pow(Math.Sin(y), 2);

            double c = (1 + z + Math.Pow(z, 2) / 2 + Math.Pow(z, 3) / 3 + Math.Pow(z, 4) / 4);

            double W = Math.Pow(a, b) * c;
            Console.WriteLine("W = {0}", W);
            Console.ReadLine();
        }
    }
}
