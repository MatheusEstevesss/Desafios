using System;

namespace Áreas
{
    class Program
    {
        static void Main(string[] args)
        {
            int oper, total, l, t, h, B, b, he, hh, Md, md, r, func;
            int bt;
            double totalC;
            Console.WriteLine("Áreas de figuras geométricas");

            do{
            Console.WriteLine("Escolha a figura no qual deseja calcula: \n1 Quadrado \n2 Triângulo \n3 Círculo \n4 Trápezio \n5 Retângulo \n6 Losango");
            oper = int.Parse(Console.ReadLine());

            
            switch (oper){
                case 1: Console.WriteLine("Digite o lado do Quadrado");
                l = int.Parse(Console.ReadLine());
                total = l * 4;
                Console.WriteLine("Seu resultado é: {0}", total);
                break;

                case 2: Console.WriteLine("Digite a base do triângulo");
                t = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a altura do triângulo");
                h = int.Parse(Console.ReadLine());
                total = (t*h) /2;
                Console.WriteLine("Seu resultado é: {0}", total);
                break;

                case 3: Console.WriteLine("Digite o raio do círculo");
                r = int.Parse(Console.ReadLine());
                totalC= (r*r) * 3.14;
                Console.WriteLine("Seu resultado é: {0}", totalC);
                break;

                case 4: Console.WriteLine("Digite a maior base do Trapézio");
                B = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a menor base do Trapézio");
                b= int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a altura do Trapézio");
                he = int.Parse(Console.ReadLine());

                total= ((B*b) * he) /2;
                Console.WriteLine("Seu resultado é: {0}", total);
                break;

                case 5: Console.WriteLine("Digite a base do Retângulo");
                bt = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a altura do Retângulo");
                hh = int.Parse(Console.ReadLine());

                total= bt * hh;
                Console.WriteLine("Seu resultado é: {0}", total);
                break;

                case 6: Console.WriteLine("Digite a Maior diagonal do Losango");
                Md= int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a menor digonal do Losango");
                md= int.Parse(Console.ReadLine());

                total= Md * md / 2;
                Console.WriteLine("Seu resultado é: {0}", total);
                break;
            
                }
                Console.WriteLine("Aperte 1 para tentar novamente ou 2 para sair");
                func = int.Parse(Console.ReadLine());
                 
            } while(func == 1);

            
        }
    }
}