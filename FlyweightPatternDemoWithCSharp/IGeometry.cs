using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPatternDemoWithCSharp
{
    public interface IGeometry
    {
        void GetShape();
        void GetColor(int size);
    }
}
