using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class Reactor
    {
        public int PowerRate { get; private set; }
        private int InitialPowerPercent = 0;
        public int MaxPowerPercent = 100;

        public Reactor(int PowerRate)
        {
            this.PowerRate = PowerRate;
        }
        public int GeneratePower()
        {
            if(InitialPowerPercent <= MaxPowerPercent)
            {
                Console.WriteLine("Charging...");
                PowerRate++;
                if (InitialPowerPercent == MaxPowerPercent)
                {
                    Console.WriteLine("Fully charged.");
                }
                
            }

            return PowerRate;
        }
    }
}
