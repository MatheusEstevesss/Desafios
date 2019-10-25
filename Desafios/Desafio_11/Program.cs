using System;
using System.Collections.Generic;
namespace Desafio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Ordem Alfabética");
            System.Console.Write("\nDigite o primeiro nome: ");
            string firstName = Console.ReadLine();
            System.Console.Write("\nDigite o segundo nome: ");
            string secondName = Console.ReadLine();

            List<string> lista = new List<string>();
            lista.Add(firstName);
            lista.Add(secondName);

            lista.Sort();

            System.Console.WriteLine("\nNomes em ordem alfabética");
            foreach (string item in lista){
                System.Console.WriteLine($"\n {item}");
            }
        }
    }
}