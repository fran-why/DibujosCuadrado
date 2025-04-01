using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RectanglesFactoryApp
{
    public partial class MainForm : Form
    {
        private readonly List<RectangleShape> rectangles = new List<RectangleShape>();
        private int rectangleCount = 0;

        public MainForm()
        {
            InitializeComponent();
        }
        
        private void BtnCREATOR_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtX.Text);
            int y = int.Parse(txtY.Text);
            Color color = CajaColor.BackColor;

            RectangleShape rectangle = RectangleFactory.CreateRectangle(x, y, color);
            rectangles.Add(rectangle);
            rectangleCount++;
            txtRectangleCount.Text = rectangleCount.ToString();
            this.Invalidate();
    }

}
