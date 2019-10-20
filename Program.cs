using System;

namespace Jeu_de_math
{
    class Program
    {
        const int MIN = 1;
        const int MAX = 10;

        private static bool DemanderAddition()
        {
            Random random = new Random();
            int a = random.Next(MIN, MAX);
            int b = random.Next(MIN, MAX);

            while (true)
            {
                Console.Write(a + " + " + b + " = ");
                String reponse = Console.ReadLine();
                int responseNum = 0;

                if (int.TryParse(reponse, out responseNum))
                {
                    if (responseNum == (a + b))
                    {
                        Console.WriteLine("Bonne réponse");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Mauvaise réponse");
                        return false;
                    }

                }

                else
                {
                    Console.WriteLine("ATTENTION: vous devez entrer une valeur numérique");
                }
            }
        }

        static void Main(string[] args)
        {
            const int NB_QUESTIONS = 5;
            int nbPoints = 0;
            for (int i=0;i < NB_QUESTIONS; i++)
            {
                Console.WriteLine("Question " + (i+1) + "/" + NB_QUESTIONS);
                if (DemanderAddition()){
                    nbPoints++;
                }
                else
                {

                }
                Console.WriteLine("");
            }
            Console.WriteLine("Vous avez " + nbPoints + " sur " + NB_QUESTIONS);

            if (nbPoints == NB_QUESTIONS)
            {
                Console.WriteLine("Excellent !");
            }
            else if (nbPoints == 0)
            {
                Console.WriteLine("Revisez vos maths !");
            }
            else if (nbPoints <= (NB_QUESTIONS / 2))
            {
                Console.WriteLine("Peut mieux faire !");
            }
            else
            {
                Console.WriteLine("Pas mal !");
            }
        }
    }
}
