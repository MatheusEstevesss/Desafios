using System;

namespace Desafio_8 {
    class Program {
        static void Main (string[] args) {
              int altura = 4;
                for (int x = 0; x <= altura; x++)
                    for(int y = x; y < altura; y++){
                        System.Console.WriteLine("*");
                    }
        }
    }
}