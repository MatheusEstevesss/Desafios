using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp= String.Empty;

            Console.WriteLine("Tabuada do 1");
            for (int x = 1; x <=10; x++){
                for (int j=1; j<=10; j++){
                Console.Write($"{j} * {x} = {j*x} \t");
                }
                Console.WriteLine();
            }

        }
    }
}