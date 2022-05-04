using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternDemoWithCSharp
{
    public class Lights
    {
        public void switchOnLights()
        {
            Console.WriteLine("Lights - Switched ON");
        }
        public void switchOffLights()
        {
            Console.WriteLine("Lights - Switched OFF");
        }
    }
    }
