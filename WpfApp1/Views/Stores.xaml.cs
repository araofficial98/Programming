using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp1.Model;

namespace WpfApp1.Views
{
    /// <summary>
    /// Interaction logic for Stores.xaml
    /// </summary>
    public partial class Stores : Window
    {
        public Stores()
        {
            InitializeComponent();
        }

        private void NumberValidationTextBox (object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void AddKnop_Click(object sender, RoutedEventArgs e)
        {
            Store winkel = new Store {
                Address = adressWink.Text,
                City = stadWink.Text,
                MaxCapacity = int.Parse(maxWink.Text)
            };

            StoreResult res = new StoreResult(winkel);

            res.Show();    
        }
    }
}
