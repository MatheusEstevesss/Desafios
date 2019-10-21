using System;
using Banda.Models;
using Banda.Interface;

namespace Banda
{
    enum Formacaoenum : int 
    {
        TRIO = 3,
        QUARTETO,
    }

    enum InstrumentosEnum : int {
        BAIXO,
        BATERIA,
        CONTRABAIXO,
        GUITARRA,
        TECLADO,
        TAMBORES,
        VIOLAO,
    };

    enum categoriaEnum : int {
        HARMONIA,
        PERCUSSAO,
        MELODIA,
    };
    class Program
    {
        static void Main(string[] args)
        {
            bool querSair = false;
            string[] itensMenuPrincipal = Enum.GetNames(typeof(FormacaoEnum));
            string[] intensMenuCategoria = Enum.GetNames(typeof(categorinEnum));

            var opcoesFormacao = new List<string> ()
            {
                " -0 ",
                " -1 "
            };

            int opcaoFomacaoSelecionada = 0;
            string menubar = "=================";

            do 
            {
                bool formacaoEscolhida = false;

                do
                {
                    Console.Clear();
                    System.Console.WriteLine(menubar);
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = Console.Black;
                    System.Console.WriteLine("Welcome");
                    System.Console.WriteLine("Escolha uma formação: ");
                    Consol.ResetColor();
                    System.Console.WriteLine(menubar);

                    for(int i=0 i < opcoesFormacao.COunt; i++)
                    {
                        string titulo = TratarTituloMenu(itensMenuPrincipal[i]);
                        if (opcoesFormacao == i)
                        {
                            DestacarOpcao (opcaoFomacao[opcaoFomacaoSelecionada]).Replace("-" ">").Replace(i.ToString);
                        } else {
                            System.Console.WriteLine(opcoesFormacao[i]);
                        }
                    }
                }
            }
        }
    }
}