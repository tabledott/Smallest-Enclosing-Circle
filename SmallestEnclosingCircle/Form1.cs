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
            Circle(Point Center, double radius)
            {
                this.Center = Center;
                this.radius = radius;
            }
            bool belongsToCircle(Point other)
            {
                return Math.Abs(GetDistance(Center, other) - radius) < 0.0001;
            }
        }

        public Form1()
        {
            InitializeComponent();
            points = new ArrayList();
            g = this.MainDrawingArea.CreateGraphics();
        }

        private void MainDrawingArea_MouseClick(object sender, MouseEventArgs e)
        {
            points.Add(new Point(e.X, e.Y));
            g.DrawRectangle(new Pen(Color.Red), e.X, e.Y, 1, 1);
        }

        private void DrawCircle_Click(object sender, EventArgs e)
        {
            Point centre = (Point)points[0];
            int r = (int)GetDistance((Point)points[0], (Point)points[1]);
            int x = centre.X - r;
            int y = centre.Y - r;
            int width = 2 * r;
            int height = 2 * r;
            g.DrawArc(new Pen(Color.Red), x, y, width, height, 0, 360);
        }

        private void ClearPoints_Click(object sender, EventArgs e)
        {
            Bitmap cleanBitmap = new Bitmap(this.MainDrawingArea.Width, this.MainDrawingArea.Height);
            this.MainDrawingArea.Image = cleanBitmap;
            points.Clear();
        }

        private static double GetDistance(Point first, Point second)
        {
            return Math.Sqrt((first.X - second.X) * (first.X - second.X) + (first.Y - second.Y) * (first.Y - second.Y));
        }

        private ArrayList points;
        private Graphics g;

    }
}
