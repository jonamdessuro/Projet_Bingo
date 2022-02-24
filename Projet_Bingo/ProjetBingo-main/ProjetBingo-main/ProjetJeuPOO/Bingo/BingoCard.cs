using System;
using System.Collections.Generic;
using System.Text;

// Classe représentant un objet carte pour le joueur.
// Un joueur a au minimum une carte.

namespace ProjetJeuPOO.Bingo
{
    class BingoCard
    {
        private int[,] carteJoueur = new int[5, 5];
        private int numeroCarte;

        public BingoCard(int numeroCarte)
        {
            this.numeroCarte = numeroCarte;
            
            List<int> listeBallesJoueur = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int numero;

                    do
                    {
                        if (j == 0)
                        {
                            numero = random.Next(1, 15);
                        }
                        else if (j == 1)
                        {
                            numero = random.Next(16, 30);
                        }
                        else if (j == 2)
                        {

                            numero = random.Next(31, 45);
                        }
                        else if (j == 3)
                        {
                            numero = random.Next(46, 60);
                        }
                        else
                        {
                            numero = random.Next(61, 75);
                        }

                    } while (listeBallesJoueur.Contains(numero));

                    listeBallesJoueur.Add(numero);

                    CarteJoueur[i, j] = numero;
                    CarteJoueur[2, 2] = 0;

                }
            }
        }

        public int[,] CarteJoueur { get => carteJoueur; set => carteJoueur = value; }
        public int NumeroCarte { get => numeroCarte; set => numeroCarte = value; }

        public void AfficherCartes()
        {
            string B = "    B", I = "    I", N = "    N", G = "    G", O = "    O";
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("{0,4} {1,4} {2,4} {3,4} {4,4} ", B, I, N, G, O);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0,5} {1,5} {2,5} {3,5} {4,5}", carteJoueur[i, 0], carteJoueur[i, 1], carteJoueur[i, 2], carteJoueur[i, 3], carteJoueur[i, 4]);
            }
            BingoController.AppuyerEnter();
        }
    }
}
