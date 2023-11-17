using System.Windows.Controls;
using System.Windows;
using gestimmo_WPF.Views.SubViews;

namespace gestimmo_WPF.Views.Forms
{
    public partial class GererBienForm : UserControl
    {
        public GererBienForm()
        {
            InitializeComponent();
        }

        private void AjouterBien_Click(object sender, RoutedEventArgs e)
        {
            // Récupération des valeurs du formulaire
            string type = TypeBienComboBoxFormulaire.Text;
            string nom = NomBienTextBox.Text;
            string valeurTexte = ValeurBienTextBox.Text;
            string surfaceTexte = SurfaceBienFormulaireTextBox.Text;

            // Vérifications pour les champs vides et valeurs numériques
            if (string.IsNullOrWhiteSpace(type) || string.IsNullOrWhiteSpace(nom) ||
                string.IsNullOrWhiteSpace(valeurTexte) || string.IsNullOrWhiteSpace(surfaceTexte))
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

            // Création d'un nouveau bien avec les valeurs saisies
            var nouveauBien = new BiensView.Bien { Type = type, Nom = nom, Surface = surface, Valeur = valeur };

            // Appel à la logique de BiensView pour ajouter ce bien
            // biensView.AjouterBien(nouveauBien);
        }
    }
}
