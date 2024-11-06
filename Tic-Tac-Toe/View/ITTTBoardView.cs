using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.View
{
    internal interface ITTTBoardView
    {
        event EventHandler CheckCellEvent;
        event EventHandler ChooseFirstPlayerAsHumanEvent;
        event EventHandler ChooseFirstPlayerAsBotEvent;
        event EventHandler ChooseSecondPlayerAsHumanEvent;
        event EventHandler ChooseSecondPlayerAsBotEvent;
        event EventHandler ChooseStartGameEvent;
        event EventHandler ChooseRestartGameEvent;
        void Show();
    }
}
