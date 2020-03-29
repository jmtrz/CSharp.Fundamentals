using System;
using System.Collections.Generic;
using System.Text;

namespace MethodDemo
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {
            if (newLocation == null)
                throw new ArgumentNullException("newLocation");
            //this.X = newLocation.X;
            //this.Y = newLocation.Y;
            Move(newLocation.X,newLocation.Y);
        }

    }
}
