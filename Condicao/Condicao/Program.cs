﻿using System;
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
            //int valor = 7;

            //if (valor < 5)
            //{
            //    Console.WriteLine("Condição verdadeira");
            //}
            //else
            //{
            //    Console.WriteLine("Condição retornou falso");
            //}
            #endregion

            #region Condição encadeada
            //int valor = 25;

            //if (valor < 5)
            //{
            //    Console.WriteLine("condição verdadeira");
            //}
            //else if (valor >= 5 && valor < 10)
            //{
            //    Console.WriteLine("condição alternativa 1");
            //}
            //else if (valor >= 10 && valor < 20)
            //{
            //    Console.WriteLine("condição alternativa 2");
            //}
            //else
            //{
            //    Console.WriteLine("condição alternativa final");
            //}
            #endregion

            #region Condição aninhada
            int numero = 13;

            if (numero > 5)
            {
                Console.Write("O número é maior que 5");

                if (numero % 2 == 0)
                {
                    Console.WriteLine(" e também é par.");
                }
                else
                {
                    Console.WriteLine(" mas não é par.");
                }
            }

            #endregion



            Console.ReadKey();
        }
    }
}
