using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Work2
{
    class Train:Figure
    {
        MyRectangle rect = new MyRectangle();
        MyCircle circle_left = new MyCircle();
        MyCircle circle_right = new MyCircle();
        public Train(int X, int Y, int Width, int Height)
        {
            int Radius;
            Point Wheel_left= new Point();
            Point Wheel_right= new Point();
            name = "Train";
            Start.X = X;
            Start.Y = Y;
            size.Width = Width;
            size.Height = Height;
            Radius = size.Width / 8;
            Wheel_left.X = Start.X + Radius;
            Wheel_left.Y = Start.Y + size.Height + Radius;
            Wheel_right.X = Start.X + size.Width - Radius;
            Wheel_right.Y = Start.Y + size.Height + Radius;

            rect = new MyRectangle(Start.X, Start.Y, size.Width, size.Height);
            circle_left = new MyCircle(Wheel_left.X, Wheel_left.Y, Radius);
            circle_right = new MyCircle(Wheel_right.X, Wheel_right.Y, Radius);

        }
        public Train()
        {
        }
        public override void Draw(Graphics gr, Pen pen)
        {
            rect.Draw(gr, pen);
            circle_left.Draw(gr, pen);
            circle_right.Draw(gr, pen);
        }
        public override void move(Point start, Point end)
        {
            rect.move(start, end);
            circle_left.move(start, end);
            circle_right.move(start, end);
        }
        public override bool IsPointInside(int x, int y)
        {
            bool flag = false;
            if (rect.IsPointInside(x,y)==true || circle_left.IsPointInside(x, y) == true || circle_right.IsPointInside(x, y) == true)
                flag = true;
            return flag;

        }

    }
}
