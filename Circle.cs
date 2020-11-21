using System;
using System.Collections.Generic;
using System.Text;

namespace AreaOfCircle
{
    class Circle
    {
        public static void CalculateAreaOfCircle()
        {
            Console.Write("What is the radius of the circle?: ");

            string radiusInput = Console.ReadLine();
            double radius = double.Parse(radiusInput);

            Console.WriteLine("The area of the circle with a radius of " + radius + " is: " + (Math.PI * Math.Pow(radius, 2)));
            Console.WriteLine("The circumference of the circle with a radius of " + radius + " is: " + (2 * Math.PI * radius));
            Console.WriteLine("The diameter of the circle with a radius of " + radius + " is: " + (2 * radius));

            Console.Write("How many miles does your vehicle get per gallon of gasoline?:");

            string mpgInput = Console.ReadLine();
            double mpg = double.Parse(mpgInput);

            Console.WriteLine("You could travel around the circle " + mpg / (2 * Math.PI * radius) + " times!");
        }
    }
}
