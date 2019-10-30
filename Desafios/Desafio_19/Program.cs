using System;

namespace Desafio_19
{
    class Program
    {
        static void Main(string[] args)
        {   
            int x;

            System.Console.Write("Digite o tamanho do vetor: ");
            x = int.Parse(Console.ReadLine());

            int [] vetor = new int [x];

            for (int y=0; y < x; y++){
                System.Console.Write("Digite um valor: ");
                vetor [y] = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine("\nSeu vetor ");
            foreach (int num in vetor){
                System.Console.WriteLine($" {num} ");
            }
        }
    }
}