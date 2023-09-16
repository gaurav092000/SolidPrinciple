using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    internal class Circle
    {
        public Circle(double radius) 
        {
            Radius = radius;
        }

        public double Radius { get; set; } 

        public  double  GetArea()
        {
            return 3.142 * Radius * Radius;
        }

    }

     public class Rectangle
    {
        public double length { get; set; }

        public double breath { get; set; }

        public double  GetArea()
        {
            return length * breath;
        }
    }
}
