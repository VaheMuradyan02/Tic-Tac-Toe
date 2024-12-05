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
    /// Interaction logic for StatisticGameWindow.xaml
    /// </summary>
    public partial class StatisticGameWindow : Window
    {
        public StatisticGameWindow()
        {
            InitializeComponent();

            var data = new List<MyData>
        {
            new MyData { Column1 = "Row 1, Col 1", Column2 = "Row 1, Col 2", Column3 = "Row 1, Col 3" },
            new MyData { Column1 = "Row 2, Col 1", Column2 = "Row 2, Col 2", Column3 = "Row 2, Col 3" }
        };

            // Bind data to the DataGrid
            dataGrid.ItemsSource = data;
        }
    }

    class MyData
    {
        public string Column1 { get; set; }
        public string Column2 { get; set; }
        public string Column3 { get; set; }
    }
}
