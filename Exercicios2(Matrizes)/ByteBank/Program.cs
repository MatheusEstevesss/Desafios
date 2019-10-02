using System;
using ByteBank.Models;
namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, cpf, email, senha;

            Cliente cliente = new Cliente();
            
            System.Console.WriteLine("Byte Bank");

            System.Console.WriteLine();
            Console.Write("Digite seu nome completo: ");
            nome = Console.ReadLine();
                        
            System.Console.WriteLine();
            System.Console.Write("Digite seu CPF: ");
            cpf = Console.ReadLine();
            
            System.Console.WriteLine();
            System.Console.Write("Digite seu email: ");
            email = Console.ReadLine();  
            
            System.Console.WriteLine();
            System.Console.Write("Digite sua senha: (Deverá conter mais de 6 e menos de 16 digitos)");
            senha = Console.ReadLine();  

            if ((senha < 6) && (senha > 16)){
                
            }
        }
    }
}
