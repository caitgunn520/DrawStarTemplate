using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawingStarMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            ///The following line of code demonstrates how to get input
            ///and convert it to a float value. Use this to help you in 
            ///Parts 2 - 4 where you need to get inputs from the 
            ///user and store them in float variables. This code is 
            ///not needed for Part 1.

            ///float size = Convert.ToSingle(sizeInput.Text); 

            float xValue = Convert.ToSingle(xInput.Text);
            float yValue = Convert.ToSingle(yInput.Text);
            float size = Convert.ToSingle(sizeInput.Text);

            Pen blackPen = new Pen(Color.Black);

            DrawStar(blackPen, xValue, yValue, size);
        }


        private void fillButton_Click(object sender, EventArgs e)
        {
            float xValue = Convert.ToSingle(xInput.Text);
            float yValue = Convert.ToSingle(yInput.Text);
            float size = Convert.ToSingle(sizeInput.Text);

            SolidBrush blueBrush = new SolidBrush(Color.AliceBlue);

            FillStar(blueBrush, xValue, yValue, size);
        }

        public void DrawStar(Pen pen, float x, float y, float size)
        {
            float scaleFactor = size / 105;

            Graphics g = this.CreateGraphics();

            PointF[] star = new PointF[10];
            star[0] = new PointF((57 + x) * scaleFactor, (3 + y) * scaleFactor);
            star[1] = new PointF((70 + x) * scaleFactor, (43 + y) * scaleFactor);
            star[2] = new PointF((106 + x) * scaleFactor, (43 + y) * scaleFactor);
            star[3] = new PointF((77 + x) * scaleFactor, (69 + y) * scaleFactor);
            star[4] = new PointF((90 + x) * scaleFactor, (109 + y) * scaleFactor);
            star[5] = new PointF((57 + x) * scaleFactor, (84 + y) * scaleFactor);
            star[6] = new PointF((24 + x) * scaleFactor, (109 + y) * scaleFactor);
            star[7] = new PointF((36 + x) * scaleFactor, (69 + y) * scaleFactor);
            star[8] = new PointF((1 + x) * scaleFactor, (43 + y) * scaleFactor);
            star[9] = new PointF((44 + x) * scaleFactor, (43 + y) * scaleFactor);

            g.DrawPolygon(pen, star);
        }

        public void FillStar(SolidBrush brush, float x, float y, float size)
        {
            float scaleFactor = size / 105;

            Graphics g = this.CreateGraphics();

            PointF[] star = new PointF[10];
            star[0] = new PointF((57 + x) * scaleFactor, (3 + y) * scaleFactor);
            star[1] = new PointF((70 + x) * scaleFactor, (43 + y) * scaleFactor);
            star[2] = new PointF((106 + x) * scaleFactor, (43 + y) * scaleFactor);
            star[3] = new PointF((77 + x) * scaleFactor, (69 + y) * scaleFactor);
            star[4] = new PointF((90 + x) * scaleFactor, (109 + y) * scaleFactor);
            star[5] = new PointF((57 + x) * scaleFactor, (84 + y) * scaleFactor);
            star[6] = new PointF((24 + x) * scaleFactor, (109 + y) * scaleFactor);
            star[7] = new PointF((36 + x) * scaleFactor, (69 + y) * scaleFactor);
            star[8] = new PointF((1 + x) * scaleFactor, (43 + y) * scaleFactor);
            star[9] = new PointF((44 + x) * scaleFactor, (43 + y) * scaleFactor);

            g.FillPolygon(brush, star);
        }

    }
}
