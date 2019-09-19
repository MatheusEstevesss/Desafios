using System;

namespace Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade= 0;
            string oper;

            Console.WriteLine("Digite sua idade");
            idade= int.Parse(Console.ReadLine());
            oper= Console.ReadLine();

            Console.WriteLine($"{idade} * {12} = {idade * 12}");
            Console.WriteLine($"{idade} * {365} = {idade * 365}");

        }


    }
}
