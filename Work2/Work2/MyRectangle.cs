using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Work2
{
    class MyRectangle: Figure
    {
        
        public MyRectangle(int X, int Y, int Width, int Height)
        {
            Start.X = X;
            Start.Y = Y;
            size.Width = Width;
            size.Height = Height;
            name = "rectangle";
        }
        public MyRectangle()
        {
        }
        public override void Draw(Graphics gr, Pen pen)
        {
            gr.DrawRectangle(pen, Start.X, Start.Y, size.Width, size.Height);
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
            if ((x >= Start.X) && (x <= Start.X + size.Width) && (y >= Start.Y) && (y <= Start.Y + size.Height))
                flag = true;
            return flag;

        }
        public override void del()
        {

        }

    }
}
