using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace gestimmo_WPF.Views.Forms
{
    /// <summary>
    /// Logique d'interaction pour GererBoxForm.xaml
    /// </summary>
    public partial class GererBoxForm : Page
    {
        public GererBoxForm()
        {
            InitializeComponent();
        }

        private List<Bien> listeBiens = new List<Bien>();

        

        private void InitialiserListeBiens()
        {
            listeBiens = new List<Bien>();
        }

        private void AfficherListeBiens()
        {
            
        }

        private void AjouterBien_Click(object sender, RoutedEventArgs e)
        {
            string nom = this.NomBienTxt.Text;
            string valeurTexte = ValeurBienTextBox.Text;
            string surfaceTexte = SurfaceBienFormulaireTextBox.Text;
            string adresse = AdresseDuBienTextBox.Text;

            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(valeurTexte) ||
                string.IsNullOrWhiteSpace(surfaceTexte) || string.IsNullOrWhiteSpace(adresse))
            {
                MessageBox.Show("Veuillez remplir tous les champs pour ajouter un bien.");
                return;
            }

            double valeur, surface;
            if (!double.TryParse(valeurTexte, out valeur) || !double.TryParse(surfaceTexte, out surface))
            {
                MessageBox.Show("Veuillez saisir des valeurs numériques valides pour la surface et la valeur du bien.");
                return;
            }

            Bien nouveauBien = new Bien
            {
                Nom = nom,
                Surface = surface,
                Valeur = valeur,
                Adresse = adresse
            };

            listeBiens.Add(nouveauBien);
            AfficherListeBiens(); // Rafraîchir l'affichage de la liste après l'ajout
        }

        public class Bien
        {
            public string Type { get; set; } // Modification : le type n'est plus nullable
            public string Nom { get; set; }
            public double Surface { get; set; }
            public double Valeur { get; set; }
            public string Adresse { get; set; }
        }
    }
}
