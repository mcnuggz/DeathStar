using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class Armory
    {
        int numberOfWeapons;
        int ammo;
        string[] weapons;
        string[] guns;
        string[] laserShooter;
        string[] grenadeLaunchers;
        string[] bombThrower;
        string[] ammoType;
        string[] grenades;
        string[] bombs;
        string[] superLaser;
        string[] bullets;
        int weaponTotal;
        int weaponStock;
        int weaponTake;
        int weaponOut;
        int ammoTotal;
        int ammoStock;
        int ammoTake;
        int ammoOut;
        bool weaponAvailable;

        public Armory(int numberOfWeapons, int ammo)
        {
            this.weaponStock = numberOfWeapons;
            this.ammoStock = ammo;
        }
        public void weaponsList()
        {
            List<string[]> weapons = new List<string[]>() { guns, bombThrower, grenadeLaunchers, laserShooter }; 
        }

        public void ammoList()
        {
            List<string[]> ammoType = new List<string[]>() { bullets, superLaser, grenades, bombs };
        }
        public void TotalWeapons()
        {
            weaponTotal = weaponStock + weaponOut;
            Console.WriteLine("The number of " + weapons + ":" + weaponTotal);
        }
        public void WeaponsInStock()
        {
            weaponStock = weaponTotal - weaponOut;
            Console.WriteLine(weapons + " in stock:" + weaponStock);
        }
        public void WeaponsOut()
        {
            weaponOut = weaponTotal - weaponStock;
            Console.WriteLine(weapons + " out:" + weaponOut);
        }
        public void TakeWeapons()
        {
            Console.WriteLine("How many weapons do you want?");
            string numberWeapons = Console.ReadLine();
            int numberOfWeapons = int.Parse(numberWeapons);

        }

        public void TotalAmmo()
        {
            ammoTotal = ammoStock + ammoOut;
            Console.WriteLine("The number of " + ammo + ":" + ammoTotal);
        }
        public void AmmoInStock()
        {
            ammoStock = ammoTotal - ammoOut;
            Console.WriteLine(ammo + " in stock:" + ammoStock);
        }
        public void AmmoOut()
        {
            ammoOut = ammoTotal - ammoStock;
            Console.WriteLine(ammo + " out:" + ammoOut);
        }
        public void TakeAmmo()
        {
            Console.WriteLine("How much ammo do you want?");
            string requestedAmmo = Console.ReadLine();
            ammo = int.Parse(requestedAmmo);

        }
    }
}
