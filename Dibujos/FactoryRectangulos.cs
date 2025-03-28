using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dibujos
{
    public class FactoryRectangulos
    {
        public float X { get; private set; }

        public class Rectangulo
        {
            public int txtX { get; set; }
            public int txtY { get; set; }
            public Color Color { get; set; }
            public Rectangulo(int x, int y, Color color)
            {
                txtX = x;
                txtY = y;
                Color = color;
            }
            public void Dibujar(Graphics g)
            {
                using (SolidBrush brush = new SolidBrush(Color))
                {
                    g.FillRectangle(brush, X, Y, 50, 50); // Tamaño fijo de 50x50
                }
            }
        }
        
    }


}
