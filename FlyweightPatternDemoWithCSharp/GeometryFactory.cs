using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPatternDemoWithCSharp
{
    public class GeometryFactory
    {
        Dictionary<string, IGeometry> geometries = new Dictionary<string, IGeometry>();
        public int ObjectCount()
        {
            return geometries.Count;
        }
        public IGeometry getGeometryObject(string name)
        {
            IGeometry geometry;
            if (geometries.ContainsKey(name))
            {
                return geometries[name];
            }
            else
            {
                if (name == "Rectangle")
                {
                    geometry = new Rectangle();
                    geometries.Add("Rectangle", geometry);
                }
                else if (name == "Square")
                {
                    geometry = new Square();
                    geometries.Add("Square", geometry);
                }
                else
                {
                    throw new Exception("This type of object can not be created");
                }
            }
            return geometry;
        }
    }
}
