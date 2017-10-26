using ArmyBuilder.Models;
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

using System.Text.RegularExpressions;

namespace ArmyBuilder
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArmeeOrganisationsplan NeueArmee = new ArmeeOrganisationsplan();
        public MainWindow()
        {
            InitializeComponent();

            cboArmeeAuswahl.ItemsSource = Enum.GetValues(typeof(Enums)).Cast<Enums>();
        }

        private void cboArmeeAuswahl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NeueArmee.Armee = (Enums)cboArmeeAuswahl.SelectedItem;
            NeueArmee.Name = txtName.Text;
            NeueArmee.Punkte = Convert.ToInt32(txtPunkte.Text);


        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void txtPunkte_TextChanged(object sender, TextChangedEventArgs e)
        {
            NeueArmee.Punkte = Convert.ToInt32(txtPunkte.Text);
        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            NeueArmee.Name = txtName.Text;
        }
    }
}
