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
        event EventHandler<CellCheckedEventArgs> StartGameEvent;
        event EventHandler RestartGameEvent;
        event EventHandler HintEvent;
        void Show();
    }
}
