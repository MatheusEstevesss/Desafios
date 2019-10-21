using System;
using System.Collections.Generic;
using System.Text;
using Banda.Interface;

namespace Banda.Models
{
    public class Tambores : InstrumentoMusical, IPercussao
    {
        public bool ManterRitmo(){
            System.Console.WriteLine("Mantendo ritmo dos Tambores");
            return true;
        }    
    }
}