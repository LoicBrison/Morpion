using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorpionLibrary
{
    public class Joueur
    {
        private string nom;
        private bool isIA = false;
        private IA ia;
        public string Nom { get => nom; set => nom = value; }
        public bool IsIA { get => isIA; set => isIA = value; }
        public Joueur(string nom)
        {
            // Si le nom est different de Null ou qu'avec des espaces
            if (!(String.IsNullOrWhiteSpace(nom)))
            {
                this.nom = nom;
                if (nom == "IA")
                {
                    isIA = true;
                    ia = new IA();
                }
            }
        }

        // Si le joueur est une IA (nom = "IA")
        public Case JoueIA(Morpion morpion)
        {
            return ia.CalcIA(morpion);
        }
    }
}
