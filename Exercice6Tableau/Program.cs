using System;

namespace Exercice6Tableau
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrice = new int[2, 2];

            for(int x = 0; x < 2; x++)
            {
                for(int y = 0; y < 2; y++)
                {
                    Console.Write("Entrez la valeur de la ligne " + (x + 1) + " , colonne " + (y + 1) + " : ");
                    matrice[x, y] = int.Parse(Console.ReadLine());
                }
            }

            int d = (matrice[0, 0] * matrice[1, 1]) - (matrice[1, 0] * matrice[0, 1]);
            Console.WriteLine("Le déterminant de la matrice est: " + d);

            Console.ReadLine();
        }
    }
}

