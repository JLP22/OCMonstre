using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loto
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] loto7 = CreerTableauLoto(7);
            AfficherTableau(loto7);
        }

        private static int[] CreerTableauLoto(int nbBoules)
        {

            int[] loto = new int[nbBoules];
            for (int i = 0; i < nbBoules; i++)
            {
                Random aleatoire = new Random();
                int randomValue = aleatoire.Next(1, 50);
                if (!loto.Contains(randomValue)) loto[i] = randomValue;
                else i--;
            }
            return loto;
        }

        private static void AfficherTableau(int[] tab)
        {

            int i = 0;
            Console.WriteLine("Voici le résultat du tirage : ");

            foreach (int val in tab)
            {
                i++;
                Console.WriteLine("Boule numéro " + i + " : " + val);
            }

            Console.WriteLine("Fin du résutlat.");
        }
    }
}
