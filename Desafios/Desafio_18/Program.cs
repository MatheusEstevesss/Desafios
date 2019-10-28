using System;

namespace Desafio_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            System.Console.Write("Digite um número para que apareça os números impares antes dele: ");
            int limite = int.Parse(Console.ReadLine());

            for (x = 1; x < limite; x += 2){
                System.Console.Write($"\t{x}");
            }
        }
    }
}
