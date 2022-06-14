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
            string[] palavras = { "Victor", "Lima", "Guia do prog", "Formaçãõ", "Curso de C#" };

            for (int i = 0; i < palavras.Length; i++)
            {
                Console.WriteLine(palavras[i]);
            }

            for(int a = palavras.Length -1; a >= 0; a--)
            {
                Console.WriteLine(palavras[a]);
            }

            Console.ReadLine();
            
        }

        /*
         string[] palavras = { "Victor", "Lima", "Guia do prog", "Formaçãõ", "Curso de C#" };
            
            foreach(string palavra in palavras)
            {
                Console.WriteLine(palavra);
            }
            Console.ReadLine();
         */

        /*
         int contador = 0;

            while(contador <= 4)
            {
                Console.WriteLine("Número contador em: " + contador);
                contador++;
            }

            int contador2 = 0;
            do
            {
                Console.WriteLine("do While!");
                contador2++;
            }while(contador2 <= 10);

            Console.WriteLine("FIM DA LINHA!");
            Console.ReadLine();
         */

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
