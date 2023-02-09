using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestAss2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to Circle Program");
                Console.WriteLine("Please Enter the radius of the circle: ");
                int radius = Convert.ToInt32(Console.ReadLine());

                Circle circle = new Circle(radius);

                int choice;
                do
                {
                    Console.WriteLine("1. Get Circle Radius");
                    Console.WriteLine("2. Change Circle Radius");
                    Console.WriteLine("3. Get Circle Circumference");
                    Console.WriteLine("4. Get Circle Area");
                    Console.WriteLine("5. Exit");

                    Console.WriteLine("Enter your choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Radius of the circle is: " + circle.GetRadius());
                            break;
                        case 2:
                            Console.WriteLine("Please Enter the new radius: ");
                            int newRadius = Convert.ToInt32(Console.ReadLine());
                            circle.SetRadius(newRadius);
                            break;
                        case 3:
                            Console.WriteLine("Circumference of the circle is: " + circle.GetCircumference());
                            break;
                        case 4:
                            Console.WriteLine("Area of the circle is: " + circle.GetArea());
                            break;
                        case 5:
                            Console.WriteLine("Good Bye. See you super soon.");
                            break;
                        default:
                            Console.WriteLine("Please Enter from the options mentioned above.");
                            break;
                    }
                } while (choice != 5);
            }
            catch
            {
                Console.WriteLine("Please Enter Valid Values.");
            }
        }
    }
}
