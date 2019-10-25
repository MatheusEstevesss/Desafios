using System;
using System.Collections.Generic;

namespace Desafio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Número em ordem Crescente");
            System.Console.WriteLine("\n Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());

            System.Console.WriteLine("\n Digite um número: ");
            int n2 = int.Parse(Console.ReadLine());

            System.Console.WriteLine("\n Digite um número: ");
            int n3 = int.Parse(Console.ReadLine());

            List<int> lista = new List<int>();
            lista.Add (n1);
            lista.Add (n2);
            lista.Add (n3);

            lista.Sort();

            foreach (int item in lista){
                System.Console.WriteLine("Seus números em ordem crescente");
                System.Console.WriteLine($"\n{item}");
            }
        }
    }
}
