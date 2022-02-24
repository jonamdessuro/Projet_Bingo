using System;
using System.Collections.Generic;
using System.Text;

//Classe représentant un objet boule 

namespace ProjetJeuPOO.Bingo
{
    class BingoBall
    {
        
        private char letter;
        private int number;

        public BingoBall(char letter, int number)
        {
            this.Letter = letter;
            this.Number = number;
        }

        public char Letter { get => letter; set => letter = value; }
        public int Number { get => number; set => number = value; }
    }
}
