using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class ExteriorQuadaniumsteelouterhull
    {
        int Hardness;
        int Health = 100;
        int Nanites;

        public ExteriorQuadaniumsteelouterhull(int Hardness,int Health,int Nanites)
        {
            this.Hardness = Hardness;
            this.Health = Health;
            this.Nanites = Nanites;
        }
        public void TakeDamage()
        {
            switch (Hardness)
            {
                case 1:
                    Health -= 20;
                    break;
                case 2:
                    Health -= 15;
                    break;
                case 3:
                    Health -= 10;
                    break;
                case 4:
                    Health -= 5;
                    break;
                case 5:
                    Health -= 1;
                    break;
            }     
        }
        public void NaniteRepair()
        {
            if (Health == 100)
            {
                Console.WriteLine("You are at maximum health and do not need to repair.");
            }
            else if (Health >= 95)
            {
                Nanites--;
                Health = 100;
            }
            else if (Health > 0)
            {
                Nanites--;
                Health += 5;
            }
            else
            {
                Console.WriteLine("Your Robot is probably dead.");
            }
        }
    }
}
