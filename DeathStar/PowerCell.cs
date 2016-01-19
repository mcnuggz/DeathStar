using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{

    class PowerCell
    {
        int cell = 0;
        int powerLevel;
        public void powerCell()
        {
            this.powerLevel = 100;
        }
        public void LosePower()
        {
            powerLevel--;
        }
        public void checkPowerLevel()
        {
            Console.WriteLine("The power level is ", powerLevel);
        }
        public void replaceDefCell()
        {
            this.powerLevel = 100;
        }
    }
}
