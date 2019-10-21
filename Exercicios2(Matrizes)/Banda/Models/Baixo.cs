using System;
using System.Collections.Generic;
using System.Text;
using Banda.Interface;

namespace Banda.Models
{
    public class Baixo : InstrumentoMusical, IPercussao, IHarmonia
    {
        public bool ManterRitmo(){
            System.Console.WriteLine("Mantendo o ritmo do Baixo");
            return true;
        }

        public bool TocarSolo(){
            System.Console.WriteLine("Tocando acordes do Baixo");
            return true;
        }
    }
}