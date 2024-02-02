using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Operadores Aritimeticos
            /*
            int n1 = 15;
            int n2 = 2;
            //int resultado=n1 + n2;

            

            Console.WriteLine(n1+n2);
            Console.WriteLine(n1 - n2);
            Console.WriteLine(n1 * n2);
            Console.WriteLine(n1 / n2);
            Console.WriteLine(n1 % n2);
            */
            #endregion

            #region Precedencia Operadores
            /*
            int n1 = 100;
            int n2 = 10;
            int n3 = 5;

            int res = (n1 + n2) * n3/2;

            Console.WriteLine(res);
            */
            #endregion

            #region Incremento Decremento
            /*
            int n1 = 10;

            //n1 = n1 + 1;

            Console.WriteLine(n1--);
            Console.WriteLine(n1);
            */
            #endregion

            #region Concatenação
            /*
            string nome = "Daniel ";
            string sobrenome = "Coffy";
            string nomeCompleto = nome + sobrenome;
            Console.WriteLine(nomeCompleto);
            */
            #endregion

            #region Atribuição
            //int n1 = 10;
            //n1 = n1 + 20;
            //n1 += 20;
            //n1 -= 2;
            //n1 *= 3;
            //n1 /= 2;
            //n1 %= 2;

            //string nome = "Daniel";
            //nome += " Coffy";
            #endregion

            #region Igualdade
            /*
            bool res = 100 == (50 * 2);
            bool res2 = (200 / 2) != (100 + 100);
            string nome = "Daniel";
            bool res3 = nome != "Lucas";
            */
            #endregion

            #region Relacionais
            /*
            bool res = 100 < 50 * 2;
            bool res = 100 + 25 > 50 * 2;
            bool res = 100 <= 50 * 2;
            bool res = 75 >= 50;
            */
            #endregion

            #region Operadores Lógicos
            /*
            bool res1 = 100 > 50;
            bool res2 = 50 == 50;

            bool final = res1 && res2;
            bool final2 = res1 || res2;
            */
            #endregion



            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
