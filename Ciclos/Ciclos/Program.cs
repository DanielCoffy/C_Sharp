using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region While
            /*
            int valor = 0;

            while (valor<10) 
            {
                Console.WriteLine("O valoe é " + valor);
                valor++;
            }
            */
            #endregion

            #region Do-While
            /*
            int valor = 0;
            do
            {
                Console.WriteLine("O valor é " + valor);
                valor++;
            } while (valor<10);
            */
            #endregion

            #region For
            /*
            for (int i = 0,j=10;i<10;i++,j--)
            {
                Console.WriteLine("I=" + i+" e J="+j);
            }
            */
            #endregion

            #region Foreach
            /*
            string[] nomes = { "Daniel", "João", "Arthur", "Pedro" };
            
            foreach (string nome in nomes) 
            {
                Console.WriteLine("Nome: " + nome);
            }
            */
            #endregion

            Console.ReadKey();
        }
    }
}
