﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colecao
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Vetores
            /*
            int numero = 0;
            int[] numeros= new int[5];

            numeros[0] = 10;
            numeros[1] = 20;
            numeros[2] = 30;
            numeros[3] = 40;
            numeros[4] = 50;

            numeros[2] = 55;

            string[] nomes= { "Daniel", "Trindade", "Coffy" };


            Console.WriteLine(numeros[2]);
            Console.WriteLine(nomes[1]);
            */
            #endregion

            int[,] numeros = new int[2, 3];

            numeros[0, 0] = 10;
            numeros[0, 1] = 20;
            numeros[0, 2] = 30;

            numeros[1, 0] = 40;
            numeros[1, 1] = 50;
            numeros[1, 2] = 60;

            Console.Write("[" + numeros[0, 0] + "]");
            Console.Write("[" + numeros[0, 1] + "]");
            Console.Write("[" + numeros[0, 2] + "]");
            Console.WriteLine();
            Console.Write("[" + numeros[1, 0] + "]");
            Console.Write("[" + numeros[1, 1] + "]");
            Console.Write("[" + numeros[1, 2] + "]");
            Console.WriteLine();
            string[,] nomes =
            {
                {"Daniel", "Andressa", "Maria" },
                {"Carlos", "Flávio", "Arthur" }
            };
            Console.WriteLine(nomes[0,1]);


            Console.ReadKey();

        }
    }
}
