using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_oop.RectangleClass
{
    internal class Rectangle
    {
        private double Length { get; set; }
        private double Width { get; set; }
        public Rectangle(double length,double width)
        {
            this.Length = length;
            this.Width = width;
        }
        public double Area()
        {
            var result = Length * Width;
            return result;
        }
        public double Perimeter() 
        {
            var result= (Length+Width)*2;
            return result;
        }
    }
}
