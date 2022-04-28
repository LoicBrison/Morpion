using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorpionLibrary
{
    public class Case
    {
        private Joueur marqueePar;
        private int x;
        private int y;

        public Joueur MarqueePar { get => marqueePar; set => marqueePar = value; }
        public int GetX { get => x; }
        public int GetY { get => y; }


        public Case(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
