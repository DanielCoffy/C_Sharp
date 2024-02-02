using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicao
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Condição Simples
            /*
            int valor = 10;

            if (valor = 5)
            {
                Console.WriteLine("Condição verdadeira");
            }
            else
            {
                Console.WriteLine("Condição falsa");
            }
            */
            #endregion

            #region Condição Encadeada
            /*
            int valor = 25;
            if (valor<5)
            {
                Console.WriteLine("Valor menor que 5");
            }
            else if (valor>=5 && valor <10)
            {
                Console.WriteLine("valor maior ou igual a 5 e menor que 10");
            }
            else if (valor >=10 && valor<20)
            {
                Console.WriteLine("valor maior ou igual a 10 e menor que 20");
            }
            else
            {
                Console.WriteLine("Outro valor");
            }
            */
            #endregion

            #region Condicionais Aninhadas
            /*
            int numero = 13;

            if (numero > 5) 
            {
                Console.Write("O numero é maior que 5");

                if (numero % 2==0)
                {
                    Console.WriteLine(" e também é par.");
                }
                else
                {
                    Console.WriteLine(" e também é ímpar.");

                }
            }
            */
            #endregion

            int numero = 10;

            /*

            if (numero > 5) 
            {
                mensagem = "Maior que 5";
            }
            else
            {
                mensagem = "Menor que 5";

            }
            */

            //condição ? true : false;

            //string mensagem = numero > 5 ? "Maior que 5" : "Menor que 5";

            Console.WriteLine(numero > 5 ? "Maior que 5" : "Menor que 5");

           // Console.WriteLine(mensagem);


            Console.ReadKey();
        }
    }
}
