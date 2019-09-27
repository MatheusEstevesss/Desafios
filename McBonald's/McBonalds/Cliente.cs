using System;

namespace McBonalds
{
    class Cliente
    {
        public string Nome{get;set;}
        public string Endereco {get;set;}
        public string Telefone {get;set;}
        public string Senha {get;set;}
        public string Email {get;set;}
        DateTime DataNascimento {get;set;}

        //construtor 
        public Cliente (string nome, string telefone, string email){
            this.Nome= nome;  //this especifica a variavel da classe.
            this.Telefone = telefone;
            this.Email = email;
        }
    }
}
