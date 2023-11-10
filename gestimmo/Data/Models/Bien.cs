using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestimmo_WPF
{


    public class Bien
    {
        private double valeur;
        private double surface;
        private string adresse;
        private List<Contrat> baux;
        private List<Intervention> interventions;
        private Pret? pret;

        public Bien(double valeur, double surface, string adresse)
        {
            this.valeur = valeur;
            this.surface = surface;
            this.adresse = adresse;
            this.baux = new List<Contrat>();
            this.interventions = new List<Intervention>();
            this.pret = null;
        }

        public int BienId { get; set; }
        public double Valeur { get => valeur; set => valeur = value; }
        public double Surface { get => surface; set => surface = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public List<Contrat> Contrats { get => baux; set => baux = value; }
        public List<Intervention> Interventions { get => interventions; set => interventions = value; }
        public Pret? Pret { get => pret; set => pret = value; }

        public double calculerRentabiliteNetMensuel()
        {
            double loyer = 0;

            double mensualite = 0;
            if (pret != null)
            {
                mensualite = pret.calculerMensualite();
            }

            foreach (Contrat b in baux)
            {
                if (b.DateFin == null)
                {
                    loyer = b.Loyer;
                }
            }

            double rentabilite = loyer - mensualite;
            return rentabilite;
        }

        public virtual double estimerValeur()
        {
            double prixMetreCarre = 1400;
            double prixSurface = prixMetreCarre * surface;

            return prixSurface;
        }
    }
}