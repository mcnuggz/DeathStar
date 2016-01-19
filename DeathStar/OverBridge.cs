using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{

    class OverBridge
    {
        int numberOfStairwells;
        int numberOfDutyPosts;
        int numberOfControlConsole;
        bool holoDisplayPad;




        public OverBridge(int numberOfStairwells, int numberOfDutyPosts, int numberOfControlConsole, bool holoDisplayPad)
        {
            this.numberOfDutyPosts = numberOfDutyPosts;
            this.numberOfStairwells = numberOfStairwells;
            this.numberOfControlConsole = numberOfControlConsole;
            this.holoDisplayPad = holoDisplayPad;
        }
        public void turnOnDisplayPad()
        {
            this.holoDisplayPad = true;
        }
        public void checkSystems()
        {
            Console.WriteLine("All systems good");
        }
    }





}
