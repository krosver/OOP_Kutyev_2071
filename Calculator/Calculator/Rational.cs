using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Rational
    {
        public int numerator;
        public int denumerator;
        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public Rational(int one, int two)
        {
            this.numerator = one;
            this.denumerator = two;
        }
        public Rational()
        {

        }
        public static Rational operator+(Rational r1, Rational r2)
        {
            return r1.Sum(r2);
        }
        public static Rational operator-(Rational r1, Rational r2)
        {
            return r1.Subtract(r2);
        }
        public static Rational operator*(Rational r1, Rational r2)
        {
            return r1.Multiply(r2);
        }
        public static Rational operator/(Rational r1, Rational r2)
        {
            return r1.Divide(r2);
        }
        // Sum_block start
        public Rational Sum(Rational other)
		{
            Rational sum = new Rational();
            sum.numerator = (this.numerator * other.denumerator) + (this.denumerator * other.numerator);
            sum.denumerator = this.denumerator * other.denumerator;
            return sum;
        }
        // Sum_block end

        // Sub_block start
        public Rational Subtract(Rational other)
        {
            Rational sub = new Rational();
            sub.numerator = (this.numerator * other.denumerator) - (this.denumerator * other.numerator);
            sub.denumerator = this.denumerator * other.denumerator;
            return sub;
        }
        // Sub_block end 

        // Multiply_block start
        public Rational Multiply(Rational other)
        {
            Rational Multiply = new Rational();
            Multiply.numerator = this.numerator * other.numerator;
            Multiply.denumerator = this.denumerator * other.denumerator;
            return Multiply;
        }
        // Multiply_block end


        // divide_block start
        public Rational Divide(Rational other)
        {
            Rational Divide = new Rational();
            Divide.numerator = this.numerator * other.denumerator;
            Divide.denumerator = this.denumerator * other.numerator;
            return Divide;
        }
        // divide_block end

        public static int NOD(int one, int two)
        {
            while (one != two)
            {
                if (one < two)
                {
                    two -= one;
                }
                else 
                {
                    one -= two;
                }
            }
            int nod = one;
            return nod;
            
        }
        public static Rational Reduction(Rational numb)
        {
            int nod = Rational.NOD(numb.numerator, numb.denumerator);
            numb.numerator = numb.numerator / nod;
            numb.denumerator = numb.denumerator / nod;
            return numb;
        }

        public override string ToString()
        {
            string str = (this.numerator + " / " + this.denumerator);
            return str;
        }
        public  static Rational ToRational(string str)
        {
            string [] result = str.Split('/');
            Rational rat= new Rational();
            rat.numerator =Convert.ToInt32(result[0]);
            rat.denumerator = Convert.ToInt32(result[1]);
            return rat;
        }
    }

}
