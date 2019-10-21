using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class garrafaPet : IPlastico
    {
        public bool EscolherPlastico()
        {
            System.Console.WriteLine("Você deve jogar a Garrafa Pet no lixo de Plastico de cor Azul");
            return true;
        }
    }
}