using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    /// Interaction logic for ImageSelectionWindowPlayer1.xaml
    /// </summary>
    public partial class ImageSelectionWindowPlayer1 : Window
    {
        public BitmapImage X { get; set; } = new BitmapImage(new Uri("pack://application:,,,/TicTacToeWPF;component/Resources/X.png"));

        public ImageSelectionWindowPlayer1()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (sender != CheckBox1) CheckBox1.IsChecked = false;
            if (sender != CheckBox2) CheckBox2.IsChecked = false;
            if (sender != CheckBox3) CheckBox3.IsChecked = false;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (CheckBox1.IsChecked == true)
            {
                X = new BitmapImage(new Uri("pack://application:,,,/TicTacToeWPF;component/Resources/X_Red.png"));
            }
            if (CheckBox2.IsChecked == true)
            {
                X = new BitmapImage(new Uri("pack://application:,,,/TicTacToeWPF;component/Resources/X.png"));                
            }
            if (CheckBox3.IsChecked == true)
            {
                X = new BitmapImage(new Uri("pack://application:,,,/TicTacToeWPF;component/Resources/X_Pink.png"));
            }

            Close();
        }
    }
}
