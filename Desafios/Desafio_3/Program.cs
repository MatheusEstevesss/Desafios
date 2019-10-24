using System;

namespace Combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuBar = "+++++++++++++++++++++++++++++";
            double d, c;

            Console.BackgroundColor = ConsoleColor.Red;
            System.Console.WriteLine(menuBar);
            System.Console.WriteLine("||                         ||");
            System.Console.WriteLine("||       Combustível       ||");
            System.Console.WriteLine("||                         ||");
            System.Console.WriteLine(menuBar);
            Console.ResetColor();

            System.Console.Write("Digite a velocidade média (Km/h) de sua viagem: ");
            double v = double.Parse(Console.ReadLine());

            System.Console.Write("Digite o tempo gasto na viagem em minutos: ");
            double t = double.Parse(Console.ReadLine());

            d = ((t / 60) * v);

            c = d / 12;

            System.Console.WriteLine($"Você gastou um total de {c} litros");
        }
    }
}
