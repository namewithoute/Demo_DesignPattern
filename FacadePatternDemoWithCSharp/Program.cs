using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternDemoWithCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeFacade homeFacade = new HomeFacade();
            Console.WriteLine("--------------- Leave Home for Office Control----------------");
            homeFacade.LeaveHomeforOffice();
            Console.WriteLine("--------------- Arrive Home From Office Control----------------");
            homeFacade.ArriveHomefromOffice();
            Console.ReadLine();
        }
    }
}
