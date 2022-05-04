using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPatternDemoWithCSharp
{
    public class Rectangle : IGeometry
    {
        public void GetShape()
        {
            Console.WriteLine("This is a Rectangle shape object");
        }
        public void GetColor(int length)
        {
            if (length < 5)
            {
                Console.WriteLine("Rectangle is filled with BLUE color");
            }
            else
            {
                Console.WriteLine("Rectangle is filled with RED color");
            }
        }
    }
}
