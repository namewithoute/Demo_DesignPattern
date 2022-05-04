using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternDemoWithCSharp
{
    public class TV
    {
        public void switchOnTV()
        {
            Console.WriteLine("TV - Switched ON");
        }
        public void switchOffTV()
        {
            Console.WriteLine("TV - Switched OFF");
        }
    }
}
