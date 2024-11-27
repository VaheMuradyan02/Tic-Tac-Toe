using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace TicTacToeWPF
{
    public class CellCheckedEventArgs : EventArgs
    {
        public BitmapImage XImage { get; }
        public BitmapImage OImage { get; }

        public CellCheckedEventArgs(BitmapImage xImage, BitmapImage oImage)
        {
            XImage = xImage;
            OImage = oImage;
        }
    }
}
