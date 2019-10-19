using System;

namespace Jeu_de_math
{
    class Program
    {
        const int MIN = 1;
        const int MAX = 10;

        private static void DemanderAddition()
        {
            Random random = new Random();
            int a = random.Next(MIN, MAX);
            int b = random.Next(MIN, MAX);

            Console.Write(a + " + " + b + " = ");
            String reponse = Console.ReadLine();
            int responseNum = 0;

            if (int.TryParse(reponse, out responseNum))
            {
                if (responseNum == (a + b))
                {
                    Console.WriteLine("Bonne réponse");
                }
                else
                {
                    Console.WriteLine("Mauvaise réponse");
                }

            }
            //sinon
            else
            {
                Console.WriteLine("ATTENTION: vous devez entrer une valeur numérique");
            }
        }

        static void Main(string[] args)
        {
            DemanderAddition();
        }
    }
}
