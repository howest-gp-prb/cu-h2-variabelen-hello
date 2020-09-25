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

namespace Prb.Variabelen01.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string naam;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void TxtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            naam = txtUsername.Text;
            lblFeedback.Content = "Je naam is " + txtUsername.Text;
        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            lblHoofdletters.Content = naam.ToUpper();
            MessageBox.Show("Ben jij werkelijk dé " + naam);
        }
    }
}
