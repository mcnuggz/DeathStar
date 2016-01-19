using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class CoolingSystem : IChangeTemperature
    {
        int OverAllTemperature;
        public void Cool(IChangeTemperature part)
        {
            part.CoolDown();
            HeatUp();
        }

        public void CoolDown()
        {
            OverAllTemperature--;
        }

        public void HeatUp()
        {
            OverAllTemperature++;
        }
    }
}
