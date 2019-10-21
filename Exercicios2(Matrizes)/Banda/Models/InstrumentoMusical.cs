using System;

namespace Banda.Models
{
    public class InstrumentoMusical
    {
        string[] notas = {"Do", "Ré", "Mi", "Fá", "Sol", "Lá", "Si"};

        public string TocarMusica (){
            int nota = new Random().Next(notas.Length -1);
            
            return notas[nota];
        }
    }
}