using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace TicTacToeWPF.View
{
    public interface ITTTView
    {
        event EventHandler<CellCheckedEventArgs> CheckCellEvent;
        event EventHandler StartGameEvent;
        void Show();
    }
}
