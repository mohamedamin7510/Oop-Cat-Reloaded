using System;
using Task2_oop.RectangleClass;
namespace Task2_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var F_rectangle = new Rectangle(5,4);
            print(F_rectangle);

            var s_rectangle = new Rectangle(10.2,10.3);
            print(s_rectangle);

            var th_rectangle = new Rectangle(6,9);
            print(th_rectangle);
        }


        /// <summary>
        /// this method for printing perimeter and area for rectangle
        /// </summary>
        /// <param name="x"></param>
        public static void print(Rectangle x) 
        {
            Console.WriteLine($"the perimeter is equal: {x.Perimeter()} \n" +
                  $"the Area is equal: {x.Area()}");
            Console.WriteLine("*-----------*");
        }
    }
}
