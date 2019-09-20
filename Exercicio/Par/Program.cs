using System;

namespace Par
{
    class Program
    {
        static void Main(string[] args)
        {
            double i=0;
            int func;
            do{
            Console.WriteLine("Digite um número:");
            i = double.Parse(Console.ReadLine());

            if ((i % 2) == 0){
                Console.WriteLine("Seu Número é Par!");
            }   else {
                Console.WriteLine("Seu número é impar");
            }
                Console.WriteLine("Aperte 1 para tentar novamente ou 2 para sair");
                func = int.Parse(Console.ReadLine());
            } while(func == 1);
        }
    }
}
