using System.Drawing;

namespace Shapes;

public class Point
{
    public int X;
    public int Y;

    public Color Color;
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

}

public class Circle
{
    public Point Centre;
    public int Radious;

    public Color FillColor;
    public Color OutlineColor;

}
