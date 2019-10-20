using System;

namespace Jeu_de_math
{
    class Program
    {
        const int MIN = 1;
        const int MAX = 10;
        const int NB_QUESTIONS = 5;
        static Random random = new Random();

        enum OPERATEUR
        {
            ADDITION,
            MUTLIPLICATION,
            SOUSTRACTION
        }

        // Création d'un getter pour l'opérateur
        private static OPERATEUR GetOperateur()
        {
            // Je prends au hasard un chiffre entre 1 et 3
            int operateur = random.Next(1, 4);
            if (operateur == 1)
            {
                return OPERATEUR.ADDITION;
            }
            if (operateur == 2)
            {
                return OPERATEUR.MUTLIPLICATION;
            }
            if (operateur == 3)
            {
                return OPERATEUR.SOUSTRACTION;
            }
            return OPERATEUR.ADDITION;
        }

        private static bool DemanderOperation()
        {

            int a = random.Next(MIN, MAX);
            int b = random.Next(MIN, MAX);
            OPERATEUR operateur = GetOperateur();
            int resultatOperation = 0;


            // Je boucle tant que j'ai pas défini une valeur numérique
            while (true)
            {
                // En fonction du type d'opérateur ...
                switch (operateur)
                {
                    case OPERATEUR.ADDITION:
                        {
                            Console.Write(a + " + " + b + " = ");
                            resultatOperation = a + b;
                        }
                        break;
                    case OPERATEUR.MUTLIPLICATION:
                        {
                            Console.Write(a + " * " + b + " = ");
                            resultatOperation = a * b;
                        }
                        break;
                    case OPERATEUR.SOUSTRACTION:
                        {
                            if (a < b)
                            {
                                int temp = a;
                                a = b;
                                b = temp;
                            }
                            Console.Write(a + " - " + b + " = ");
                            resultatOperation = a - b;
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("ERREUR : ce cas n'est pas géré dans le programme !");
                            Environment.Exit(0);
                        }
                        break;
                }

                String reponse = Console.ReadLine();
                int responseNum = 0;

                // Si il s'agit d'une valeur numérique alors je retourne qqch (sortie de boucle)
                if (int.TryParse(reponse, out responseNum))
                {
                    if (responseNum == resultatOperation)
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
                // si il ne s'agit pas de valeur numérique j'affiche qqch et je continue la boucle
                else
                {
                    Console.WriteLine("ATTENTION: vous devez entrer une valeur numérique");
                }
            }
        }

        private static void AfficherResultat(int nbPoints)
        {
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


        static void Main(string[] args)
        {
            int nbPoints = 0;

            // Je boucle sur le nombre de questions (constante)
            for (int i=0;i < NB_QUESTIONS; i++)
            {
                Console.WriteLine("Question " + (i+1) + "/" + NB_QUESTIONS);
                if (DemanderOperation()){
                    nbPoints++;
                }
                else
                {

                }
                Console.WriteLine("");
            }

            AfficherResultat(nbPoints);

        }
    }
}
