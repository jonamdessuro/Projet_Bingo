using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.SimiliPendu
{
    class PenduController
    {
       private int partiesJouees = 0;
       private int partiesGagnees = 0;
       private bool partieEnCours = false;
        public int PartiesJouees { get => partiesJouees; set => partiesJouees = value; }
       public int PartiesGagnees { get => partiesGagnees; set => partiesGagnees = value; }
        public bool PartieEnCours { get => partieEnCours; set => partieEnCours = value; }

        public PenduController()
        {

        }

        public void NouvellePartie()
        {
            Console.WriteLine("À VENIR");
        }

        public void MenuPendu()
        {

        }
    }
}
