using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;

            while(contador < 4)
            {
                Console.WriteLine("Número contador em: " + contador);
                contador++;
            }

            Console.ReadLine();
            
        }

        /*
         * enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar }
         * 
         static void Enum()
        {
                Console.WriteLine("Selecione uma das opções abaixo: ");
                Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
                int index = int.Parse(Console.ReadLine());
                Opcao opcaoSelecionada = (Opcao)index;

                switch (opcaoSelecionada)
                {
                    case Opcao.Criar:
                        Console.WriteLine("Escreva algo para imprimir.");
                        string texto = Console.ReadLine();
                        Console.WriteLine(texto);
                        break;
                    case Opcao.Deletar:
                        Console.WriteLine("Escreva algo para imprimir");
                        string texto2 = Console.ReadLine();
                        Console.WriteLine(texto2);
                        break;
                    case Opcao.Editar:
                        Console.WriteLine("Escreva algo para imprimir");
                        string texto3 = Console.ReadLine();
                        Console.WriteLine(texto3);
                        break;

            }

            Console.ReadLine();   
        }
         */

        /*static void Switch()
        {
            Console.Write("Escreva sua cor favorita: ");
            string cor = Console.ReadLine();

            switch (cor)
            {
                case "Vermelho":
                    Console.WriteLine("Sua cor favorita é Vermlho");
                    break;
                case "Azul":
                    Console.WriteLine("Sua cor favorita é Azul");
                    break;
                default:
                    Console.WriteLine("Não consegui identificar");
                    break;
            }

            Console.ReadLine();
        }*/

        /*static void Array()
        {
            string[] produtos =
            {
                "LOL",
                "FIFA",
                "Minecraft",
                "League",
                "Portal"
            };

            Console.WriteLine(produtos[0]);

            Console.ReadLine();

        }*/
    }
}
