using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Inicio:
                Console.Clear();
                Console.Write("Digite o primeiro nuemro: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo nuemro: ");
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Escolha a operação (+, -, x, /)");
                char op = char.Parse(Console.ReadLine());

                double resultado = 0;

                switch (op)
                {
                    default:
                        Console.WriteLine("Erro, opção invalida");
                        break;
                    case '+':
                        resultado = num1 + num2;
                        Console.WriteLine("O resultado da soma é: " + resultado);
                        break;
                    case '-':
                        resultado = num1 - num2;
                        Console.WriteLine("O resultado da subtração é: " + resultado);
                        break;
                    case 'x':
                    case 'X':
                        resultado = num1 * num2;
                        Console.WriteLine("O resultado da multiplicação é: " + resultado);
                        break;
                    case '/':
                    case ':':
                        if(num2 == 0)
                        {
                            Console.WriteLine("Não é possivel dividir por 0");
                        }
                        else
                        {
                            resultado = num1 / num2;
                            Console.WriteLine("O resultado da divisão é: " + resultado);
                        }
                        break;
                }

                Console.Write("Continuar calculando (s/n)? ");
                char opcao = char.Parse(Console.ReadLine());

                if (opcao == 's' || opcao == 'S')
                    goto Inicio;
        }
    }
}
