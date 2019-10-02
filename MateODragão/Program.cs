using System;
using MateODragão.Models;

namespace MateODragão {
    class Program {
        static void Main (string[] args) {
            bool JogarNaoDesistiu = true;
            do {

                System.Console.WriteLine ("++++++++++++++++++++++++++++++");
                System.Console.WriteLine ("      Kill the Dragon!");
                System.Console.WriteLine ("++++++++++++++++++++++++++++++");

                System.Console.WriteLine (" 1 - Iniciar jogo");
                System.Console.WriteLine (" 0 - Sair do jogo");

                string opcaojogador = Console.ReadLine ();

                switch (opcaojogador) {
                    case "1":
                        Console.Clear(); 

                        Guerreiro guerreiro = CriarGuerreiro ();
                        

                        Dragao dragao = new Dragao();  
                        dragao.Nome = "Armagedon";
                        dragao.Forca = 5;
                        dragao.Destreza = 1;
                        dragao.Inteligencia = 3;
                        dragao.Vida = 300;

                            /*Inicio do dialogo*/
                        CriarDialogo (guerreiro.Nome, $"{guerreiro.Nome .ToUpper()}: {dragao.Nome}, seu louco ! Vim derrotar-te-lhe.");
                        System.Console.WriteLine();
                        System.Console.WriteLine($"{dragao.Nome .ToUpper()} WUAHAHAHA! Humano tolinho. Quem pena que és?!"); // Se pensas que consegue humano, lute contra mim!
                        
                        FinalizarDialogo();
                
                            /* fim do dialogo*/

                            /* Inicio Segundo Dialogo */
                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Eu sou {guerreiro.Nome}! Da casa {guerreiro.Sobrenome}, ó criatura morfética!");
                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Vim de {guerreiro.CidadeNatal} para derrotar-te e mostrar meu valor!");
                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: QUEM? DE ONDE? Bom, que seja...fritar-te-ei e devorar-te-ei, primata insolente!");

                        FinalizarDialogo();
                            /* Fim Segundo Dialogo */
                        
                        bool jogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;

                        bool jogardorNaoCorreu = true;
                        int poderAtaqueGuerreiro = guerreiro.Inteligencia > guerreiro.Forca ? guerreiro.Inteligencia + guerreiro.Destreza : guerreiro.Forca + guerreiro.Destreza;

                            /*Inicio da treta */
                        if (jogadorAtacaPrimeiro){
                            Console.Clear();
                            System.Console.WriteLine("Turno do jogador");
                            System.Console.WriteLine(" 1 - Atacar");
                            System.Console.WriteLine(" 2 - Fugir");

                            string opcaoBatalhaJogador = Console.ReadLine();

                            switch (opcaoBatalhaJogador){
                                case "1": // GERAR NÚMERO ALEATÓRIO
                                    Random geradorNumeroAleatorio = new Random();
                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0 , 5);
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0 , 5);

                                    int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if(guerreiroDestrezaTotal > dragaoDestrezaTotal){
                                        System.Console.WriteLine($"{guerreiro.Nome}: Toma essa lagarto maldjeto!");
                                        dragao.Vida = dragao.Vida -= poderAtaqueGuerreiro + 5;
                                        System.Console.WriteLine("+++++++++++++");
                                        System.Console.WriteLine($"HP do Dragão: ", dragao.Vida);
                                        System.Console.WriteLine($"HP do Guerreiro: ", guerreiro.Vida);
                                    } else {
                                        System.Console.WriteLine($"{dragao.Nome .ToUpper()}: Errrrooouu, humano tolo");
                                    }

                                break;
                                case "2":
                                    jogardorNaoCorreu = false;
                                    System.Console.WriteLine($"{guerreiro.Nome .ToUpper()}: Simbora flw");
                                    System.Console.WriteLine($"{dragao.Nome .ToUpper()}: IZI PEASY LEMON SQUEEZY");
                                break;
                            }

                            System.Console.WriteLine("Aperte ENTER para prosseguir");
                            Console.ReadLine();

                            while ( dragao.Vida > 0 && guerreiro.Vida > 0 && jogardorNaoCorreu) {
                                Console.Clear();
                                System.Console.WriteLine("+++ Turno do Dragão +++");
                                 Random geradorNumeroAleatorio = new Random();
                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0 , 5);
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0 , 5);

                                    int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if(dragaoDestrezaTotal > guerreiroDestrezaTotal ){
                                        System.Console.WriteLine($"{dragao.Nome}: Hum, humano insolente!");
                                        guerreiro.Vida -= dragao.Forca;
                                        System.Console.WriteLine("+++++++++++++");
                                        System.Console.WriteLine($"HP do Dragão: ", dragao.Vida);
                                        System.Console.WriteLine($"HP do Guerreiro: ", guerreiro.Vida);
                                    } else {
                                        System.Console.WriteLine($"{guerreiro.Nome .ToUpper()}: Vem tranquilo, não se afoba não");
                                    }

                                    System.Console.WriteLine();
                                    System.Console.WriteLine("Aperte ENTER para prosseguir");
                                    Console.ReadLine();

                                        /* Inicio - Turno guerreiro */
                                    Console.Clear();
                                         System.Console.WriteLine("Turno do jogador");
                            System.Console.WriteLine(" 1 - Atacar");
                            System.Console.WriteLine(" 2 - Fugir");

                            opcaoBatalhaJogador = Console.ReadLine();

                            switch (opcaoBatalhaJogador){
                                case "1": // GERAR NÚMERO ALEATÓRIO
                                    geradorNumeroAleatorio = new Random();
                                    numeroAleatorioJogador = geradorNumeroAleatorio.Next(0 , 5);
                                    numeroAleatorioDragao = geradorNumeroAleatorio.Next(0 , 5);

                                    guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if(guerreiroDestrezaTotal > dragaoDestrezaTotal){
                                        System.Console.WriteLine($"{guerreiro.Nome}: Toma essa lagarto maldjeto!");
                                        dragao.Vida = dragao.Vida -= poderAtaqueGuerreiro + 5;
                                        System.Console.WriteLine("+++++++++++++");
                                        System.Console.WriteLine($"HP do Dragão: {dragao.Vida}");
                                        System.Console.WriteLine($"HP do Guerreiro: {guerreiro.Vida}");
                                    } else {
                                        System.Console.WriteLine($"{dragao.Nome .ToUpper()}: Errrrooouu, humano tolo");
                                    }

                                    if (guerreiro.Vida <=0) {
                                        System.Console.WriteLine("Guerreiro Morreu!");
                                    } if (dragao.Vida <= 0){
                                        System.Console.WriteLine("Dragão Morreu");
                                    }

                                    System.Console.WriteLine();
                                    System.Console.WriteLine("aperte ENTER para prosseguir");
                                    Console.ReadLine();
                                    
                                break;
                                case "2":
                                    jogardorNaoCorreu = false;
                                    System.Console.WriteLine($"{guerreiro.Nome .ToUpper()}: Simbora flw");
                                    System.Console.WriteLine($"{dragao.Nome .ToUpper()}: IZI PEASY LEMON SQUEEZY");
                                break;
                            }
                                        /* Fim - Turno guerreiro */
                            }                            
                        }
                            /*Fim da treta */

                        break;
                    case "0":
                        JogarNaoDesistiu = false;
                        break;
                    default:
                        System.Console.WriteLine ("Comando inválido. Por favor siga as instruções!");
                        break;
                }
            } while (JogarNaoDesistiu);
        }
    
        private static void CriarDialogo(string nome, string frase)
        {
            System.Console.WriteLine($"{nome .ToUpper()}: {frase}");
        }
        private static void FinalizarDialogo()
        {
            System.Console.WriteLine ();
            System.Console.WriteLine ("Aperte ENTER para prosseguir");
            Console.ReadLine ();
            Console.Clear ();
        }
        private static Guerreiro CriarGuerreiro()
        {
            Guerreiro guerreiro = new Guerreiro(); 
            guerreiro.Nome = "Daedric";
            guerreiro.Sobrenome = "Whisper";
            guerreiro.CidadeNatal = "Constantinopla";
            guerreiro.DataNascimento = DateTime.Parse("09/04/1340");
            guerreiro.FerramentaAtaque = "Duas adagas";
            guerreiro.FerramentaProtecao = "Armadura Leve";
            guerreiro.Forca = 0;
            guerreiro.Destreza = 3;
            guerreiro.Inteligencia = 5;
            guerreiro.Vida = 20;

            return guerreiro;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
        }
    }
}