using System;
using ContaCorrente1.Models;

namespace ContaCorrente1
{
    class Program
    {
        static void Main(string[] args)
        {
            int agencia, conta;

            System.Console.WriteLine("Cadastro da Conta Corrente");
            System.Console.WriteLine("Agencia: ");
            agencia = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Conta: ");
            conta = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Titular: ");
            string titular = Console.ReadLine();

            bool  saldoValido = false;
            double saldo;
            do{
                System.Console.WriteLine("Digite o Saldo: ");
                saldo = double.Parse(Console.ReadLine());
                if (saldo > 0){
                    saldoValido = true;
                    System.Console.WriteLine("");
                } else {
                    System.Console.WriteLine("O saldo não pode ser negativo");
                }
            }while(!saldoValido);

            ContaCorrente contaCorrente = new ContaCorrente (titular, conta, agencia);
            contaCorrente.Saldo = saldo;
        }
    }
}
