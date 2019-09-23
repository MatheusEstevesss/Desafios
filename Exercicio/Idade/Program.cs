using System;

namespace Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, total;
            Console.WriteLine("Qual o seu ano de nascimento ?");
            idade = int.Parse(Console.ReadLine());

            total = 2019 - idade;
            if(total <= 2){
                    Console.WriteLine("Recém nascido"); //Console.WriteLine recebe a informação digita pelo usuário. 
                    
                }
            if(total >=3 && total <=11){
                   Console.WriteLine("Criança");
               }
            if(total >=12 && total <=19){
                   Console.WriteLine("Adolescente");
               }

            if(total >=20 && total <=65){
                   Console.WriteLine("Adulto");
               }

            if (total >65){
                       Console.WriteLine("Idoso");
                }
                Console.WriteLine("Sua Idade é:", total);
        }
    }
}