using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class HydrogenGenerator : Reactor
    {
        public int HydrogenChargeRate = 6;
        public HydrogenGenerator(int PowerRate) : base(PowerRate)
        {
            
        }

        public int ChargeHydrogen()
        {
            return PowerRate * HydrogenChargeRate;
        }
    }
}
