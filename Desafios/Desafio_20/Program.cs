using System;
using System.Collections.Generic;

namespace Desafio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Impar e Par dentro de um vetor");

            int [] vetor = new int [10];    
            Random random = new Random();

            for (int x = 0; x < 10; x++){
                vetor[x] = random.Next(1, 100);
            }

            List<int> par = new List<int>();
            List<int> impar = new List<int>();

            for (int y = 0; y < 10; y++){
                if (vetor[y] % 2 == 0){
                    par.Add (vetor[y]);
                } else {
                    impar.Add (vetor[y]);
                }
            }

            System.Console.Write("Números pares: ");
                foreach (int num in par){
                    System.Console.Write($"\t{num}");
                }

            System.Console.Write("\nNúmeros impares: ");
                foreach (int num in impar){
                    System.Console.Write($"\t{num}");
                }
        }
    }
}