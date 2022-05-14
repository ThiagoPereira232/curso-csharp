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
            int escolha = 1;

            switch(escolha)
            {
                case 1:
                    Console.WriteLine("opção 1");
                    break;
                case 2:
                    Console.WriteLine("opção 2");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("opção combinada");
                    break;
                default:
                    Console.WriteLine("opção default");
                    break;
            }

            Console.ReadKey();
        }
    }
}
