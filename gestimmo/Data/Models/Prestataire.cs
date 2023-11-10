using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestimmo_WPF
{
    public class Prestataire
    {
        private string raisonSociale;
        private string nom;
        private string prenom;
        private string telephone;
        private string adresse;
        private List<Intervention> interventions;

        public Prestataire(string raisonSociale, string nom, string prenom, string telephone, string adresse)
        {
            this.raisonSociale = raisonSociale;
            this.nom = nom;
            this.prenom = prenom;
            this.telephone = telephone;
            this.adresse = adresse;
            this.interventions = new List<Intervention>();
        }

        public int PrestataireId { get; set; }
        public string RaisonSociale { get => raisonSociale; set => raisonSociale = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public List<Intervention> Interventions { get => interventions; set => interventions = value; }
    }
}
