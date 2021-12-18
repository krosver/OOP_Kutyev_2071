using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int height;
        int width;
        List<Figure> obj = new List<Figure>();
        Point Start = new Point();
        Point End = new Point();
        Graphics gr;
        Pen blackPen = new Pen(Color.Black, 3);
        Pen WhitePen = new Pen(Color.White, 3);
        Figure figure;
        Figure change;

        private void Start_p(ref Point Start, ref Point End)
        {
            if (End.X < Start.X)
            {
                int t = End.X;
                End.X = Start.X;
                Start.X = t;
            }
            if (End.Y < Start.Y)
            {
                int t = End.Y;
                End.Y = Start.Y;
                Start.Y = t;
            }
            height = End.Y - Start.Y;
            width = End.X - Start.X;
        }
        private void Drow_panel_MouseDown(object sender, MouseEventArgs e)
        {
            Start.X = e.X;
            Start.Y = e.Y;
            gr = Drow_panel.CreateGraphics();
            MyCircle point = new MyCircle(Start.X, Start.Y);
            point.DrawPoint(gr,blackPen);
            foreach (Figure fig in obj)
            {
                if (fig.IsPointInside(Start.X, Start.Y) == true)
                {
                    change = fig;
                    break;
                }

            }
            // Выбор изменения
        }
        private void Drow_panel_MouseUp(object sender, MouseEventArgs e)
        {
            gr = Drow_panel.CreateGraphics();
            End.X = e.X;
            End.Y = e.Y;

            if (rb_move.Checked && change != null)
            {
                change.move(Start, End);
                change = null;
                Drow_panel.Refresh();
                return;
            }
            if (rb_del.Checked && change != null)
            {
                obj.Remove(change);
                change = null;
                Drow_panel.Refresh();
                return;
            }

            // Выбор фигуры
            if (rb_rect.Checked)
            {
                Start_p(ref Start, ref End);
                figure = new MyRectangle(Start.X, Start.Y, width, height);
            }
            else if (rb_circl.Checked)
            {
                height = End.Y - Start.Y;
                width = End.X - Start.X;
                figure = new MyCircle(Start.X, Start.Y, width,height);
            }
            else if (rb_train.Checked)
            {
                Start_p(ref Start, ref End);
                figure = new Train(Start.X, Start.Y, width, height);
            }
            // Выбор поезда
            if (sand_rb.Checked)
            {
                Start_p(ref Start, ref End);
                figure = new Train_sand(Start.X, Start.Y, width, height);
            }
            else if (Cargo_rb.Checked)
            {
                Start_p(ref Start, ref End);
                figure = new Train_cargo(Start.X, Start.Y, width, height);
            }
            // Отрисовка
            //figure.Draw(gr, blackPen);
            obj.Add(figure);
            Drow_panel.Refresh();



        }

        private void bt_del_Click(object sender, EventArgs e)
        {
            obj.Clear();
            Drow_panel.Refresh();
        }

        private void rb_rect_CheckedChanged(object sender, EventArgs e)
        {
            Train_box.Visible = false;
            sand_rb.Checked = false;
            Cargo_rb.Checked = false;
        }

        private void rb_circl_CheckedChanged(object sender, EventArgs e)
        {
            Train_box.Visible = false;
            sand_rb.Checked = false;
            Cargo_rb.Checked = false;
        }

        private void rb_train_CheckedChanged(object sender, EventArgs e)
        {
            Train_box.Visible = true;
        }
        Point pos;
        private void Drow_panel_MouseClick(object sender, MouseEventArgs e)
        {
            pos.X = e.X;
            pos.Y = e.Y;

        }

        private void Drow_panel_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figure fig in obj)
            {
                fig.Draw(gr, blackPen);
            }
        }

        private void rb_move_CheckedChanged_1(object sender, EventArgs e)
        {
            Train_box.Visible = false;
            sand_rb.Checked = false;
            Cargo_rb.Checked = false;
        }

        private void rb_del_CheckedChanged(object sender, EventArgs e)
        {
            Train_box.Visible = false;
            sand_rb.Checked = false;
            Cargo_rb.Checked = false;
        }
    }
}
