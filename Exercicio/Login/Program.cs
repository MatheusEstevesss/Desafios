using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string login, senha;

            Console.WriteLine("Faça Seu Login");
        
            Console.WriteLine("Digite seu Login");
            login = Console.ReadLine();

            Console.WriteLine("Digite sua senha");
            senha = Console.ReadLine();

            if (login=="admin" && senha=="admin"){
                Console.WriteLine("Parabéns, você é um adm");
            } else { 
                Console.WriteLine("Você é alguem!");
            }
        }
    }
}
