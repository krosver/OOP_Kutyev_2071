using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
namespace Work2
{
    class MyCircle: Figure
    {
        int Radius;
        Point Draw_point;
        public MyCircle(int X, int Y, int Width, int Height)
        {
            size.Width = (int)Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2));
            Radius = (int)Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2));
            Start.X = X-Radius;
            Start.Y = Y-Radius;
            name = "circle";
        }
        public MyCircle(int X, int Y, int radius)
        {
            Radius = radius;
            Start.X = X - Radius;
            Start.Y = Y - Radius;
        }
        public MyCircle(int x, int y)
        {
            Draw_point.X = x;
            Draw_point.Y = y;
        }
        public MyCircle()
        {
        }
        public override void Draw(Graphics gr, Pen pen)
        {
            gr.DrawEllipse(pen, Start.X, Start.Y, Radius * 2, Radius * 2);
        }
        public void DrawPoint(Graphics gr, Pen pen)
        {
            gr.DrawEllipse(pen, Draw_point.X, Draw_point.Y, 1, 1);
        }
        public override void move(Point start, Point end)
        {
            int difX;
            int difY;
            difX = end.X - start.X;
            difY = end.Y - start.Y;
            Start.X += difX;
            Start.Y += difY;
        }
        public override bool IsPointInside(int x, int y)
        {
            bool flag = false;
            if ((Math.Pow((x - (Start.X + Radius)), 2) + Math.Pow((y - (Start.Y+Radius)), 2)) <= (Math.Pow(Radius,2)))
                flag = true;
            return flag;
        }
    }
}
