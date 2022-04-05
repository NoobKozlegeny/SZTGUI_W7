using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SZTGUI_W7.Logic
{
    public class PongLogic : IGameModel
    {
        public double Movement { get; set; }
        public Ball Orb { get; set; }
        public Wall Barrier { get; set; }

        public event EventHandler Changed;

        System.Drawing.Size area;

        public void SetupLogic(double movement, Ball orb, Wall barrier)
        {
            Movement = movement;
            Orb = orb;
            Barrier = barrier;
        }

        public void Control(MoveEnum moveEnum)
        {
            switch (moveEnum)
            {
                case MoveEnum.left:
                    Barrier.Move(-10);
                    break;
                case MoveEnum.right:
                    Barrier.Move(10);
                    break;
                default:
                    break;
            }
            Changed?.Invoke(this, null);
        }

        public void TimeStep()
        {
            //bool inside = Orb.Move(new System.Drawing.Size((int)area.Width, (int)area.Height));

            //if (!inside)
            //{
            //    Orb.Rebound(area);
            //}

            Rect wallRect = new Rect(area.Width / 2, area.Height * 0.8, 300, 50);
            Rect ballRect = new Rect(area.Width / 2, area.Height / 2, 30, 30);

            //if (wallRect.IntersectsWith(ballRect))
            //{
            //    Orb.Move(area, true);
            //}
            //else
            //{
            //    Orb.Move(area, false);
            //}
        }
    }
}
