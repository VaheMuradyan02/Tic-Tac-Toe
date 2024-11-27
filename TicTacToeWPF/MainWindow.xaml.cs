using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TicTacToeWPF.Model;
using TicTacToeWPF.Presenter;
using TicTacToeWPF.View;
using TicTacToeWPF.View.WPF;

namespace TicTacToeWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ITTTView
    {
        ImageSelectionWindowPlayer1 _player1Window;
        ImageSelectionWindowPlayer2 _player2Window;

        private BitmapImage X = new BitmapImage(new Uri(uriString: "pack://application:,,,/TicTacToeWPF;component/Resources/X.png"));
        private BitmapImage O = new BitmapImage(new Uri(uriString: "pack://application:,,,/TicTacToeWPF;component/Resources/O.png"));

        private string Player1 { get; set; } = "Human";
        private string Player2 { get; set; } = "BotEasy";


        public event EventHandler<CellCheckedEventArgs> CheckCellEvent;
        public event EventHandler StartGameEvent;

        public MainWindow()
        {
            InitializeComponent();

            _player1Window = new ImageSelectionWindowPlayer1();
            _player2Window = new ImageSelectionWindowPlayer2();

            _ = new TTTBoardPresenter(this, Player1, Player2);
        }

        public void HintMe(object sender, RoutedEventArgs e)
        {
            MenuColumn.Background = Brushes.Teal;
            MessageBox.Show("Aha, hima");
        }

        public void StartGame_Click(object sender, RoutedEventArgs e)
        {
            StartGameEvent?.Invoke(sender, e);
        }

        public void OpenOptions(object sender, RoutedEventArgs e)
        {
            Options.IsSubmenuOpen = true;
        }

        public void OpenMenu(object sender, RoutedEventArgs e)
        {
            Menu.IsSubmenuOpen = true;
        }

        public void Cell_Click(object sender, MouseButtonEventArgs e)
        {
            CheckCellEvent?.Invoke(sender, new CellCheckedEventArgs(X, O));
        }

        private void CheckImageForPlayer1Board(object sender, RoutedEventArgs e)
        {            
            _player1Window.ShowDialog();
            this.X = _player1Window.X;
        }

        private void CheckImageForPlayer2Board(object sender, RoutedEventArgs e)
        {
            _player2Window.ShowDialog();
            this.O = _player2Window.O;
        }

        private void IsPlayer1Human_Click(object sender, RoutedEventArgs e) => Player1 = "Human";

        private void IsPlayer1BotEasy_Click(object sender, RoutedEventArgs e) => Player1 = "BotEasy";

        private void IsPlayer1BotMedium_Click(object sender, RoutedEventArgs e) => Player1 = "BotMedium";

        private void IsPlayer1BotHard_Click(object sender, RoutedEventArgs e) => Player1 = "BotHard";

        private void IsPlayer2Human_Click(object sender, RoutedEventArgs e) => Player2 = "Human";

        private void IsPlayer2BotEasy_Click(object sender, RoutedEventArgs e) => Player2 = "BotEasy";

        private void IsPlayer2BotMedium_Click(object sender, RoutedEventArgs e) => Player2 = "BotMedium";

        private void IsPlayer2BotHard_Click(object sender, RoutedEventArgs e) => Player2 = "BotHard";

        private void CheckBox_CheckedForPlayer1(object sender, RoutedEventArgs e)
        {
            if (sender != Human) Human.IsChecked = false;
            if (sender != Easy) Easy.IsChecked = false;
            if (sender != Medium) Medium.IsChecked = false;
            if (sender != Hard) Hard.IsChecked = false;
        }
    }
}
