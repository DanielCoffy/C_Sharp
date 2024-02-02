using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Estrutura de controle 
            /*
            int escolha = 5;

            switch (escolha)
            {                
                case 1:
                    Console.WriteLine("Opção 1");
                    break;
                case 2:
                    Console.WriteLine("Opção 2");

                    break;
                case 3:
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Opção combinada");

                    break;
                default:
                    Console.WriteLine("Opção Defaut");
                    break;

            }
            */
            #endregion

            Inicio:
            Console.Write("Escolha uma opção:");
            int op = int.Parse(Console.ReadLine());
            int valor = 0;

            switch (op)
            {
                case 1:
                    valor += 100;
                    break;
                case 2:
                    valor += 50;
                    goto case 1;
                default:
                    goto Inicio;
            }

            Console.WriteLine("Valor final " + valor);

            Console.ReadKey();

        }
    }
}
