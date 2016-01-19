using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class Destination 
    {
        public Destination()
        {
           
        }

        public string getDestination()
        {
            Console.WriteLine("where do you want to teleport to?");
            String newDestination = Console.ReadLine();
            Console.WriteLine(newDestination);
            return newDestination;
        } 
    }
}
