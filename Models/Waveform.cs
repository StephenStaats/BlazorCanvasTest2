using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCanvasTest2.Models
{
    public class Waveform
    {
        public double Top { get; private set; }
        public double Left { get; private set; }
        public double Width { get; private set; }
        public double Height { get; private set; }
        public string Color { get; private set; }

        public double EraseX { get; set; }
        public double DrawX { get; set; }
        public double DrawY { get; set; }

        public Waveform(double left, double top, double width, double height, string color)
        {
            (Left, Top, Width, Height, Color) = (left, top, width, height, color);
        }

        //public void StepForward(double width, double height)
        //{
        //    X += XVel;
        //    Y += YVel;
        //    if (X < 0 || X > width)
        //        XVel *= -1;
        //    if (Y < 0 || Y > height)
        //        YVel *= -1;

        //    if (X < 0)
        //        X += 0 - X;
        //    else if (X > width)
        //        X -= X - width;

        //    if (Y < 0)
        //        Y += 0 - Y;
        //    if (Y > height)
        //        Y -= Y - height;
        //}
    }
}
