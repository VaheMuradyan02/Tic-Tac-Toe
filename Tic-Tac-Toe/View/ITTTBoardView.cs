using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.View
{
    internal interface ITTTBoardView
    {
        void UpdateStatus(string status);
        event EventHandler CheckCellEvent;
        event EventHandler ChooseFirstPlayerAsHumanEvent;
        event EventHandler ChooseFirstPlayerAsBotEvent;
        event EventHandler ChooseSecondPlayerAsHumanEvent;
        event EventHandler ChooseSecondPlayerAsBotEvent;
        event EventHandler ChooseBotEasyEvent;
        event EventHandler ChooseBotMediumEvent;
        event EventHandler ChooseBotHardEvent;
        event EventHandler ChooseStartGameEvent;
        event EventHandler ChooseRestartGameEvent;
        void Show();
    }
}
