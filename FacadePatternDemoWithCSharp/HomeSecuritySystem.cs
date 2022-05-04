using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternDemoWithCSharp
{
    public class HomeSecuritySystem
    {
        public void EnableSecuritySystem()
        {
            Console.WriteLine("Security System - Enabled");
        }
        public void DisableSecuritySystem()
        {
            Console.WriteLine("Security System - Disabled");
        }
    }

}
