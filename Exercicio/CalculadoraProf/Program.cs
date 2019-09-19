using System;

namespace CalculadoraProf
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int oper;
            double total;

            Console.WriteLine("Digite o 1º número");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º número");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a operação");
            Console.WriteLine("Digite 1 para adição");
            Console.WriteLine("Digite 2 para subtração");
            Console.WriteLine("Digite 3 para multiplicação");
            Console.WriteLine("Digite 4 para divisão");
            Console.WriteLine("Digite 5 para o módulo");
            oper = int.Parse(Console.ReadLine());

           switch(oper)
           {
                case 1:
                total= num1 + num2;
                Console.Write("valor da sua operação: {0}", total);
                break;

                case 2:
                total= num1 - num2;
                Console.Write("valor da sua operação: {0}", total);
                break;

                case 3:
                total= num1 * num2;
                Console.Write("valor da sua operação: {0}", total);
                break;

                case 4:
                total= num1 / num2;
                Console.Write("valor da sua operação: {0}", total);
                break;

                case 5:
                total= num1 % num2;
                Console.Write("valor da sua operação: {0}", total);
                break;

                default:
                    Console.WriteLine("Excuse me UATA FUQUI! Try Again");
                    break;
           }
            

        }
    }
}
