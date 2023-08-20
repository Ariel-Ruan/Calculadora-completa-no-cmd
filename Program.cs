using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_1
{
    internal class Program
    {
        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair}
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while(!escolheuSair)
            {
                Console.WriteLine("Bem Vindo ao projeto CALC,selecione uma das opções");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potencia\n6-Raiz\n7-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());
                Console.WriteLine(opcao);
              
                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:;
                        Sub();
                        break;
                    case Menu.Divisao:
                        Div();
                        break;
                    case Menu.Multiplicacao:
                        Mult();
                        break;
                    case Menu.Potencia:
                        Pot();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }
                Console.Clear();

            }
            
        }
        static void Soma()
        {
            Console.WriteLine("Soma de dois números: ");
            Console.WriteLine("Escolha o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao inicio: ");
            Console.ReadLine();
        }
        static void Sub()
        {
            Console.WriteLine("Subtração de dois números: ");
            Console.WriteLine("Escolha o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao inicio: ");
            Console.ReadLine();
        }
        static void Div()
        {
            Console.WriteLine("Divisão de dois números: ");
            Console.WriteLine("Escolha o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao inicio: ");
            Console.ReadLine();
        }
        static void Mult()
        {
            Console.WriteLine("Multiplicação de dois números: ");
            Console.WriteLine("Escolha o primeiro número: ");
            float a = (float)int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha o segundo número: ");
            float b = (float)int.Parse(Console.ReadLine());
            float resultado = a / b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao inicio: ");
            Console.ReadLine();
        }
        static void Pot()
        {
            Console.WriteLine("Potência de dois números: ");
            Console.WriteLine("Digite a base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            int expo = int.Parse(Console.ReadLine());
            double resultado = Math.Pow(baseNum, expo);
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao inicio: ");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine("Soma de dois números: ");
            Console.WriteLine("Escolha o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao inicio: ");
            Console.ReadLine();
        }
    }
}
