using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class Refinery
    {
        public bool isOperating;
        public int RefineFuel(int RawMaterials, int FuelRequested)
        {
            int someRawMaterials = 100;
            int someFuelRequested = someRawMaterials / 2;
            return someFuelRequested;
        }
        public void Exhaust(int FuelRequested)
        {
            int theFuelRequested = RefineFuel(100, 50);
        }
    }
}
