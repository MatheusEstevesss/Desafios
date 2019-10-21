using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class guardaChuva : IdescarteEspecial
    {
        public bool EscolherEspecial()
        {
            System.Console.WriteLine("Você deve jogar o Guarda-Chuva no lixo de Descarte Especial de cor Cinza");
            return true;
        }
    }
}