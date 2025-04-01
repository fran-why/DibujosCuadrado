using System;
using System.Drawing;
using System.Windows.Forms;

namespace RectanglesFactoryApp
{
    public partial class Form1 : Form
    {
        private int rectangleCount = 0;

        public Form1()
        {
            InitializeComponent();
            btnCREATOR.Click += new EventHandler(btnCREATOR_Click);
            CajaColor.Click += new EventHandler(CajaColor_Click);
            txtRectangleCount.Text = "0";
            txtRectangleCount.ReadOnly = true;
        }

        private void btnCREATOR_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtX.Text, out int x) || !int.TryParse(txtY.Text, out int y))
            {
                MessageBox.Show("Introduce valores numéricos válidos en X y Y.");
                return;
            }

            Color color = CajaColor.BackColor;
            RectangleShape rectangle = RectangleFactory.CreateRectangle(x, y, color);

            using (Graphics g = panel1.CreateGraphics())
            {
                using (Brush brush = new SolidBrush(color))
                {
                    g.FillRectangle(brush, rectangle.X, rectangle.Y, 50, 50);
                }
            }

            rectangleCount++;
            txtRectangleCount.Text = rectangleCount.ToString();
        }

        private void CajaColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    CajaColor.BackColor = colorDialog.Color;
                }
            }
        }
    }
}
