using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternDemoWithCSharp
{
    public class HomeFacade
    {
        Lights light;
        MusicSystem musicSystem;
        TV tv;
        HomeSecuritySystem securitySystem;
        PhoneAnsweringSystem phoneAnsweringSystem;
        //constructor of facade class that will instantiate required subsystems
        public HomeFacade()
        {
            light = new Lights();
            musicSystem = new MusicSystem();
            tv = new TV();
            securitySystem = new HomeSecuritySystem();
            phoneAnsweringSystem = new PhoneAnsweringSystem();
        }
        //'operation in facade class'
        public void LeaveHomeforOffice()
        {
            light.switchOffLights();
            musicSystem.switchOffMusicSystem();
            tv.switchOffTV();
            securitySystem.EnableSecuritySystem();
            phoneAnsweringSystem.SetAwayMessage();
        }
        // 'Operation' in Facade class
        public void ArriveHomefromOffice()
        {
            light.switchOnLights();
            musicSystem.switchOnMusicSystem();
            tv.switchOnTV();
            securitySystem.DisableSecuritySystem();
            phoneAnsweringSystem.SetHomeMessage();
        }
    }
}
