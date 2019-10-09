using System;
using SENAIzinho.Models;

namespace SENAIzinho
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("SENAIzinho \n"); 

            System.Console.WriteLine(" 1 - Cadastrar Aluno");
            System.Console.WriteLine(" 2 - Cadastrar Sala");
            System.Console.WriteLine(" 3 - Alocar Aluno");
            System.Console.WriteLine(" 4 - Remover Aluno");
            System.Console.WriteLine(" 5 - Verificar Salas");
            System.Console.WriteLine(" 6 - Verificar Alunos");
            System.Console.WriteLine(" 7 - Sair");
            int choise = int.Parse(Console.ReadLine());
            
            

            switch (choise){
                case 1:
                    System.Console.Write(" Nome: ");
                    string nome = Console.ReadLine();
                    System.Console.Write(" Curso: ");
                    string curso = Console.ReadLine();
                    System.Console.Write(" Data de Nascimento: ");
                    DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

                    Aluno aluno = new Aluno (nome, curso, dataNascimento); 
                break;

                case 2:
                break;

                case 3:
                break;

                case 4:
                break;

                case 5:
                break;

                case 6:
                break;

                case 7:
                break;
            }       

                List <TodoItem> SENAIzinho = new List<TodoItem>();
        }
    }
}
