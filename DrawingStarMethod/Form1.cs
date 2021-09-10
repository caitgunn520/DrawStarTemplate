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

            float scaleFactor = size / 105;

            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black);

            PointF[] star = new PointF[10];
            star[0] = new PointF((57 + xValue) * scaleFactor, (3 + yValue) * scaleFactor);
            star[1] = new PointF((70 + xValue) * scaleFactor, (43 + yValue) * scaleFactor);
            star[2] = new PointF((106 + xValue) * scaleFactor, (43 + yValue) * scaleFactor);
            star[3] = new PointF((77 + xValue) * scaleFactor, (69 + yValue) * scaleFactor);
            star[4] = new PointF((90 + xValue) * scaleFactor, (109 + yValue) * scaleFactor);
            star[5] = new PointF((57 + xValue) * scaleFactor, (84 + yValue) * scaleFactor);
            star[6] = new PointF((24 + xValue) * scaleFactor, (109 + yValue) * scaleFactor);
            star[7] = new PointF((36 + xValue) * scaleFactor, (69 + yValue) * scaleFactor);
            star[8] = new PointF((1 + xValue) * scaleFactor, (43 + yValue) * scaleFactor);
            star[9] = new PointF((44 + xValue) * scaleFactor, (43 + yValue) * scaleFactor);

            g.DrawPolygon(blackPen, star);
        }


        private void fillButton_Click(object sender, EventArgs e)
        {
            float xValue = Convert.ToSingle(xInput.Text);
            float yValue = Convert.ToSingle(yInput.Text);
            float size = Convert.ToSingle(sizeInput.Text);

            float scaleFactor = size / 105;

            Graphics g = this.CreateGraphics();
            SolidBrush blueBrush = new SolidBrush(Color.AliceBlue);

            PointF[] star = new PointF[10];
            star[0] = new PointF((57 + xValue) * scaleFactor, (3 + yValue) * scaleFactor);
            star[1] = new PointF((70 + xValue) * scaleFactor, (43 + yValue) * scaleFactor);
            star[2] = new PointF((106 + xValue) * scaleFactor, (43 + yValue) * scaleFactor);
            star[3] = new PointF((77 + xValue) * scaleFactor, (69 + yValue) * scaleFactor);
            star[4] = new PointF((90 + xValue) * scaleFactor, (109 + yValue) * scaleFactor);
            star[5] = new PointF((57 + xValue) * scaleFactor, (84 + yValue) * scaleFactor);
            star[6] = new PointF((24 + xValue) * scaleFactor, (109 + yValue) * scaleFactor);
            star[7] = new PointF((36 + xValue) * scaleFactor, (69 + yValue) * scaleFactor);
            star[8] = new PointF((1 + xValue) * scaleFactor, (43 + yValue) * scaleFactor);
            star[9] = new PointF((44 + xValue) * scaleFactor, (43 + yValue) * scaleFactor);

            g.FillPolygon(blueBrush, star);
        }

        public void DrawStar(Pen starPen, float x, float y, float pixels)
        {
  
        }

    }
}
