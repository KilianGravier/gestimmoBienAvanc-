using System.Windows.Controls;

namespace gestimmo_WPF.Views.Forms
{
    public partial class GererBienForm : Page
    {
        public GererBienForm()
        {
            InitializeComponent();
            TypeBienComboBoxFormulaire.SelectionChanged += TypeBienComboBoxFormulaire_SelectionChanged;
        }

        private void TypeBienComboBoxFormulaire_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            // Vérifiez si "Box" est sélectionné
            if (comboBox.SelectedItem != null && ((ComboBoxItem)comboBox.SelectedItem).Content.ToString() == "Box")
            {
                // Créez une nouvelle instance de la vue GererBoxForm
                GererBoxForm gererBoxForm = new GererBoxForm();

                // Ajoutez la vue GererBoxForm au Frame nommé "DroiteList" dans votre interface utilisateur
                DroiteList.Navigate(gererBoxForm);
            }
        }
    }
}
