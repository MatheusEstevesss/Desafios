using System;

namespace Desafio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lados de um triângulo!");
            System.Console.WriteLine("Digite o primeiro valor: ");
            double n1 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o segundo valor: ");
            double n2 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o terceiro valor: ");
            double n3 = double.Parse(Console.ReadLine());

            if ((n1 < (n2 + n3)) && (n1 > (n2 - n3)) && (n2 < (n3 + n1)) && (n2 > (n3 - n1)) && (n3 < (n1 + n2)) && (n3 > (n1 - n2))){
                System.Console.WriteLine("Esses valores podem ser de um Triângulo!");
            } else {
                System.Console.WriteLine("Esses valores não podem ser de um Triângulo!");
            }
        }
    }
}
