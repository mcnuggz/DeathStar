using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class SuperLaser
    {
        int laserPowerLevel;
        int laserDamage;
        int chargerPack;
        
        public SuperLaser(int laserPowerLevel, int laserDamage, int chargerPack)
        {
            this.laserPowerLevel = laserPowerLevel;
            this.laserDamage = laserDamage;
            this.chargerPack = chargerPack;

        }

        public void FireLaser()
        {
            laserPowerLevel -= 5;
            Console.WriteLine("Pew, pew, pew!");
            
            if (laserPowerLevel <= 0)
            {
                Recharge();
            }
        }
        public void Recharge()
        {
            laserPowerLevel = chargerPack;
            Console.WriteLine("The Super Laser is recharging");
        }
    }
}
