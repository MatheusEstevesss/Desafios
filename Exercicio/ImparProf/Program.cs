using System;

namespace ImparProf
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i <100; i+=2){ // "int i" só existe no primeiro momento do laço, oque o for verifica são os outros 2, o do meio fala c pode contiuar (é a condição) a terceira fala oq ira acontecer
                Console.WriteLine(i + " ");
                }
        }
    }
}
