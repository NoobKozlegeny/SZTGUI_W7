using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace SZTGUI_W7.Logic
{
    public class Ball : GameItem
    {
        private int centerX;
        private int centerY;
        private int radius;

        private int speedX;
        private int speedY;

        public Ball(int centerX, int centerY, int radius, int speedX, int speedY)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            this.radius = radius;
            this.speedX = speedX;
            this.speedY = speedY;
        }

        public void Move(int X, int Y)
        {
            speedX = X;
            speedY = Y;
            centerX += speedX;
            centerY += speedY;
        }

        public void Collision()
        {
            speedX *= -1;
            speedY *= -1;
        }

        public override Geometry Area
        {
            get
            {
                return new EllipseGeometry(new Point(centerX, centerY), radius, radius);
            }
        }
    }
}
