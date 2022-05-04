using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPatternDemoWithCSharp
{
    public class Square : IGeometry
    {
        public void GetShape()
        {
            Console.WriteLine("This is a square shape object");
        }
        public void GetColor(int length)
        {
            if (length < 5)
            {
                Console.WriteLine("Square is filled with BLACK color");
            }
            else
            {
                Console.WriteLine("Square is filled with GREEN color");
            }
        }
    }
}
