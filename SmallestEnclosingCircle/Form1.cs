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
            double dist = GetDistance((Point)points[0], (Point)points[1]);
            g.DrawArc(new Pen(Color.Red), centre.X, centre.Y, (int)dist, (int)dist, 0, 360);
        }

        private void ClearPoints_Click(object sender, EventArgs e)
        {
            Bitmap cleanBitmap = new Bitmap(this.MainDrawingArea.Width, this.MainDrawingArea.Height);
            this.MainDrawingArea.Image = cleanBitmap;
            points.Clear();
        }

        private double GetDistance(Point first, Point second)
        {
            return Math.Sqrt((first.X - second.X) * (first.X - second.X) + (first.Y - second.Y) * (first.Y - second.Y));
        }

        private ArrayList points;
        private Graphics g;
    }
}
