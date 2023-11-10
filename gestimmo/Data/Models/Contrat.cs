using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestimmo_WPF
{
    public class Contrat
    {
        private double loyer;
        private DateTime dateDebut;
        private DateTime? dateFin;
        private Bien bien;
        private List<Locataire> locataires;

        public Contrat ()

        {

        }

        public Contrat(double loyer, DateTime dateDebut, DateTime? dateFin, Bien bien)
        {
            this.loyer = loyer;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.bien = bien;
            this.locataires = new List<Locataire>();
        }

        public int ContratId { get; set; }
        public double Loyer { get => loyer; set => loyer = value; }
        public DateTime DateDebut { get => dateDebut; set => dateDebut = value; }
        public DateTime? DateFin { get => dateFin; set => dateFin = value; }
        public Bien Bien { get => bien; set => bien = value; }
        public List<Locataire> Locataires { get => locataires; set => locataires = value; }
    }
}
