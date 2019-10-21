using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Papelao : IPapel
    {
        public bool EscolherPapel()
        {
            System.Console.WriteLine("Você deve jogar o Papelão no lixo de Papel de cor Azul");
            return true;
        }
    }
}