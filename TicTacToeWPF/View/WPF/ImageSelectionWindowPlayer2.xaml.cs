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
    /// Interaction logic for ImageSelectionWindowPlayer2.xaml
    /// </summary>
    public partial class ImageSelectionWindowPlayer2 : Window
    {
        public BitmapImage O { get; set; } = new BitmapImage(new Uri("pack://application:,,,/TicTacToeWPF;component/Resources/O.png"));

        public ImageSelectionWindowPlayer2()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if(sender != CheckBox1) CheckBox1.IsChecked = false;
            if (sender != CheckBox2) CheckBox2.IsChecked = false;
            if (sender != CheckBox3) CheckBox3.IsChecked = false;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (CheckBox1.IsChecked == true)
            {
                O = new BitmapImage(new Uri("pack://application:,,,/TicTacToeWPF;component/Resources/O_Red.png"));
            }
            if (CheckBox2.IsChecked == true)
            {
                O = new BitmapImage(new Uri("pack://application:,,,/TicTacToeWPF;component/Resources/O.png"));
            }
            if (CheckBox3.IsChecked == true)
            {
                O = new BitmapImage(new Uri("pack://application:,,,/TicTacToeWPF;component/Resources/O_Pink.png"));
            }

            Close();
        }
    }
}
