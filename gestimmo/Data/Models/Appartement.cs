using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestimmo_WPF
{
    public class Appartement : Habitable
    {
        private int etage;
        private bool ascenseur;
        private bool chauffageCommun;

        public Appartement(double valeur, double surface, string adresse, int nbChambre, int nbPiece, bool parking, bool cave, int etage, bool ascenseur, bool chauffageCommun)
            : base(valeur, surface, adresse, nbChambre, nbPiece, parking, cave)
        {
            this.etage = etage;
            this.ascenseur = ascenseur;
            this.chauffageCommun = chauffageCommun;
        }

        public int AppartementId { get; set; }
        public int Etage { get => etage; set => etage = value; }
        public bool Ascenseur { get => ascenseur; set => ascenseur = value; }
        public bool ChauffageCommun { get => chauffageCommun; set => chauffageCommun = value; }

       
    }

}

