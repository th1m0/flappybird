using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    /// <summary>
    /// Extended Panel to use OptimezedDoubleBuffer
    /// to remove glitches when flappy moves.
    /// </summary>
    class GamePanel : Panel
    {
        public GamePanel()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);
        }
    }
}
