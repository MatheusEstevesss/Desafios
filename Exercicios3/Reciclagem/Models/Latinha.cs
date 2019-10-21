using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Latinha : IMetais
    {
        public bool EscolherMetal()
        {
            System.Console.WriteLine("Você deve jogar a latinha no lixo de Metais de cor Amarelo");
            return true;
        }
    }
}