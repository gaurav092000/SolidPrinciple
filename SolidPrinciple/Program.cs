using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(5);
            Rectangle rectangle =new Rectangle { length=4,breath=3};
            Calcalute(c);
            new Print().print(c);
            Console.ReadLine();
        }

        private static void  Calcalute (Circle c)
        {
          //  double area = 3.142 * c.Radius * c.Radius;
            Console.WriteLine(c.GetArea());
        }

        //private static void print(Circle c)
        //{
        //    Console.WriteLine(c);
        //}
        

    }
}
