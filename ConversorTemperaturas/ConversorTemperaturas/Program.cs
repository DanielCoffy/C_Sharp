using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f, k;

            Console.WriteLine("###CONVERSOSR DE TEMPERATURAS###");
            Console.Write("Insira a temperatura em Celsius: ");
            c=double.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------");
            // (C*9/5)+32=F
            f = (c * 9 / 5) + 32;

            // C+273,15=K
            k = c + 273.15;
            Console.WriteLine(c + " graus celsius= " + f + " graus fahrenheit");
            Console.WriteLine(c + " graus celsius= " + k + " graus kelvin");
            Console.WriteLine("---------------------------");
            Console.ReadKey();
        }
    }
}
