using System.Drawing;

namespace RectanglesFactoryApp
{
    public static class RectangleFactory
    {
        public static RectangleShape CreateRectangle(int x, int y, Color color)
        {
            return new RectangleShape(x, y, color);
        }
    }
}
