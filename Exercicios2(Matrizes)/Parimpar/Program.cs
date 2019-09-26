using System;

namespace Parimpar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int [] vetor = new int [6];
            int pares= 0;
            int impar= 0;

            for(int cont=0; cont < 6; cont++){
                Console.Write("Digite um número: ");
                vetor [cont]= int.Parse(Console.ReadLine());
            }

            foreach (int num in vetor){
                if(num%2 == 0){
                    pares += 1; //é igual a "pares++", porém isto só soma o número 1, nao serve para somar 2, por isso usar(pares += 1)    
                }else {
                    impar++;
                }
            }

            /* for(int cont =0; cont < 6; cont++ ){
                int num = vetor[cont];
                if(num % 2 ==0){
                    pares++;
                }else {
                    impar++;
                }
            }*/

            Console.WriteLine($"Você possui {pares} números pares e {impar} números ímpares");
        }
    }
}

