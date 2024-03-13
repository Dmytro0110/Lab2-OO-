using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(7, 4);
            Fraction fraction2 = new Fraction(1, 2);

            Console.WriteLine("Дріб 1: " + fraction1);
            Console.WriteLine("Дріб 2: " + fraction2);

            Fraction sum = fraction1.Add(fraction2);
            Console.WriteLine("Сума: " + sum);

            Fraction difference = fraction1.Subtract(fraction2);
            Console.WriteLine("Різниця: " + difference);

            Fraction product = fraction1.Multiply(fraction2);
            Console.WriteLine("Добуток: " + product);

            Fraction quotient = fraction1.Divide(fraction2);
            Console.WriteLine("Частка: " + quotient);

            Fraction power = fraction1.Power(2);
            Console.WriteLine("Дріб 1 в квадраті: " + power);

            Console.WriteLine("Дріб 1 більше дробу 2? " + fraction1.IsGreaterThan(fraction2));
            Console.WriteLine("Дріб 1 менший дробу 2? " + fraction1.IsLessThan(fraction2));
            Console.WriteLine("Дріб 1 рівний дробу 2? " + fraction1.Equals(fraction2));
        }
    }
}
