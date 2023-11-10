using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestimmo_WPF
{
    public class Maison : Habitable
    {
        public Maison(double valeur, double surface, string adresse, int nbChambre, int nbPiece, bool parking, bool cave)
            : base(valeur, surface, adresse, nbChambre, nbPiece, parking, cave)
        {
        }
    }
}
