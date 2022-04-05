using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SZTGUI_W7.Logic
{
    public class PongLogic : IGameModel, IGameControl
    {
        public double Position { get; set; }
        public Ball Orb { get; set; }
        public Wall Barrier { get; set; }

        public event EventHandler Changed;

        System.Drawing.Size area;

        public void SetupLogic(double position, Ball orb, Wall barrier)
        {
            Position = position;
            Orb = orb;
            Barrier = barrier;
        }

        public void Move(MoveEnum moveEnum)
        {
            switch (moveEnum)
            {
                case MoveEnum.left:
                    Position -= 10;
                    break;
                case MoveEnum.right:
                    Position += 10;
                    break;
                default:
                    break;
            }
            Changed?.Invoke(this, null);
        }

        public void TimeStep()
        {
            Rect wallRect = new Rect(area.Width / 2, area.Height * 0.8, 300, 50);
            Rect ballRect = new Rect(area.Width / 2, area.Height / 2, 30, 30);

            if (wallRect.IntersectsWith(ballRect))
            {
                Orb.Move(area, true);
            }
            else
            {
                Orb.Move(area, false);
            }
        }
    }
}
