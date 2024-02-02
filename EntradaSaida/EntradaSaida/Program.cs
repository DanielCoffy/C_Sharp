using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaSaida
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            Console.WriteLine("Daniel Trindade Coffy");//método que mostra na tele e pula a linha
            Console.Write("Coffy"); //método que mostra na tela mas não pula a linha
            */

           // int codigo= Console.Read();// pegando o código da tecla EX.: quando digitado"a" aparece o código "97"
           // Console.WriteLine(codigo);

             string texto=Console.ReadLine();
            Console.WriteLine(texto);


            Console.ReadKey(); //aguarda digitarmos uma tecla
        }
    }
}
