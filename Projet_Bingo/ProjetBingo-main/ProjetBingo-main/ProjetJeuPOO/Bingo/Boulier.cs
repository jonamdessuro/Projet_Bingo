using System;
using System.Collections.Generic;
using System.Text;

// Classe qui représente le boulier. On y retire les boules au hazard.

namespace ProjetJeuPOO.Bingo
{
    class Boulier : IBingoBoulier
    {
        private int[,] carteAnnonceur = new int[15, 5];
        private List<BingoBall> Boules;
        private Random random = new Random();

        public Random Random { get => random; set => random = value; }
        public int[,] CarteAnnonceur { get => carteAnnonceur; set => carteAnnonceur = value; }

        public Boulier()
        {
          this.Boules = new List<BingoBall>();
        }

        public BingoBall getRanbomBall()
        {
            throw new NotImplementedException();
        }

        public void fillBoulier()
        {
            for (int i = 1; i <= 15; i++)
            {
                BingoBall B = new BingoBall('B', i);
                add(B);
            }


            for (int i = 16; i <= 30; i++)
            {
                BingoBall I = new BingoBall('I', i);
                add(I);
            }

            for (int i = 31; i <= 45; i++)
            {
                BingoBall N = new BingoBall('N', i);
                add(N);
            }

            for (int i = 46; i <= 60; i++)
            {
                BingoBall G = new BingoBall('G', i);
                add(G);
            }

            for (int i = 61; i <= 75; i++)
            {
                BingoBall O = new BingoBall('O', i);
                add(O);
            }
        }

        public void restartBoulier()
        {
            fillBoulier();
        }

        public void add(BingoBall element)
        {
            //Ajouter les boules dans le boulier
            this.Boules.Add(element);
        }
        public bool isEmpty()
        {
            if (Boules.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int getSize()
        {
            return this.Boules.Count;
        }

        public void NouvellePartieBingo()
        {
            
        }

        public void VoirCartes()
        {

        }

        public void VoirCarteAnnonceur()
        {

        }

        public void TirerBoule()
        {

            int index = Random.Next(Boules.Count);
            BingoBall ball = Boules[index];
            Boules.RemoveAt(index);
            RemplirCarteA(ball);
            Console.WriteLine("Boule tirée :{0}", ball.Number);
            BingoController.AppuyerEnter();
        }

        public void RemplirCarteA(BingoBall ball)
        {
            int j;
            int i;
                    if(ball.Letter == 'B')
                    { 
                        j = 0;
                        i = ball.Number - 1;
                    }
                    else if(ball.Letter == 'I')
                    {
                        j = 1;
                        i = ball.Number - 16;
                    }
                    else if(ball.Letter == 'N')
                    {
                        j = 2;
                        i = ball.Number - 31;
                    }
                    else if(ball.Letter == 'G')
                    {
                        j = 3;
                        i = ball.Number - 46;
                    }
                    else
                    {
                        j = 4;
                        i = ball.Number - 61; 
                    }

                    CarteAnnonceur[i, j] = ball.Number;
        }

        public void FinPartie()
        {

        }

        public void MenuBingo()
        {
            Console.WriteLine("Bievenue dans le menu Bingo!");
            Console.WriteLine("1- Initialiser une nouvelle partie");
            Console.WriteLine("2- Visualiser une des cartes du joueur");
            Console.WriteLine("3- Visualiser la carte de l'annonceur");
            Console.WriteLine("4- Tirez une boule");
            Console.WriteLine("5- Fin de partie");
            string choixBingo = Console.ReadLine();
            ChoixMenuBingo(choixBingo);
        }

        public void ChoixMenuBingo(string choix)
        {
            switch (choix)
            {
                case "1":
                    NouvellePartieBingo();
                    break;

                case "2":
                    VoirCartes();
                    break;

                case "3":
                    VoirCarteAnnonceur();
                    break;

                case "4":
                    TirerBoule();
                    break;

                case "5":
                    FinPartie();
                    break;

                default:
                    Console.WriteLine("Veuillez entrer un choix valide");
                    break;
            }
        }

        public void AfficherCarteA()
        {
            string B = "B", I = "I", N = "N", G = "G", O = "O";
            Console.WriteLine("Carte de l'annonceur: ");
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,15} {1,15} {2,15} {3,15} {4,15} ", B, I, N, G, O);

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("{0,15} {1,15} {2,15} {3,15} {4,15}", CarteAnnonceur[i, 0], CarteAnnonceur[i, 1], CarteAnnonceur[i, 2], CarteAnnonceur[i, 3], CarteAnnonceur[i, 4]);
            }
            BingoController.AppuyerEnter();
        }
    }
}
