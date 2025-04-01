using System.Drawing;

namespace RectanglesFactoryApp
{
    public class RectangleShape
    {
        public int X { get; }
        public int Y { get; }
        public Color Color { get; }

        public RectangleShape(int x, int y, Color color)
        {
            X = x;
            Y = y;
            Color = color;
        }
    }
}
