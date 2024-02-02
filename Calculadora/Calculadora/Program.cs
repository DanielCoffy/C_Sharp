using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inicio:
            Console.Clear();

            Console.Write("digite o primeiro número: ");
            double n1=double.Parse(Console.ReadLine());


            Console.Write("digite o segundo número: ");
            double n2 = double.Parse(Console.ReadLine());
            operacao:
            Console.Write("escolha a operação:(+ - x /): ");
            char op = char.Parse(Console.ReadLine());

            switch (op) 
            {
                case '+':
                    Console.WriteLine(n1 + n2);
                    break;
                case '-':
                    Console.WriteLine(n1 - n2);
                    break;
                case 'X':
                case 'x':                    
                    Console.WriteLine(n1 * n2);
                    break;
                case '/':
                case ':':
                    if (n2==0)
                    {
                        Console.WriteLine("Não é possível dividir por zero...");
                    }
                    {                        
                        Console.WriteLine(n1 / n2);
                    }
                    break;
                default:
                    Console.WriteLine("Operação inválida... Tente novamente...");
                    goto operacao;
            }

            Console.Write("Novo cálculo? (s / n)");
            string escolha=Console.ReadLine();

            if (escolha=="s" || escolha == "S")
            {
                goto Inicio;
            }

            Console.ReadKey();

        }
    }
}
