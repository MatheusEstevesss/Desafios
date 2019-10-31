using System;

namespace Desafio_23
{
    class Program
    {
        static void Main(string[] args)
        {   

            int maior = 0;
            int menor = 0;
            int posicaoMaior = 0;
            int posicaoMenor = 0;

            System.Console.WriteLine("++++++++++   Posição da Matriz   ++++++++++");
            
            int [] vetor = new int [10];
            Random random = new Random();

            maior = vetor [0];
            menor = vetor [0];

            for (int x = 0; x < 10; x++){
                vetor [x] = random.Next(1, 100);

                foreach (int num in vetor){
                    if (num > maior){
                        maior = num;
                        posicaoMaior = x + 1;
                    } else if (num < menor){
                        menor = num;
                        posicaoMenor = x + 1;
                    }
                }
                System.Console.WriteLine(vetor [x]);
            }

            System.Console.WriteLine($"O maior número da matriz é: {maior} e está na posição: {posicaoMaior}");
            System.Console.WriteLine($"O menor número da matriz é: {menor} e está na posição: {posicaoMenor}");
        }
    }
}
