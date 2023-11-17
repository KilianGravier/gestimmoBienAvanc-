// ... (autres directives)

using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows;

namespace gestimmo_WPF.Views.SubViews
{
    public partial class BiensView : UserControl // Modifier Page en UserControl
    {
        // Initialisation de listeBiens à une nouvelle liste vide
        private List<Bien> listeBiens = new List<Bien>();

        public BiensView()
        {
            InitializeComponent();
            InitialiserListeBiens();
            AfficherListeBiens();
        }

        private void InitialiserListeBiens()
        {
            listeBiens = new List<Bien>();
        }

        private void AfficherListeBiens()
        {
            MesBiensListView.ItemsSource = listeBiens;
        }

        

        public class Bien
        {
            public string? Type { get; set; } // Déclarer 'Type' comme nullable
            public string? Nom { get; set; } // Déclarer 'Nom' comme nullable
            public double Surface { get; set; }
            public double Valeur { get; set; }
            public string? Adresse { get; set; } // Déclarer 'Adresse' comme nullable
        }

    }
}
