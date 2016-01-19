using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class HeatExchanger : IChangeTemperature
    {
        public int Temperature;

        public void Absorbheat(IChangeTemperature part)
        {
            part.CoolDown();
            this.HeatUp();
        }

        public void Emitheat(IChangeTemperature part)
        {
            part.HeatUp();
            this.CoolDown();
        }

        public void CoolDown()
        {
            Temperature--; 
        }

        public void HeatUp()
        {
            Temperature++; 
        }
    }
}