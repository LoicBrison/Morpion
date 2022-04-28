using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorpionLibrary
{
    public class Morpion : IMorpion
    {
        private Joueur j1;
        private Joueur j2;
        private Joueur joueurGagnant;
        private Joueur joueurCourant;
        private Case[] cases;

        public Joueur JoueurCourant { get => joueurCourant; set => joueurCourant = value; }
        public Joueur J1 { get => j1; set => j1 = value; }

        public Case[] Cases { get => cases; }


        //Morpion demande 2 joueurs pour commencer
        public Morpion(Joueur j1, Joueur j2)
        {
            this.j1 = j1;
            this.j2 = j2;

            this.joueurCourant = this.j1;

            cases = new Case[9];

            int o = 0;

            //Création du plateau
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    cases[o] = (new Case(i, j));
                    o = o + 1;
                }
            }
        }


        /// <summary>
        /// Return une case d'après ces coordonées X,Y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public Case getCase(int x, int y)
        {
            switch (y)
            {
                case 0:
                    switch (x)
                    {
                        case 0: return cases[0];
                        case 1: return cases[1];
                        case 2: return cases[2];
                        default: return null;
                    };
                case 1:
                    switch (x)
                    {
                        case 0: return cases[3];
                        case 1: return cases[4];
                        case 2: return cases[5];
                        default: return null;
                    };
                case 2:
                    switch (x)
                    {
                        case 0: return cases[6];
                        case 1: return cases[7];
                        case 2: return cases[8];
                        default: return null;
                    };
                default: return null;
            }
        }

        /// <summary>
        /// Joue la case X,Y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Joue(int x, int y)
        {
            if (!this.EstFini())
            {
                this.getCase(x, y).MarqueePar = this.JoueurCourant;
            }
        }

        /// <summary>
        /// Annule le coup a la case X,Y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void AnnuleCoup(int x, int y)
        {
            this.getCase(x, y).MarqueePar = null;
        }

        /// <summary>
        /// Retourne vrais si la case X,Y est vide
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>bool</returns>
        public bool EstVide(int x, int y)
        {
            bool res = true;
            if (this.getCase(x, y).MarqueePar != null)
            {
                res = false;
            }
            return res;
        }

        /// <summary>
        /// Passe le joueur suivant devient le joueur courant
        /// </summary>
        public void JoueurSuivant()
        {
            if (this.joueurCourant == this.j1)
            {
                this.joueurCourant = j2;
            }
            else if (this.joueurCourant == this.j2)
            {
                this.joueurCourant = j1;
            }
        }

        /// <summary>
        /// Retourn vrais si la partie est fini
        /// </summary>
        /// <returns>bool</returns>
        public bool EstFini()
        {
            bool res = false;
            if (this.CompteCase() > 0)
            {
                res = true;
                joueurGagnant = JoueurCourant;
            }
            return res;
        }

        /// <summary>
        /// Regarde l'etat du plateau
        /// Return 0 si rien de spéciale, 1 si 3 cases alignées sont marquée et 2 si match null 
        /// </summary>
        public int CompteCase()
        {
            int result = 0;

            //Si 3 case de gauche alignée verticalement
            for (int i = 0; i < 3; i++)
            {
                if (this.joueurCourant == this.cases[i].MarqueePar)
                {
                    if (this.joueurCourant == this.cases[i + 3].MarqueePar)
                    {
                        if (this.joueurCourant == this.cases[i + 6].MarqueePar)
                        {
                            result = 1;
                        }
                    }
                }
            }

            //Si 3 case alignée horizontalement
            for (int i = 0; i <= 6; i = i + 3)
            {
                if (this.joueurCourant == this.cases[i].MarqueePar)
                {
                    if (this.joueurCourant == this.cases[i + 1].MarqueePar)
                    {
                        if (this.joueurCourant == this.cases[i + 2].MarqueePar)
                        {
                            result = 1;
                        }
                    }
                }
            }

            //Si 3 case alignée en diagonale
            if (this.joueurCourant == getCase(0, 0).MarqueePar)
            {
                if (this.joueurCourant == getCase(1, 1).MarqueePar)
                {
                    if (this.joueurCourant == getCase(2, 2).MarqueePar)
                    {
                        result = 1;
                    }
                }
            }

            //Si 3 case alignée en diagonale
            if (this.joueurCourant == getCase(2, 0).MarqueePar)
            {
                if (this.joueurCourant == getCase(1, 1).MarqueePar)
                {
                    if (this.joueurCourant == getCase(0, 2).MarqueePar)
                    {
                        result = 1;
                    }
                }
            }

            //Sinon on regarde si chaque case est marquée
            if (result == 0)
            {
                int tampon = 0; //Bool pour savoir si une ancienne case est vide ou non
                for (int i = 0; i < 9; i++)
                {
                    //Si une case est marquée
                    if (Cases[i].MarqueePar != null)
                    {
                        tampon++;
                    }

                }
                if (tampon == 9)
                {
                    result = 2;
                }


            }
            return result;
        }

        /// <summary>
        /// Retourne le nom du gagnant
        /// </summary>
        /// <returns></returns>
        public String getTypeGagner()
        {
            if (this.CompteCase() == 2)
            {
                return "";
            }
            else
            {
                return this.joueurGagnant.Nom;
            }
        }
    }
}
