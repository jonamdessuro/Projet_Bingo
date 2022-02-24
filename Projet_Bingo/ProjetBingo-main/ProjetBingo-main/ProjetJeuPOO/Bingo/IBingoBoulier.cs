using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.Bingo
{
    interface IBingoBoulier
    {
        public abstract BingoBall getRanbomBall();	// Affiche une boule au hasard parmit la liste des boules
		public abstract void restartBoulier();		// Réinitialise carte de l'annonceur
		public abstract void add(BingoBall element);// Ajouter une boule au boulier ou bien à une carte
		public abstract bool isEmpty(); // Savoir si le boulier OU une carte est vide
		public abstract int getSize(); // Savoir le nombre de boules dans le boulier ou le nombre
	}
}
