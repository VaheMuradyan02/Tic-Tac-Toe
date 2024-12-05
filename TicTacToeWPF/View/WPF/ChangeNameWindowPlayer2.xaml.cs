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
using System.Windows.Shapes;

namespace TicTacToeWPF.View.WPF
{
    /// <summary>
    /// Interaction logic for ChangeNameWindowPlayer2.xaml
    /// </summary>
    public partial class ChangeNameWindowPlayer2 : Window
    {
        public string Name { get; set; } = "Player2";

        public ChangeNameWindowPlayer2()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Name = TextBox.Text;
            Close();
        }

        private void Text_Changed(object sender, TextChangedEventArgs e)
        {
            int previousTextLength = 0;

            if (TextBox.Text.Length > previousTextLength && TextBox.Text.Length > 10)
            {
                TextBox.Text = TextBox.Text.Substring(0, 10);
                TextBox.SelectionStart = TextBox.Text.Length;
            }

            previousTextLength = TextBox.Text.Length;
        }
    }
}
