using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Знаменник не може дорівнювати нулю!");
            this.numerator = numerator;
            this.denominator = denominator;
            Simplify();
        }

        public Fraction(Fraction other)
        {
            this.numerator = other.numerator;
            this.denominator = other.denominator;
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private void Simplify()
        {
            int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator));
            numerator /= gcd;
            denominator /= gcd;
            if (denominator < 0)
            {
                numerator *= -1;
                denominator *= -1;
            }
        }

        public Fraction Add(Fraction other)
        {
            int newNumerator = this.numerator * other.denominator + other.numerator * this.denominator;
            int newDenominator = this.denominator * other.denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        public Fraction Subtract(Fraction other)
        {
            int newNumerator = this.numerator * other.denominator - other.numerator * this.denominator;
            int newDenominator = this.denominator * other.denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        public Fraction Multiply(Fraction other)
        {
            int newNumerator = this.numerator * other.numerator;
            int newDenominator = this.denominator * other.denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        public Fraction Divide(Fraction other)
        {
            int newNumerator = this.numerator * other.denominator;
            int newDenominator = this.denominator * other.numerator;
            return new Fraction(newNumerator, newDenominator);
        }

        public Fraction Power(int exponent)
        {
            int newNumerator = (int)Math.Pow(this.numerator, exponent);
            int newDenominator = (int)Math.Pow(this.denominator, exponent);
            return new Fraction(newNumerator, newDenominator);
        }

        public bool Equals(Fraction other)
        {
            return this.numerator == other.numerator && this.denominator == other.denominator;
        }

        public bool IsGreaterThan(Fraction other)
        {
            return this.numerator * other.denominator > other.numerator * this.denominator;
        }

        public bool IsLessThan(Fraction other)
        {
            return this.numerator * other.denominator < other.numerator * this.denominator;
        }

        public override string ToString()  
        {
            return numerator + "/" + denominator;
        }
    }
}
