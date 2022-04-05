﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SZTGUI_W7.Logic
{
    public class Ball
    {
        public System.Drawing.Point Center { get; set; }
        public Vector Speed { get; set; }

        static Random r = new Random();

        private int Randomizer(int min, int max)
        {
            int rnd = 0;
            do
            {
                rnd = r.Next(min, max + 1);
            } while (rnd == 0);
            return rnd;
        }

        public Ball(Size area)
        {
            int vel = r.Next(0, 4); //0..3
            switch (vel)
            {
                case 0:
                    //fent
                    Center = new System.Drawing.Point
                        (r.Next(25, (int)area.Width - 25), 25);

                    Speed = new Vector(Randomizer(-20, 20),
                        Randomizer(1, 6));
                    break;
                case 1:
                    //lent
                    Center = new System.Drawing.Point(r.Next(25, (int)area.Width - 25)
                        , (int)area.Height - 25);
                    Speed = new Vector(Randomizer(-20, 20), Randomizer(-20, -1));
                    break;
                case 2:
                    //bal
                    Center = new System.Drawing.Point(25, r.Next(25,
                        (int)area.Height - 25));
                    Speed = new Vector(Randomizer(0, 20), Randomizer(-20, 20));
                    break;
                case 3:
                    //jobb
                    Center = new System.Drawing.Point((int)area.Width - 25, r.Next(25, (int)area.Height - 25));
                    Speed = new Vector(Randomizer(-20, -1), Randomizer(-20, 6));
                    break;
                default:
                    break;
            }
        }

        public bool Move(System.Drawing.Size area, bool intersect = false)
        {
            //hova kerülne a lépéskor az aszteroida
            System.Drawing.Point newCenter =
                new System.Drawing.Point(Center.X + (int)Speed.X,
                Center.Y + (int)Speed.Y);
            if (newCenter.X >= 0 &&
                newCenter.X <= area.Width &&
                newCenter.Y >= 0 &&
                newCenter.Y <= area.Height
                )
            {
                //pályán belül van az aszteroida

                //Találkozik-e a fallal
                if (intersect)
                {
                    Center = new System.Drawing.Point(
                        (Center.X + (int)Speed.X) * -1,
                        (Center.Y + (int)Speed.Y) * -1
                        );
                }
                else
                {
                    Center = newCenter;
                }
                return true;
            }
            else
            {
                //épp elhagyta a pályát
                return false;
            }
        }
    }
}
