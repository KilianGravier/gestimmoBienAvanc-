using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestimmo_WPF
{
    public class Locataire
    {
        private string nom;
        private string prenom;
        private string profession;
        private int age;
        private Contrat bail;

        

        public Locataire(string nom, string prenom, string profession, int age, Contrat bail)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.profession = profession;
            this.age = age;
            this.bail = bail;
        }

        public int LocataireId { get; set; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Profession { get => profession; set => profession = value; }
        public int Age { get => age; set => age = value; }
        public Contrat Bail { get => bail; set => bail = value; }
    }
}

