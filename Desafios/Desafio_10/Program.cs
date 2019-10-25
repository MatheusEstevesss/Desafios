using System;

namespace Desafio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int again;
            do
            {
            System.Console.WriteLine("Múltiplo de 3");
            System.Console.Write("Digite um número: ");
            int numero= int.Parse(Console.ReadLine());

            if (numero % 3 == 0){
                System.Console.WriteLine("\n Seu Número é um múltiplo de 3");
            } else {
                System.Console.WriteLine("\n   Seu Número não é multiplo de 3");
            }
                System.Console.Write("\n Digite 1 para tentar denovo ou 2 para sair: ");
                again = int.Parse(Console.ReadLine());
            }while( again == 1);
        }
    }
}