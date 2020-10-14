using System;
using System.Runtime.InteropServices;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 0;
            var b = 0;
            a = 17;
            b = 4;

            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            //Allow user to input the radius
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());

            //Calculate area of the circle
            var areaOfCircle = CalculateArea(radius);

            Console.WriteLine($"The area of a circle with radius of {radius} is {areaOfCircle}");



                }

        public static double CalculateArea(double radius)
        {
            return Math.PI * (radius * radius);

        }
        
        }


}
