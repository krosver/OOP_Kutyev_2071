using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool Check(string tb)
        {
            bool check = false;
            for (int i = 0; i < tb.Length; i++)
            {
                if (Char.IsDigit(tb[i]))
                {
                    check = true;
                }
                else
                {
                    check = false;
                    break;
                }
            }
            return check;
        }
        private void bt_sum_Click(object sender, EventArgs e)
        {
            bool flag = this.Check(tb_1.Text);
            bool flag2 = this.Check(tb_2.Text);
            bool flag3 = this.Check(tb_3.Text);
            bool flag4 = this.Check(tb_4.Text);
            if (flag&&flag2&&flag3&&flag4)
            {
                label1.Text = "+";
                Rational r1 = new Rational(Convert.ToInt32(tb_1.Text), Convert.ToInt32(tb_2.Text));
                Rational r2 = new Rational(Convert.ToInt32(tb_3.Text), Convert.ToInt32(tb_4.Text));
                Rational Sum = new Rational();
                Sum = r1 + r2;
                tb_result.Text = Sum.ToString();
            }
            else { MessageBox.Show("Error, incorrect form"); }
        }

        private void bt_subtract_Click(object sender, EventArgs e)
        {
            bool flag = this.Check(tb_1.Text);
            bool flag2 = this.Check(tb_2.Text);
            bool flag3 = this.Check(tb_3.Text);
            bool flag4 = this.Check(tb_4.Text);
            if (flag && flag2 && flag3 && flag4)
            {
                label1.Text = "-";
                Rational r1 = new Rational(Convert.ToInt32(tb_1.Text), Convert.ToInt32(tb_2.Text));
                Rational r2 = new Rational(Convert.ToInt32(tb_3.Text), Convert.ToInt32(tb_4.Text));
                Rational Sub = new Rational();
                Sub = r1 - r2;
                tb_result.Text = Sub.ToString();
            }
            else { MessageBox.Show("Error, incorrect form"); }
        }

        private void bt_div_Click(object sender, EventArgs e)
        {
            bool flag = this.Check(tb_1.Text);
            bool flag2 = this.Check(tb_2.Text);
            bool flag3 = this.Check(tb_3.Text);
            bool flag4 = this.Check(tb_4.Text);
            if (flag && flag2 && flag3 && flag4)
            {
                label1.Text = "/";
                Rational r1 = new Rational(Convert.ToInt32(tb_1.Text), Convert.ToInt32(tb_2.Text));
                Rational r2 = new Rational(Convert.ToInt32(tb_3.Text), Convert.ToInt32(tb_4.Text));
                Rational Div = new Rational();
                Div = r1 / r2;
                tb_result.Text = Div.ToString();
            }
            else { MessageBox.Show("Error, incorrect form"); }
        }

        private void bt_multi_Click(object sender, EventArgs e)
        {
            bool flag = this.Check(tb_1.Text);
            bool flag2 = this.Check(tb_2.Text);
            bool flag3 = this.Check(tb_3.Text);
            bool flag4 = this.Check(tb_4.Text);
            if (flag && flag2 && flag3 && flag4)
            {
                label1.Text = "*";
                Rational r1 = new Rational(Convert.ToInt32(tb_1.Text), Convert.ToInt32(tb_2.Text));
                Rational r2 = new Rational(Convert.ToInt32(tb_3.Text), Convert.ToInt32(tb_4.Text));
                Rational Mult = new Rational();
                Mult = r1 * r2;
                tb_result.Text = Mult.ToString();
            }
            else { MessageBox.Show("Error, incorrect form"); }
        }

        private void bt_reduction_Click(object sender, EventArgs e)
        {
            Rational result = Rational.Reduction(Rational.ToRational(tb_result.Text));
            tb_result.Text = result.ToString();
        }
    }
}
