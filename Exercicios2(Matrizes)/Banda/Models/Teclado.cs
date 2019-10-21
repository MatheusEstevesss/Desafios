using System;
using System.Collections.Generic;
using System.Text;
using Banda.Interface;

namespace Banda.Models
{
    public class Teclado : InstrumentoMusical, IMelodia, IHarmonia
    {
        public bool TocarSolo(){
            System.Console.WriteLine("Tocando solo do Teclado");
            return true;
        }

        public bool TocarAcodes(){
            System.Console.WriteLine("Tocando acordes do Teclado");
            return true;
        }
    }
}