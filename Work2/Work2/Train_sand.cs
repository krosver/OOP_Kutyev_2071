using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Work2
{
    class Train_sand: Train
    {
        public Point[] triangle = new Point[3];
        public Train_sand(int X, int Y, int Width, int Height)
            :base(X, Y, Width, Height)
        {
            name = "Train_sand";
            Start.X = X;
            Start.Y = Y;
            size.Width = Width;
            size.Height = Height;
            triangle[0] = new Point(Start.X + (Width / 2), Start.Y - Height / 3);
            triangle[1] = new Point(Start.X, Start.Y);
            triangle[2] = new Point(Start.X + Width, Start.Y);
        }
        public override void Draw(Graphics gr, Pen pen)
        {
            base.Draw(gr, pen);
            gr.DrawPolygon(pen, triangle);
        }
        public override void move(Point start, Point end)
        {
            base.move(start, end);
            int difX;
            int difY;
            difX = end.X - start.X;
            difY = end.Y - start.Y;
            triangle[0].X += difX;
            triangle[0].Y += difY;
            triangle[1].X += difX;
            triangle[1].Y += difY;
            triangle[2].X += difX;
            triangle[2].Y += difY;
        }
        public override bool IsPointInside(int x, int y)
        {
            int a = (triangle[0].X - x) * (triangle[1].Y - triangle[0].Y) - (triangle[1].X - triangle[0].X) * (triangle[0].Y - y);
            int b = (triangle[1].X - x) * (triangle[2].Y - triangle[1].Y) - (triangle[2].X - triangle[1].X) * (triangle[1].Y - y);
            int c = (triangle[2].X - x) * (triangle[0].Y - triangle[2].Y) - (triangle[0].X - triangle[2].X) * (triangle[2].Y - y);
            bool flag = false;
            if (base.IsPointInside(x, y) == true || ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0)))
                flag = true;
            return flag;
        }
    }
}
