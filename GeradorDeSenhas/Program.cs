using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Xml;

namespace GeradorDeSenhas
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            Menu();

            }

        public static void Menu()
            {
            Console.WriteLine("Bem vindo ao Gerador de Senhas do C#!");
            Console.WriteLine("---------------------------------------------------------------------------------");

            Console.WriteLine("Este programa gerará senhas para você, de acordo com as opções que você escolher.");
            Console.WriteLine("");
            Console.WriteLine("Escreva os itens solicitados, copie sua senha ou a tenha em arquivo .txt !");
            Console.WriteLine("---------------------------------------------------------------------------------");

            Console.WriteLine("1 - Criar nova senha");
            Console.WriteLine("2 - Verificar senhas anteriormente criadas");
            Console.WriteLine("Pressione qualquer caractere para sair.");
            Console.WriteLine("");
            Console.Write("Digite o que deseja fazer: ");
            int.TryParse(Console.ReadLine(), out int opcao);
            switch (opcao)
                {
                case 1:
                    Thread.Sleep(800);
                    ObterDados();
                    break;
                case 2:

                    break;
                default:
                    Console.WriteLine("");
                    Console.Write("Encerrando aplicação");
                    for (int i = 0; i <= 4; i++)
                        {
                        Console.Write(" . ");
                        Thread.Sleep(400);
                        }
                    Console.WriteLine("");
                    System.Environment.Exit(0);
                    break;
                }

            }

        public static void ObterDados()
            {
            Console.Clear();

            int qtdCaracteres = 0;
            while (qtdCaracteres < 8)
                {
                Console.Write("Digite a quantidade de caracteres que você deseja em sua senha (Mín 8): ");
                int.TryParse(Console.ReadLine(), out qtdCaracteres);

                if (qtdCaracteres < 8)
                    {
                    Console.WriteLine("Digite um número válido, tente novamente.");
                    Console.WriteLine("");
                    }
                }
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("");
            bool qtdCaracteres2;
            if (qtdCaracteres == 1)
                {
                qtdCaracteres2 = true;
                }
            else
                {
                qtdCaracteres2 = false;
                }

            int caractereNum = 0;
            while (caractereNum != 1 && caractereNum != 2)
                {
                Console.WriteLine("Deseja caracteres numéricos?");
                Console.WriteLine("1 - SIM");
                Console.WriteLine("2 - NÃO");
                Console.WriteLine("");
                Console.Write("Digite sua resposta: ");
                int.TryParse(Console.ReadLine(), out caractereNum);
                switch (caractereNum)
                    {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("Ótimo, sua senha será muito segura!");
                        break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("Você quem sabe, sua senha poderá ficar insegura!");
                        break;
                    default:
                        Console.WriteLine("");
                        Console.WriteLine("Digite um número válido, tente novamente.");
                        break;
                    }
                }
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("");
            bool caractereNum2;
            if (caractereNum == 1)
                {
                caractereNum2 = true;
                }
            else
                {
                caractereNum2 = false;
                }

            int caractereEspecial = 0;
            while (caractereEspecial != 1 && caractereEspecial != 2)
                {
                Console.WriteLine("Deseja caracteres especiais?");
                Console.WriteLine("1 - SIM");
                Console.WriteLine("2 - NÃO");
                Console.WriteLine("");
                Console.Write("Digite sua resposta: ");
                int.TryParse(Console.ReadLine(), out caractereEspecial);
                switch (caractereEspecial)
                    {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("Perfeito, quanto mais segurança melhor!");
                        break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("Você quem sabe, sua senha poderá ficar insegura!");
                        break;
                    default:
                        Console.WriteLine("");
                        Console.WriteLine("Digite um número válido, tente novamente.");
                        break;
                    }
                }
            Console.WriteLine("");
            bool caractereEspecial2;
            if (caractereEspecial == 1)
                {
                caractereEspecial2 = true;
                }
            else
                {
                caractereEspecial2 = false;
                }
            }
        }
    }
