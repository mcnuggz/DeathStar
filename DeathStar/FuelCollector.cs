using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class FuelCollector
    {
        public int tankSizeInGallons;
        public bool isTankFull;

        public FuelCollector(int TankSizeInGallons)
        {
            tankSizeInGallons = TankSizeInGallons;
        }
        public void fuelTankStatus()
        {
            Console.WriteLine("Fuel status");
        }
    }
}
