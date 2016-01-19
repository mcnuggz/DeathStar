using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    class HyperDrive
    {
		public string destination;
        public int fuelCellLevel;
        public int gravityLevel;
        public bool hyperDriveExecution;
        public HyperDrive(string destination, int fuelCellLevel, int GraveityLevel, bool hyperDriveExecution)
        {

        }
        public bool IsHyperDriveExecuted()
        {
            if(hyperDriveExecution==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void UseHyperDrive()
        {
            if(fuelCellLevel>0)
            {
                this.hyperDriveExecution = true;
                this.fuelCellLevel--;
                this.gravityLevel = 0;
            }
           else
            {
                this.hyperDriveExecution = false;
                Console.WriteLine("your fuel Cell Level is " + this.fuelCellLevel);
            }
        }
    }


}
