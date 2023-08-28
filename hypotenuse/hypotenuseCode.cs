using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hypotenuse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o lado A: ");
            //user input
            double A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o lado B: ");
            //user input
            double B = Convert.ToDouble(Console.ReadLine());

            double x = Math.Sqrt((Math.Pow(A, 2)) + (Math.Pow(B, 2)));
            // x = raiz quadrada de a elevado a dois mais b elevado a dois

            Console.WriteLine("A hipotenusa é " + x);

            Console.ReadKey();
        }
    }
}
