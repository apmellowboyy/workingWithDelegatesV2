using System;

namespace Assignment8ex2
{
    class Program
    {
        public delegate void bruhDelegate(double x, double y);

        public class MathSolutions
        {

            static void GetSum(double x, double y)
            {
                Console.WriteLine($"Result of {x+y}");
            }
            static double GetProduct(double a, double b)
            {
                return a * b;
            }
            public void GetSmaller(double a, double b)
            {
                if (a < b)
                    Console.WriteLine($" {a} is smaller than {b}");
                else if (b < a)
                    Console.WriteLine($" {b} is smaller than {a}");
                else
                    Console.WriteLine($" {b} is equal to {a}");
            }
            static void Main(string[] args)
            {
                Action<double, double> calculate = GetSum;
                calculate(5, 5);

                Func<double, double, double> calculate2 = GetProduct;
                Console.WriteLine(calculate2(5, 5));// create a class object
                MathSolutions answer = new MathSolutions();
                Random r = new Random();
                double num1 = Math.Round(r.NextDouble()*100);
                double num2 = Math.Round(r.NextDouble()*100);
                answer.GetSmaller(num1, num2);

                bruhDelegate d1 = new bruhDelegate(answer.GetSmaller);


                d1(num1, num2);
            }
        }
    }
}