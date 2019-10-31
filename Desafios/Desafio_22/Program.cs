using System;

namespace Desafio_22
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("+++++   Soma das Matrizes   +++++");

            int [,] num = new int [3 , 3];
            Random random = new Random();

            for (int x = 0; x < 3; x++){
                for (int y = 0; y < 3; y++){
                    num [x , y] = random.Next(1, 100);
                    System.Console.WriteLine($"Sua Matriz é: {num [x , y]}");
                }
            }

            int soma = num [0,0] + num [0,1] + num [1,0] + num [0,2] + num [2,0] + num [1,1] + num [1,2] + num [2,2];

            
            System.Console.WriteLine($"A soma dos números da matriz é: {soma}");
        }
    }
}
