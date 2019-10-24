using System;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, a, total;

            Console.WriteLine("Retângulo");
            System.Console.Write("\nDigite a base do seu retângulo: ");
            b = double.Parse(Console.ReadLine());

            System.Console.Write("\nDigite a altura do seu retângulo: ");
            a = double.Parse(Console.ReadLine());

            total = ((2 * b)+ (2 * a)); 
            System.Console.Write($"\nO Perímetro do seu retângulo é: {total}");

            total = (a * b);
            System.Console.Write($"\nA Área do seu retângulo é: {total}");

            total = Math.Sqrt(Math.Pow(a,2)+Math.Pow(b,2));
            System.Console.Write($"\nA diagonal do seu retângulo é:{total}");
        }
    }
}