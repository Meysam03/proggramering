using System;

namespace mopa
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randNumb = rand.Next(1, 101);
            int försök = 1;

            while(true){
                Console.Write("--> Gissa ett tal ; ");
                string Gissa = Console.ReadLine();
                int gissa;
                if(int.TryParse(Gissa, out gissa) == false){
                    Console.WriteLine("fel!");
                    continue;
                }

                if(gissa == randNumb){
                    break;
                }
                else if(gissa > randNumb){
                    Console.WriteLine("Du gissade för högt!");
                }
                else{
                    Console.WriteLine("Du gissade för lågt!");
                }
                försök++;
            }

            Console.Write("braa! Du gissade rätt. Det tog ");
            Console.WriteLine(" försök :)");
            
            

        }
    }
}