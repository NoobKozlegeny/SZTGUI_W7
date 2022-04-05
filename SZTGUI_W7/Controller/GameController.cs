using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SZTGUI_W7.Logic;

namespace SZTGUI_W7.Controller
{
    public class GameController 
    {
        IGameControl gameControl;
        public GameController(IGameControl gameControl)
        {
            this.gameControl = gameControl;
        }

        public void KeyPressed(Key key)
        {
            switch (key)
            {
                case Key.Left:
                    gameControl.Move(MoveEnum.left); break;
                case Key.Right:
                    gameControl.Move(MoveEnum.right); break;
                default:
                    break;
            }
        }
    }
}
