using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeControle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Switch - case
            //int escolha = 1;

            //switch(escolha)
            //{
            //    case 1:
            //        Console.WriteLine("opção 1");
            //        break;
            //    case 2:
            //        Console.WriteLine("opção 2");
            //        break;
            //    case 3:
            //    case 4:
            //        Console.WriteLine("opção combinada");
            //        break;
            //    default:
            //        Console.WriteLine("opção default");
            //        break;
            //}
            #endregion

            #region goto

            Inicio:
            Console.Write("Escolha uma opção: ");
            int op = int.Parse(Console.ReadLine());
            int valor = 0;

            switch(op)
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

            Console.WriteLine("Valor final: " + valor);

            #endregion

            Console.ReadKey();
        }
    }
}
