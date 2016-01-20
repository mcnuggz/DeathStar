using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class IonDriveReactor : Reactor
    {

        public int IonDriveRate = 4;

        public IonDriveReactor(int PowerRate) : base(PowerRate) 
        {
           
        }
        public int ChargeIonDrive()
        {
            return PowerRate * IonDriveRate;
               
        }
    }
}
