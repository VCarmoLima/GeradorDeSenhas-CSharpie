using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GeradorDeSenhas
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            Console.WriteLine("Bem vindo ao Gerador de Senhas do C#!");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Este programa gerará senhas para você, de acordo com as opções que você escolher.");
            Console.WriteLine("");
            Console.WriteLine("Escreva os itens solicitados, copie sua senha ou a tenha em arquivo .txt !");
            Thread.Sleep(10000);
            Menu();
            }

        public static void Menu()
            {
            Console.Clear();
            Console.WriteLine("");
            }
        }
    }
