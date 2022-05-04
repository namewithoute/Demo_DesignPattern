using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternDemoWithCSharp
{
    public class PhoneAnsweringSystem
    {
        public void SetHomeMessage()
        {
            Console.WriteLine("Phone Answering System - Home custom Message set");
        }
        public void SetAwayMessage()
        {
            Console.WriteLine("Phone Answering System - Away custom Message set");
        }
    }
}
