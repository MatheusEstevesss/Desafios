using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    class Garrafa : IVidro 
    {
        public bool EscolherVidro()
        {
            System.Console.WriteLine("Você deve jogar a Garrafa no lixo de Vidro de cor Verde");
            return true;
        }
    }
}