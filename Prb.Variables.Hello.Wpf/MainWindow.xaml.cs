using System.Windows;
using System.Windows.Controls;

namespace Prb.Variabelen01.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string name;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TxtUserName_TextChanged(object sender, TextChangedEventArgs e)
        {
            name = txtUserName.Text;
            lblFeedback.Content = "Je naam is " + name;
        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            lblUpperCase.Content = name.ToUpper();
            MessageBox.Show("Ben jij werkelijk dé " + name);
        }
    }
}
