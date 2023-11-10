using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestimmo_WPF
{
    public class Pret
    {
        private double tauxInteret;
        private double montantPret;
        private int duree;
        private double apport;
        private DateTime dateDebut;
        private Bien bien;

        public Pret ()
        {

        }
        public Pret(double tauxInteret, double montantPret, int duree, double apport, DateTime dateDebut, Bien bien)
        {
            this.tauxInteret = tauxInteret;
            this.montantPret = montantPret;
            this.duree = duree;
            this.apport = apport;
            this.dateDebut = dateDebut;
            this.bien = bien;
        }

        public int PretId { get; set; }
        public double TauxInteret { get => tauxInteret; set => tauxInteret = value; }
        public double MontantPret { get => montantPret; set => montantPret = value; }
        public int Duree { get => duree; set => duree = value; }
        public double Apport { get => apport; set => apport = value; }
        public DateTime DateDebut { get => dateDebut; set => dateDebut = value; }
        public Bien Bien { get => bien; set => bien = value; }

        public double calculerMensualite()
        {
            double mensualite = (this.montantPret - this.apport) / this.duree;
            return mensualite;
        }

        public int obtenirNbMoisRestant()
        {
            DateTime dateJour = DateTime.Today;
            TimeSpan moisPaye = dateJour.Subtract(this.dateDebut);
            double nbMois = moisPaye.TotalDays / 30;

            double moisRestantAPaye = Math.Floor(this.duree - nbMois);
            return (int)moisRestantAPaye;
        }

        public double calculerCapitalRestantARembourser()
        {
            int mois = this.obtenirNbMoisRestant();
            double mensualite = this.calculerMensualite();
            double resteAPayer = (this.montantPret - ((this.duree - mois) * mensualite)) - this.apport;
            return resteAPayer;
        }
    }
}
