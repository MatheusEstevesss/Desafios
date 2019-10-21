using System;
using Reciclagem.Interfaces;
using Reciclagem.Models;

namespace Reciclagem
{
    class Program
    {   
        enum Descartes : uint
        {
            Garrafa,
            GARRAFAPET,
            GUARDACHUVA,
            LATINHA,
            PAPELAO,
            POTEMANTEIGA
        }
        static void Main(string[] args)
        {
            string menuBar = "------------------------------";

            System.Console.WriteLine(menuBar);
            System.Console.WriteLine("     Bem Vindo a Reciclagem     \n");
            System.Console.WriteLine("  Escolha o item que deseja reciclar  ");
            System.Console.WriteLine(menuBar);
            
            string[] itensMenuPrinciapal = Enum.GetNames(typeof(Descartes));

            ExibirMenuDescartes();

            System.Console.Write("Digite o item a ser descartado: ");
            int choice = int.Parse(Console.ReadLine());
        }

         public static void ExibirMenuDescartes()
        {
            var menuItens = Enum.GetNames(typeof(Descartes));
            int codigo = 1;
            string menuInstrumentoBorda = "##############################";

            System.Console.WriteLine(menuInstrumentoBorda);
            System.Console.WriteLine("#                            #");
            System.Console.WriteLine("#          Descartes         #");
            System.Console.WriteLine("#                            #");
            System.Console.WriteLine(menuInstrumentoBorda);

            foreach (var Descartes in menuItens)
            {
                System.Console.WriteLine($"  {codigo++}.{(Descartes)}");
            }

            System.Console.WriteLine(menuInstrumentoBorda);
        }
    }
}