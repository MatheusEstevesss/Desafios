using System;
using ByteBank.Models;
namespace ByteBank {
    class Program {
        static void Main (string[] args) {
            string nome, cpf, email;
            int agencia, conta;
            
            System.Console.WriteLine ("Byte Bank");

            System.Console.WriteLine ();
            Console.Write ("Digite seu nome completo: ");
            nome = Console.ReadLine ();

            System.Console.WriteLine ();
            System.Console.Write ("Digite seu CPF: ");
            cpf = Console.ReadLine ();

            System.Console.WriteLine ();
            System.Console.Write ("Digite seu email: ");
            email = Console.ReadLine ();

            Cliente cliente1 = new Cliente (nome, cpf, email);

            bool senhaok = false;
            do {
                System.Console.WriteLine ("Digite a senha");
                string senha = Console.ReadLine ();
                senhaok = cliente1.TrocarSenha (senha);
                if (!senhaok) {
                    System.Console.WriteLine ("Senha não atende requisitos");
                } else {
                    System.Console.WriteLine ("Senha Alterada com sucesso!");
                }

            } while (!senhaok);

            System.Console.WriteLine ("Cadastro da Conta Corrente");
            System.Console.WriteLine ("Agencia: ");
            agencia = int.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Conta: ");
            conta = int.Parse (Console.ReadLine ());
            //System.Console.WriteLine("Titular: ");
            //string titular = Console.ReadLine();

            bool saldoValido = false;
            double saldo;
            do {
                System.Console.WriteLine ("Digite o Saldo: ");
                saldo = double.Parse (Console.ReadLine ());
                if (saldo >= 0) {
                    saldoValido = true;
                    System.Console.WriteLine ("");
                } else {
                    System.Console.WriteLine ("O saldo não pode ser negativo");
                }
            } while (!saldoValido);

            ContaCorrente contaCorrente = new ContaCorrente (cliente1, conta, agencia);
            contaCorrente.Saldo = saldo;

            System.Console.WriteLine("ByteBank deposito");
            Cliente usuario = contaCorrente.Titular;
            System.Console.WriteLine("Bem Vindo - {0}", usuario.Nome);
            System.Console.WriteLine("Agencia {0}, Conta {1}", contaCorrente.Agenda, contaCorrente.Numero);
            System.Console.WriteLine("Saldo {0}", contaCorrente.Saldo);
            System.Console.WriteLine("Digite o valor do Depósito: ");
            double valor = double.Parse(Console.ReadLine());
            contaCorrente.Deposito(valor);

            System.Console.WriteLine();

            System.Console.WriteLine("ByteBank - Saque");
            System.Console.WriteLine("Digite o valor do saque: ");
            double saque = double.Parse(Console.ReadLine());
                if(contaCorrente.Saque(valor)){
                    System.Console.WriteLine("Saque realizado com sucesso");
                    System.Console.WriteLine("Saldo {0}", contaCorrente.Saldo);
                } else {
                    System.Console.WriteLine("Não foi possivel realizar o saque");
                }

            System.Console.WriteLine();
            
            System.Console.WriteLine("ByteBank - Transferência");
            System.Console.WriteLine("Digite o valor da Transferência: ");
            double transferencia = double.Parse(Console.ReadLine());
            Cliente cliente2 = new Cliente ("Alexandre", "123.123.123-12", "a@a.com");
            ContaCorrente contaCorrente2 = new ContaCorrente(cliente2, 123, 123);
                if(contaCorrente2.Transferencia(contaCorrente2, valor)){
                    System.Console.WriteLine("Transferência efetuada com sucesso");
                } else {
                    System.Console.WriteLine("A transferência não foi efetuada");
                }

            // System.Console.WriteLine ("Seu saldo é: {0}", contaCorrente.Saldo);
            /* 
            System.Console.WriteLine();
            System.Console.WriteLine("Qual operação deseja realizar ?");
            System.Console.WriteLine("Digite 1 - Para efetuar um depósito");
            System.Console.WriteLine("Digite 2 - Para efetuar um saque");
            System.Console.WriteLine("Digite 3 - Para realizar um trânsferencia");
            oper = int.Parse(Console.ReadLine());

            switch (oper){
                case 1:
                System.Console.WriteLine("Digite o valor do depósitos: ");
                double deposito = double.Parse(Console.ReadLine());
                total = contaCorrente.Saldo + deposito;

                System.Console.WriteLine("Seu novo saldo é de: {0}", total);
                break;

                case 2:
                System.Console.WriteLine("Digite o valor do seu saque: ");
                double saque = double.Parse(Console.ReadLine());
                total = contaCorrente.Saldo - saque;
                if(total >= 0){
                    System.Console.WriteLine("Saque realizado com sucesso. Seu novo saldo é: {0}", total);
                } else {
                    System.Console.WriteLine("O seu saldo final não poder ficar negativo.");
                }
                break;
                */
        }
    }
}