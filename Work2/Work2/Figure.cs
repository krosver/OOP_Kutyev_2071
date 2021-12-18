using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;


namespace Work2
{
    abstract class Figure
    {
        public Point Start;
        public Size size;
        public string name;
        public virtual void move(Point start, Point end)
        { 
        }
        public virtual bool IsPointInside(int x, int y)
        {
            bool flag=true;
            return flag;
        }
        public virtual void del()
        {


        }
        public abstract void Draw(Graphics gr, Pen pen);
    }
}
