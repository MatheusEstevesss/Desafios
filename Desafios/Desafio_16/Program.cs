using System;

namespace Desafio_16
{
    class Program
    {
        static void Main(string[] args)
        {   
            string choice;
            bool sair = false;
            do
            {
            System.Console.WriteLine("Vamos Calcular o Seu IMC (Indice de Massa Corporal)");
            System.Console.WriteLine("\nPor favor digite seu nome");
            string nome = Console.ReadLine();

            System.Console.WriteLine("\nPor Favor digite seu peso (kg)");
            double peso = double.Parse(Console.ReadLine());

            System.Console.WriteLine("\nPor Favor digite sua altura (m)");
            double altura = double.Parse(Console.ReadLine());

            double total = (peso / (altura * altura));
            System.Console.WriteLine($"Seu IMC é: {total}");

            if(total < 20){
                System.Console.WriteLine($"{nome} você está abaixo do peso");
            } else if (total >= 20 && total <= 25 ) {
                System.Console.WriteLine($"{nome} você está com o peso normal");
            } else if (total > 25 && total <= 30){
                System.Console.WriteLine($"{nome} você está com excesso de peso");
            } else if(total > 30 && total <=35){
                System.Console.WriteLine($"{nome} você está com obesidade, por favor para de comer");
            } else if (total > 35){
                System.Console.WriteLine($"{nome} você está com obesidade mórbida, aproveite seus últimos segundos na terra");
            }
                System.Console.WriteLine("\nDeseja tentar novamente (S/N) ?");
                choice = Console.ReadLine();

                if (choice == "n"){
                    sair = true;
                }
            } while(!sair);
        }
    }
}
