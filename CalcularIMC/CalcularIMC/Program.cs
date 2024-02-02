using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o peso em Kg: ");
            double peso=double.Parse(Console.ReadLine());

            Console.Write("Informe a altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            if (imc < 20) 
            {
                Console.WriteLine("\nIMC=" + imc + "-> Abaixo do peso");
            }
            else if ((imc >=20) && (imc<=24))
            {
                Console.WriteLine("\nIMC=" + imc + "-> Peso normal");
            }
            else if ((imc>=25) && (imc<=29))  
            {
                Console.WriteLine("\nIMC=" + imc + "-> Acima do peso.");
            }
            else if ((imc >= 30) && (imc <= 34))
            {
                Console.WriteLine("\nIMC=" + imc + "-> Obeso.");
            }
            else
            {
                Console.WriteLine("\nIMC=" + imc + "-> Muito Obeso.");

            }

            Console.ReadKey();

        }
    }
}
