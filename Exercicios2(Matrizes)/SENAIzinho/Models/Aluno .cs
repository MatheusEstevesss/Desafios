using System;
namespace SENAIzinho.Models
{
    public class Aluno 
    {
        public string Nome {get ; set;}
        public DateTime DataNascimento {get ; set;}
        public string Curso {get ; set;}
        public int NumeroSala{get ; set;}

        public Aluno (string Nome,string Curso ,DateTime DataNascimento){
            this.Nome = Nome;
            this.DataNascimento = DataNascimento;
            this.Curso = Curso;
        }
    }
}