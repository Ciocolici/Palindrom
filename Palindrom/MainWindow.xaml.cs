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

namespace Palindrom
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Pruefen_Click(object sender, RoutedEventArgs e)
        {
            string eingabeText = Text.Text;
            string bereinigterText = new string(eingabeText.Where(char.IsLetter).ToArray());

            if (Palindrom(bereinigterText))
            {
                Ergebnis.Content = "Ja, ist ein Palindrom";
            }
            else
            {
                Ergebnis.Content = "Nein, ist kein Palindrom";
            }
        }

        private bool Palindrom(string text)
        {
            string umgedrehterText = new string(text.Reverse().ToArray());
            return text.Equals(umgedrehterText, StringComparison.OrdinalIgnoreCase);
        }
    }
}
