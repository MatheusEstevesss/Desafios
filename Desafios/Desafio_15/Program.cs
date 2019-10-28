using System;
using System.Collections.Generic;

namespace Desafio_15
{
    class Program
    {
        static void Main(string[] args)
        {   
            int i = 0;
            bool sair = false;
            string choice;
            Dictionary<int, string> meses = new Dictionary<int, string>();
                meses.Add (1, "Janeiro");
                meses.Add (2, "Fevereiro");
                meses.Add (3, "Marco");
                meses.Add (4, "Abril");
                meses.Add (5, "Maio");
                meses.Add (6, "Junho");
                meses.Add (7, "Julho");
                meses.Add (8, "Agosto");
                meses.Add (9, "Setembro");
                meses.Add (10, "Outubro");
                meses.Add (11, "Novembro");
                meses.Add (12, "Dezembro");
            

            do{
                System.Console.WriteLine("Digite um Número de 1 a 12");
                i = int.Parse(Console.ReadLine());
                
                if (i >= 1 && i <=12){
                    System.Console.WriteLine();
                    System.Console.WriteLine(meses[i]);
                } else {
                    System.Console.WriteLine("Por favor digite um número de 1 a 12");
                }

                System.Console.WriteLine("\nDeseja tentar novamente S/N");
                choice = Console.ReadLine();

                if (choice == "n"){
                    sair = true; 
                }
            } while (!sair);           
        }
    }
}
