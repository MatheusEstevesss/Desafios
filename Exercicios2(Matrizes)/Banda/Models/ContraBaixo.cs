using System;
using System.Collections.Generic;
using System.Text;
using Banda.Interface;

namespace Banda.Models
{
    public class ContraBaixo : InstrumentoMusical, IPercussao, IHarmonia
    {
        public bool ManterRitmo(){
            System.Console.WriteLine("Mantendo ritmo do Contra Baixo");
            return true;
        }
        public bool TocarAcordes(){
            System.Console.WriteLine("Tocando acordes do Contra Baixo");
            return true;
        }
    }
}