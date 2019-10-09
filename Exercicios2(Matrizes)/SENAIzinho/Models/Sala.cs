using System;
namespace SENAIzinho.Models
{
    public class Sala
    {
        public int CapacidadeAtual {get ; set;}
        public int CapacidadeTotal {get ; set;}
        public int NumeroSala {get ; set;}
        public string Alunos {get ; set;}
        public string AlocarAluno  {get ; set;}
        public string RemoverAluno {get ; set;}
        public string MostrarAlunos {get ; set;}

        public Sala (int CapacidadeAtual, int CapacidadeTotal, int NumeroSala,string Alunos){
            this.CapacidadeAtual = CapacidadeAtual;
            this.CapacidadeTotal = CapacidadeTotal;
            this.NumeroSala = NumeroSala;
            this.Alunos = Alunos;
        }
    }
}