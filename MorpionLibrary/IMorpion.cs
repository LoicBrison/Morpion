using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorpionLibrary
{
    public interface IMorpion
    {
        Joueur J1 { get; set; }
        Joueur J2 { get; set; }
        Joueur JoueurCourant { get; set; }
        void JoueurSuivant();
    }
}
