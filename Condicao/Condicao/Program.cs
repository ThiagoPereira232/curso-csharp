using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicao
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Condição simples
            int valor = 7;

            if (valor < 5)
            {
                Console.WriteLine("Condição verdadeira");
            }
            else
            {
                Console.WriteLine("Condição retornou falso");
            }
            #endregion



            Console.ReadKey();
        }
    }
}
