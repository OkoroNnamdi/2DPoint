using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Point myPoint = new Point(2, 3);
            double myPointXCoord = myPoint.X; // Access a property
            double myPointYCoord = myPoint.Y; // Access a property
            Console.WriteLine("The X coordinate is: " + myPointXCoord);
            Console.WriteLine("The Y coordinate is: " + myPointYCoord);
            Console.ReadLine();
        }
    }
    }
class Point
{
    private double x;
    private double y;
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public double X
    {
        get { return this.x; }
        set { this.x = value; }
    }
    public double Y
    {
        get { return this.y; }
        set { this.y = value; }
    }
}


