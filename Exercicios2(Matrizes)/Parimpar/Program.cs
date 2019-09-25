using System;

namespace Parimpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matriz");
            
            int [] vetor= new int[6];
            int [] dados = {1,2,3,4,5,6};
                for(int i=0; i < 6; i++){
                    dados[i]= i;
                if (dados%2){
                    Console.WriteLine("seu núemro é par:", dados);
                } else {
                    Console.WriteLine("seu núemro é par:", dados);
                }
        }
    }
}
}
