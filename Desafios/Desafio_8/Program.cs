using System;

namespace Desafio_8
{
    class Program
    {
        static void Main(string[] args)
        {

            int l,c;
            System.Console.WriteLine("Triângulo Invertido");
            System.Console.WriteLine("Digite a altura do triângulo: ");
            int h = int.Parse(Console.ReadLine());

            for (l = 1; l <= h; l++){
                for (c = l; c <= 1; c++){
                    System.Console.WriteLine("*");
                }
            }
        }
    }
}
