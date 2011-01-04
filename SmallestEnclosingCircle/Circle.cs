using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace SmallestEnclosingCircle
{
    class Circle
    {
        Point Center;
        double radius;

        private static double GetDistance(Point first, Point second)
        {
            return Math.Sqrt((first.X - second.X) * (first.X - second.X) + (first.Y - second.Y) * (first.Y - second.Y));
        }

        public Circle()
        {
            this.Center = new Point(0, 0);
            radius = 0;
        }

        public Circle(Point Center, double radius)
        {
            this.Center = Center;
            this.radius = radius;
        }

        public Circle(Point Center)
        {
            this.Center = Center;
            this.radius = 0;
        }

        public Circle(Point first, Point second)
        {
            Center = new Point((first.X + second.X) / 2, (first.Y + second.Y) / 2);
            radius = GetDistance(first, Center);
        }

        public Circle(Point p1, Point p2, Point p3)
        {
            try
            {
                double x = (p3.X * p3.X * (p1.Y - p2.Y) + (p1.X * p1.X + (p1.Y - p2.Y) * (p1.Y - p3.Y))
                          * (p2.Y - p3.Y) + p2.X * p2.X * (-p1.Y + p3.Y))
                          / (2 * (p3.X * (p1.Y - p2.Y) + p1.X * (p2.Y - p3.Y) + p2.X * (-p1.Y + p3.Y)));
                double y = (p2.Y + p3.Y) / 2 - (p3.X - p2.X) / (p3.Y - p2.Y) * (x - (p2.X + p3.X) / 2);
                Center = new Point((int)x, (int)y);
                radius = GetDistance(Center, p1);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error creating circle with three points: " + e.ToString());
            }

        }

        public Point getCenter()
        {
            return Center;
        }

        public double getRadius()
        {
            return radius;
        }

        public int belongsToCircle(Point other)
        {
            if (Math.Abs(GetDistance(Center, other) - radius) < 0.0001) return 0;
            if (GetDistance(Center, other) > radius) return -1;
            return 1;
        }
    }
}
