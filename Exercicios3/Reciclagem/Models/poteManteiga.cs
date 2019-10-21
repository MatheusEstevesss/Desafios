using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class poteManteiga : IPlastico
    {
        public bool EscolherPlastico()
        {
            System.Console.WriteLine("Você deve jogar o Pote de Manteiga no lixo de Plástico de cor Vermelho");
            return true;
        }
    }
}