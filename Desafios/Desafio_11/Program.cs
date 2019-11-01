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
            System.Console.Write("\nDigite o segundo nome: ");
            string thirdName = Console.ReadLine();
            System.Console.Write("\nDigite o segundo nome: ");
            string fourthName = Console.ReadLine();
            System.Console.Write("\nDigite o segundo nome: ");
            string fifthName = Console.ReadLine();
            System.Console.Write("\nDigite o segundo nome: ");
            string sixthName = Console.ReadLine();
            System.Console.Write("\nDigite o segundo nome: ");
            string seventhName = Console.ReadLine();
            System.Console.Write("\nDigite o segundo nome: ");
            string eighthName = Console.ReadLine();
            System.Console.Write("\nDigite o segundo nome: ");
            string ninthName = Console.ReadLine();

            List<string> lista = new List<string>();
            lista.Add(firstName);
            lista.Add(secondName);
            lista.Add(thirdName);
            lista.Add(fourthName);
            lista.Add(fifthName);
            lista.Add(sixthName);
            lista.Add(seventhName);
            lista.Add(eighthName);
            lista.Add(ninthName);

            lista.Sort();

            System.Console.WriteLine("\nNomes em ordem alfabética");
            foreach (string item in lista){
                System.Console.WriteLine($"\n {item}");
            }
        }
    }
}