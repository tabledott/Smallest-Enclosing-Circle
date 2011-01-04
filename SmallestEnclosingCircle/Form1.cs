using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace SmallestEnclosingCircle
{

    public partial class Form1 : Form
    {
        private class Circle
        {
            Point Center;
            double radius;

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
                    MessageBox.Show("Error creating circle with three points: " +   e.ToString());
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
               if( Math.Abs(GetDistance(Center, other) - radius) < 0.0001 ) return 0;
               if (GetDistance(Center, other) > radius) return -1;
               return 1;
            }
        }

        public Form1()
        {
            InitializeComponent();
            points = new ArrayList();
            g = this.MainDrawingArea.CreateGraphics();
            p = new Point[1000];
            b = new Point[3];
            sec = new Circle();
            prev_x = prev_y = prev_width = prev_height = 0;
        }

        private Point[] p;					// points input by the user
        private int n = 0;					// Number of points input by the user
        private Point[] b;					// Points on the boundary of the circle
        private Circle sec;				// Smallest Enclosing Circle
        private int prev_x, prev_y, prev_width, prev_height;

        private Circle findSec(int n, Point[] p, int m, Point[] b)
        {
            Circle sec = new Circle();

            // Compute the Smallest Enclosing Circle defined by B
            if (m == 1)
            {
                sec = new Circle(b[0]);
            }
            else if (m == 2)
            {
                sec = new Circle(b[0], b[1]);
            }
            else if (m == 3)
            {
                return new Circle(b[0], b[1], b[2]);
            }

            // Check if all the points in p are enclosed
            for (int i = 0; i < n; i++)
            {   
                //if the point is outside the circle
                if (sec.belongsToCircle(p[i]) == -1)
                {
                    // Compute B <--- B union P[i].
                    b[m] = new Point(p[i].X, p[i].Y);
                    // Recurse
                    sec = findSec(i, p, m + 1, b);
                }
            }

            return sec;
        }


        private void MainDrawingArea_MouseClick(object sender, MouseEventArgs e)
        {
            points.Add(new Point(e.X, e.Y));
            g.DrawArc(new Pen(Color.Red), (float)e.X, (float)e.Y, (float)3.0, (float)3.0, (float)0.0, (float)360.0);
            p[n++] = new Point(e.X, e.Y);
            sec = findSec(n, p, 0, b);
            if (n > 1)
            {
                try
                {
                    Point center = sec.getCenter();
                    int r = (int) sec.getRadius();
                    if (prev_height > 0)
                    {
                        g.DrawArc(new Pen(Color.White), prev_x, prev_y, prev_width, prev_height, 0, 360);
                    }
                    int x = center.X - r; prev_x = x;
                    int y = center.Y - r; prev_y = y;
                    int width = 2 * r; prev_width = width;
                    int height = 2 * r; prev_height = height;
                    g.DrawArc(new Pen(Color.Blue), x, y, width, height, 0, 360);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private static double GetDistance(Point first, Point second)
        {
            return Math.Sqrt((first.X - second.X) * (first.X - second.X) + (first.Y - second.Y) * (first.Y - second.Y));
        }

        private ArrayList points;
        private Graphics g;

        private void ClearPoints_Click_1(object sender, EventArgs e)
        {
            Bitmap cleanBitmap = new Bitmap(this.MainDrawingArea.Width, this.MainDrawingArea.Height);
            this.MainDrawingArea.Image = cleanBitmap;
            points.Clear();
            p = new Point[1000];
            b = new Point[3];
            sec = new Circle();
            n = 0; prev_x = prev_y = prev_height = prev_width = 0;
        }

    }
}
