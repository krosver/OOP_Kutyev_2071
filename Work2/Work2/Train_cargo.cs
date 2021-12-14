using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Work2
{
    class Train_cargo:Train
    {
        MyRectangle cargo = new MyRectangle();
        public Train_cargo(int X, int Y, int Width, int Height)
            :base(X, Y, Width, Height)
        {
            Size Cargo_s= new Size();
            Point Cargo_p = new Point();
            name = "Train_cargo";
            Start.X = X;
            Start.Y = Y;
            size.Width = Width;
            size.Height = Height;
            Cargo_p.X = Start.X + (Width / 4);
            Cargo_p.Y = Start.Y - Height / 2;
            Cargo_s.Width = Width / 2;
            Cargo_s.Height = Height / 2;
            cargo = new MyRectangle(Cargo_p.X, Cargo_p.Y, Cargo_s.Width, Cargo_s.Height);
        }
        public override void Draw(Graphics gr, Pen pen)
        {
            base.Draw(gr, pen);
            cargo.Draw(gr, pen);
        }
        public override void move(Point start, Point end)
        {
            base.move(start, end);
            cargo.move(start, end);
        }
        public override bool IsPointInside(int x, int y)
        {
            bool flag = false;
            if (base.IsPointInside(x, y) == true || cargo.IsPointInside(x,y))
                flag = true;
            return flag;
        }
    }
}
