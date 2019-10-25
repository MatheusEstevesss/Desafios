using System;

namespace Desafio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double pesoNovo;
            Console.WriteLine("Pesos");
            System.Console.Write("Digite seu peso na Terra: ");
            double peso = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Deseja saber seu peso em qual planeta ?");
            System.Console.WriteLine(" 1 - Mercúrio");
            System.Console.WriteLine(" 2 - Vênus");
            System.Console.WriteLine(" 3 - Marte");
            System.Console.WriteLine(" 4 - Júpiter");
            System.Console.WriteLine(" 5 - Saturno");
            System.Console.WriteLine(" 6 - Urano");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                pesoNovo = (peso * 0.37);
                System.Console.WriteLine($"\n Seu peso em Mercúrio é de {pesoNovo} Kg");
                break;

                case 2:
                pesoNovo = peso * 0.88; 
                System.Console.WriteLine($"\n Seu peso em Vênus é de {pesoNovo} Kg");
                break;

                case 3:
                pesoNovo = peso * 0.38;
                System.Console.WriteLine($"\n Seu peso em Marte é de {pesoNovo} Kg");
                break;

                case 4:
                pesoNovo = peso * 2.64;
                System.Console.WriteLine($"\n Seu peso em Júpiter é de {pesoNovo} Kg");
                break;

                case 5:
                pesoNovo = peso * 1.15;
                System.Console.WriteLine($"\n Seu peso em Saturno é de {pesoNovo} Kg");
                break;

                case 6:
                pesoNovo = peso * 1.17;
                System.Console.WriteLine($"\n Seu peso em Urano é de {pesoNovo} Kg");
                break;
            }

        }
    }
}
