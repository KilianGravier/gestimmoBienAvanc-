using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestimmo_WPF
{
    public class Intervention
    {
        private DateTime date;
        private double montantTTC;
        private string information;
        private Bien bien;
        private Prestataire prestataire;

        public Intervention ()
        {

        }

        public Intervention(DateTime date, double montantTTC, string information, Bien bien, Prestataire prestataire)
        {
            this.date = date;
            this.montantTTC = montantTTC;
            this.information = information;
            this.bien = bien;
            this.prestataire = prestataire;
        }

        public int InterventionId { get; set; }
        public DateTime Date { get => date; set => date = value; }
        public double MontantTTC { get => montantTTC; set => montantTTC = value; }
        public string Information { get => information; set => information = value; }
        public Bien Bien { get => bien; set => bien = value; }
        public Prestataire Prestataire { get => prestataire; set => prestataire = value; }
    }


}

