using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorpionLibrary
{
    public class IA
    {
        const int MINVAL = -100000;
        const int MAXVAL = 100000;

        /// <summary>
        /// Fonctions qui calcule le coup
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public Case CalcIA(Morpion m)
        {
            int i, j, tmp;
            int max = MINVAL;
            int maxi = -1, maxj = -1;

            //Si la partie est fini,
            // on ne fait pas de calcul
            if (!m.EstFini())
            {
                //Parcours des case du Morpion
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        // Si la case est vide
                        if (m.EstVide(i, j))
                        {
                            // On simule un coup
                            if (m.JoueurCourant.Nom != "IA")
                            {
                                m.JoueurSuivant();
                            }
                            m.Joue(i, j);
                            Console.WriteLine("Joueur :" + m.JoueurCourant.Nom);
                            tmp = this.CalcMin(m);
                            Console.WriteLine("CalcIA x: " + i + " y: " + j);
                            Console.WriteLine("tmp: " + tmp);
                            if (tmp > max)
                            {
                                max = tmp;
                                maxi = i;
                                maxj = j;
                            }

                            m.AnnuleCoup(i, j);
                        }
                    }
                }
                Console.WriteLine("fin");
            }
            if (m.JoueurCourant == m.J1 || m.JoueurCourant.Nom != "IA")
            {
                m.JoueurSuivant();
            }
            m.Joue(maxi, maxj);
            return m.getCase(maxi, maxj);
        }

        /// <summary>
        /// Fonction pour calculer le minimum
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int CalcMin(Morpion m)
        {
            int i, j, tmp;
            int min = MAXVAL;

            if (m.EstFini())
            {
                return this.Evalue(m);
            }
            else
            {
                //Parcours des case du Morpion
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        // Si la case est vide
                        if (m.EstVide(i, j))
                        {
                            // On simule un coup
                            m.JoueurCourant = m.J1;
                            Console.WriteLine("Min Joueur :" + m.JoueurCourant.Nom);
                            m.getCase(i, j).MarqueePar = m.JoueurCourant;

                            tmp = this.CalcMax(m);
                            Console.WriteLine("CalcMAX x: " + i + " y: " + j);
                            Console.WriteLine("tmp: " + tmp);

                            if (tmp < min)
                            {
                                min = tmp;
                            }

                            m.AnnuleCoup(i, j);
                        }
                    }
                }
            }
            return min;
        }

        /// <summary>
        /// Fonction pour calculer le maximum
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int CalcMax(Morpion m)
        {
            int i, j, tmp;
            int max = MINVAL;
            if (m.EstFini())
            {
                return this.Evalue(m);
            }
            else
            {
                //Parcours des case du Morpion
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        // Si la case est vide
                        if (m.EstVide(i, j))
                        {
                            // On simule un coup
                            m.JoueurSuivant();
                            Console.WriteLine("Max Joueur :" + m.JoueurCourant.Nom);
                            m.Joue(i, j);
                            //m.JoueurSuivant();

                            tmp = this.CalcMin(m);

                            Console.WriteLine("CalcMIN x: " + i + " y: " + j);
                            Console.WriteLine("tmp: " + tmp);

                            if (tmp > max)
                            {
                                max = tmp;
                            }

                            m.AnnuleCoup(i, j);
                        }
                    }
                }
            }
            return max;
        }

        /// <summary>
        /// Evalue la situation du jeu et lui donne un score
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int Evalue(Morpion m)
        {
            int score = 0;

            if (m.EstFini())
            {
                if (m.getTypeGagner() == "IA")
                {
                    return 1000 - this.ComptePions(m);
                }
                else if (m.getTypeGagner() == m.J1.Nom)
                {
                    return -1000 + -this.ComptePions(m);
                }
                else
                {
                    return 0;
                }
            }
            return score;
        }

        /// <summary>
        /// Compte le nombre de pion sur le plateau
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int ComptePions(Morpion m)
        {
            int res = 0;
            for (int i = 0; i < 9; i++)
            {
                if (m.Cases[i].MarqueePar != null)
                {
                    res = res + 1;
                }
            }
            return res;
        }
    }
}
