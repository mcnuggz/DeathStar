using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class HyperMatterReactor : Reactor
    {
        public int HyperMatterRate
        {
            set
            {
                HyperMatterRate = value;
            }
            get
            {
                return HyperMatterRate;
            }
        }
        public int HyperSpaceEnergy
        {
            set
            {
                HyperSpaceEnergy = value;
            }
            get
            {
                return HyperSpaceEnergy;
            }
        }
        public int StellarFuel
        {
            set
            {
                StellarFuel = value;
            }
            get
            {
                return StellarFuel;
            }
        }
        public int HyperMatterAmount;

        public HyperMatterReactor(int HyperMatterRate, int HyperSpaceEnergy, int StellarFuel, int PowerRate)
            :base(PowerRate)
        {
            this.HyperMatterRate = HyperMatterRate;
            this.HyperSpaceEnergy = HyperSpaceEnergy;
            this.StellarFuel = StellarFuel;
            HyperMatterAmount = HyperSpaceEnergy / HyperMatterRate * StellarFuel;
        }
        public int GenerateHyperMatter()
        {
            return HyperMatterAmount;
        }
    }
}    
 

