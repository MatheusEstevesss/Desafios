using System;
using System.Collections.Generic;
using System.Text;
using Banda.Interface;

namespace Banda.Models
{
    public class Bateria : InstrumentoMusical , IPercussao
    {
        public bool ManteRitmo(){
            System.Console.WriteLine("Mantendo ritmo da bateria");

            return true;
        }
    }
}