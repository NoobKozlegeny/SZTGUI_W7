using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SZTGUI_W7.Logic
{
    public class Wall
    {
        private int centerX;
        private int centerY;
        private int radius;

        private int speedX;

        public Wall(int centerX, int centerY, int radius, int speedX)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            this.radius = radius;
            this.speedX = speedX;
        }

        public void Move(int X)
        {
            speedX = X;
            centerX += speedX;
        }
        //public Wall(System.Drawing.Point center, Vector speed)
        //{
        //    Center = center;
        //    Speed = speed;
        //}

        //public System.Drawing.Point Center { get; set; }
        //public Vector Speed { get; set; }

        //public bool Move(System.Drawing.Size area)
        //{
        //    //hova kerülne a lépéskor az aszteroida
        //    System.Drawing.Point newCenter =
        //        new System.Drawing.Point(Center.X + (int)Speed.X,
        //        Center.Y + (int)Speed.Y);
        //    if (newCenter.X >= 0 &&
        //        newCenter.X <= area.Width &&
        //        newCenter.Y >= 0 &&
        //        newCenter.Y <= area.Height
        //        )
        //    {
        //        //pályán belül van az aszteroida
        //        Center = newCenter;
        //        return true;
        //    }
        //    else
        //    {
        //        //épp elhagyta a pályát
        //        return false;
        //    }
        //}
    }
}
