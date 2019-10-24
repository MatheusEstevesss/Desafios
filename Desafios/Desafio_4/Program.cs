using System;

namespace Desafio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int ten;
            System.Console.WriteLine("Vamos verificar se o seu número é par ou impar");
            do{
            System.Console.Write("Digite um número: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                System.Console.WriteLine("Seu número é Par!");
            } else {
                System.Console.WriteLine("Seu número é Impar!");
            }
             System.Console.WriteLine("Digite 1 para tentar denovo ou 2 para sair");
            ten = int.Parse(Console.ReadLine());
            }while( ten == 1 );
        }
    }
}
