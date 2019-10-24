using System;

namespace ConversaoTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuBar = "+++++++++++++++++++++++++++++";
            double f,c;

            System.Console.WriteLine(menuBar);
            System.Console.WriteLine("||                         ||");
            System.Console.WriteLine("||  Conversão de Cº em Fº  ||");
            System.Console.WriteLine("||                         ||");
            System.Console.WriteLine(menuBar);

            System.Console.Write("Digite a temperatura em Cº: ");
            c = double.Parse(Console.ReadLine());

            f = ((1.8 * c) + 32);
            

            System.Console.Write($"Sua temperatura em Fahrenheit é: {f}");
        }
    }
}