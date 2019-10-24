using System;

namespace Desafio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            System.Console.WriteLine("Digite o valor A: ");
            a = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o valor B: ");
            b = int.Parse(Console.ReadLine());

            c = b;
            b = a;
            a = c;

            System.Console.WriteLine($"O novo valor valor de A é: {a}");
            System.Console.WriteLine($"O novo valor valor de A é: {b}");
        }
    }
}
