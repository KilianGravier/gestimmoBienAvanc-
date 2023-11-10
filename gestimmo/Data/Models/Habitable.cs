using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestimmo_WPF
{
    public class Habitable : Bien
    {
        private int nbChambre;
        private int nbPiece;
        private bool parking;
        private bool cave;

        public Habitable(double valeur, double surface, string adresse, int nbChambre, int nbPiece, bool parking, bool cave)
            : base(valeur, surface, adresse)
        {
            this.nbChambre = nbChambre;
            this.nbPiece = nbPiece;
            this.parking = parking;
            this.cave = cave;
        }

        public int HabitableId { get; set; }
        public int NbChambre { get => nbChambre; set => nbChambre = value; }
        public int NbPiece { get => nbPiece; set => nbPiece = value; }
        public bool Parking { get => parking; set => parking = value; }
        public bool Cave { get => cave; set => cave = value; }

       
    }

}
