using System;

namespace salario
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, novo, total;

            Console.WriteLine("Aumento Salarial");
            Console.WriteLine("Digite seu salário:");
            salario= doubel.Parse(Console.ReadLine());

            if(salario <500){
                novo= (salario * 30)/ 100;
                total= novo + salario;
                Console.WriteLine("Você tem direito ao aumento");
                Console.WriteLine("Seu novo salario é: R${0}", total);
                Console.Write("Você recebeu um aumento de 30%: R${0}", novo);
            } else{
                Console.WriteLine("Você não possuí direito ao aumento salarial");
            }



        }
    }
}
