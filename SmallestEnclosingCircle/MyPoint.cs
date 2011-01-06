using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallestEnclosingCircle
{
    public class MyPoint
    {
        // The x corrdinate of a MyPoint
        private double x;
        // The y corrdinate of a MyPoint
        private double y;


        // Construct a MyPoint at the origin
        public MyPoint()
        {
            x = 0;
            y = 0;
        }
        // Construct a MyPoint at the specified location (xVal, yVal)
        public MyPoint(double xVal, double yVal)
        {
            x = xVal;
            y = yVal;
        }
        // Construct a MyPoint with the same location as the specified MyPoint
        public MyPoint(MyPoint MyPoint)
        {
            x = MyPoint.x;
            y = MyPoint.y;
        }


        // Get the x corrdinate
        public double getX()
        {
            return x;
        }
        // Get the y corrdinate
        public double getY()
        {
            return y;
        }
        // Set the x corrdinate
        public void setX(double xVal)
        {
            x = xVal;
        }
        // Set the y corrdinate
        public void setY(double yVal)
        {
            y = yVal;
        }


        // Translate a MyPoint to the specified location
        public void translate(MyPoint MyPoint)
        {
            translate(MyPoint.x, MyPoint.y);
        }
        // Translate a MyPoint to the specified location (newX, newY)
        public void translate(double newX, double newY)
        {
            x = newX;
            y = newY;
        }
        // Offset a MyPoint along the x and y axes by dx and dy, respectively
        public void offset(double dx, double dy)
        {
            x += dx;
            y += dy;
        }
        // Calcualte the distance between two MyPoints
        public double distance(MyPoint MyPoint)
        {
            double dx = x - MyPoint.x;
            double dy = y - MyPoint.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        // Calcualte the square of the distance between two MyPoints
        public double distance2(MyPoint MyPoint)
        {
            double dx = x - MyPoint.x;
            double dy = y - MyPoint.y;
            return (dx * dx + dy * dy);
        }
        // Calculate the middle MyPoint between two MyPoints
        public MyPoint midMyPoint(MyPoint MyPoint)
        {
            return new MyPoint((x + MyPoint.x) / 2, (y + MyPoint.y) / 2);
        }

        // Determine whether two MyPoints are equal
        public bool equals(MyPoint MyPoint)
        {
            return (x == MyPoint.x) && (y == MyPoint.y);
        }
        // Return a representation of a MyPoint as a string
        public String toString()
        {
            return "MyPoint = (" + x + "," + y + ")";
        }
    }
}
