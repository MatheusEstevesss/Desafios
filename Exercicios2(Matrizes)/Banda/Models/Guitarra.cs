using System;
using System.Collections.Generic;
using System.Text;
using Banda.Interface;

namespace Banda.Models
{
    public class Guitarra : InstrumentoMusical, IHarmonia, IMelodia
    {
        public bool TocarAcordes(){
            System.Console.WriteLine("Tocando acordes da Guitarra");
            return true;
        }

        public bool TocarSolo(){
            System.Console.WriteLine("Tocando solo de Guitarra");
            return true;
        }
    }
}