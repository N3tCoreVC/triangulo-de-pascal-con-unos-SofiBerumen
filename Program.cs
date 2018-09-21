using System;

namespace triangulo_de_pascal_con_unos_SofiBerumen
{
    class Program
    {
        static void Main(string[] args)
        {
            int lin;
            
            Console.WriteLine("Dame base: ");
            int.TryParse(Console.ReadLine(), out lin);

            int n= lin-1;

            for(int i=1; i<=lin; i++){
                for(int k=0; k<n; k++){
                    Console.Write(" ");
                }
                
                for(int j=0; j<i; j++){
                    Console.Write("1 ");
                }
                Console.Write("\n");
                n--;


            }
        }

        
    }
}
