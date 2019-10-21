using System;
using System.Collections.Generic;
using System.Text;
using Banda.Interface;

namespace Banda.Models
{
    public class Violao : InstrumentoMusical, IHarmonia, IPercussao, IMelodia
    {
        protected bool TocarAcordes(){
            System.Console.WriteLine("Tocando acordes do Violão: ");

            return true;
        }

        public bool TocarRitmo(){
            System.Console.WriteLine("Mantendo o ritmo do Violão");

            return true;
        }

        public bool TocarSolo(){
            System.Console.WriteLine("Tocando solo no Violão");
            
            return true;
        }
    }
}