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

        ChangeNameWindowPlayer1 _player1Name;
        ChangeNameWindowPlayer2 _player2Name;

        private BitmapImage X = new BitmapImage(new Uri(uriString: "pack://application:,,,/TicTacToeWPF;component/Resources/X.png"));
        private BitmapImage O = new BitmapImage(new Uri(uriString: "pack://application:,,,/TicTacToeWPF;component/Resources/O.png"));

        private TTTBoard _board;

        public event EventHandler<CellCheckedEventArgs> CheckCellEvent;
        public event EventHandler<CellCheckedEventArgs> StartGameEvent;
        public event EventHandler RestartGameEvent;
        public event EventHandler HintEvent;

        private Image[,] _cages;

        public MainWindow()
        {
            InitializeComponent();

            InitializeCages();

            _player1Window = new ImageSelectionWindowPlayer1();
            _player2Window = new ImageSelectionWindowPlayer2();

            _player1Name = new ChangeNameWindowPlayer1();
            _player2Name = new ChangeNameWindowPlayer2();

            _board = new TTTBoard();

            _ = new TTTBoardPresenter(this, _cages, _board);
        }

        private void InitializeCages()
        {
            _cages = new Image[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    string cageName = $"Cage{i}{j}";
                    _cages[i, j] = LogicalTreeHelper.FindLogicalNode(this, cageName) as Image;
                }
            }
        }

        public void HintMe(object sender, RoutedEventArgs e)
        {
            HintEvent?.Invoke(sender, e);
        }

        public void StartGame_Click(object sender, RoutedEventArgs e)
        {
            RestartGameEvent?.Invoke(sender, e);
            StartGameEvent?.Invoke(sender, new CellCheckedEventArgs(X, O));
        }

        private void RestartGame_Click(object sender, RoutedEventArgs e)
        {
            RestartGameEvent?.Invoke(sender, e);
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

        private void IsPlayer1Human_Click(object sender, RoutedEventArgs e)
        {
            _board.Player1Type = "Human";
            Human_1.IsChecked = true;
            Easy_1.IsChecked = false;
            Medium_1.IsChecked = false;
            Hard_1.IsChecked = false;
        }

        private void IsPlayer1BotEasy_Click(object sender, RoutedEventArgs e)
        {
            _board.Player1Type = "BotEasy";
            Human_1.IsChecked = false;
            Easy_1.IsChecked = true;
            Medium_1.IsChecked = false;
            Hard_1.IsChecked = false;
        }

        private void IsPlayer1BotMedium_Click(object sender, RoutedEventArgs e)
        {
            _board.Player1Type = "BotMedium";
            Human_1.IsChecked = false;
            Easy_1.IsChecked = false;
            Medium_1.IsChecked = true;
            Hard_1.IsChecked = false;
        }

        private void IsPlayer1BotHard_Click(object sender, RoutedEventArgs e)
        {
            _board.Player1Type = "BotHard";
            Human_1.IsChecked = false;
            Easy_1.IsChecked = false;
            Medium_1.IsChecked = false;
            Hard_1.IsChecked = true;
        }

        private void IsPlayer2Human_Click(object sender, RoutedEventArgs e)
        {
            _board.Player2Type = "Human";
            Human_2.IsChecked = true;
            Easy_2.IsChecked = false;
            Medium_2.IsChecked = false;
            Hard_2.IsChecked = false;
        }

        private void IsPlayer2BotEasy_Click(object sender, RoutedEventArgs e)
        {
            _board.Player2Type = "BotEasy";
            Human_2.IsChecked = false;
            Easy_2.IsChecked = true;
            Medium_2.IsChecked = false;
            Hard_2.IsChecked = false;
        }

        private void IsPlayer2BotMedium_Click(object sender, RoutedEventArgs e)
        {
            _board.Player2Type = "BotMedium";
            Human_2.IsChecked = false;
            Easy_2.IsChecked = false;
            Medium_2.IsChecked = true;
            Hard_2.IsChecked = false;
        }

        private void IsPlayer2BotHard_Click(object sender, RoutedEventArgs e)
        {
            _board.Player2Type = "BotHard";
            Human_2.IsChecked = false;
            Easy_2.IsChecked = false;
            Medium_2.IsChecked = false;
            Hard_2.IsChecked = true;
        }

        private void ChangeNameForPlayer1(object sender, RoutedEventArgs e)
        {
            _player1Name.ShowDialog();
            this.Player1.Content = _player1Name.Name;
        }

        private void ChangeNameForPlayer2(object sender, RoutedEventArgs e)
        {
            _player2Name.ShowDialog();
            this.Player2.Content = _player2Name.Name;
        }

        private void GetStatistic_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
