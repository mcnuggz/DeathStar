using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class TractorBeam : Reactor
    {
        public int TractorBeamLevel
        {
            private set
            {
                TractorBeamLevel = value;
            }
            get
            {
                return TractorBeamLevel;
            }
        }
        public TractorBeam(int PowerRate, int TractorBeamLevel)
            :base(PowerRate)
        {
            this.TractorBeamLevel = TractorBeamLevel;
        }
        public void Tractorbeamgeneratortower(int powerrate)
            
        {
            TractorBeamLevel = powerrate;
                       
        }

        public void GenerateTractorBeam()
        {
            TractorBeamLevel++;
        }

        public void CreateForce(int power, int direction)
        {
            Tractorbeamgeneratortower(power);
            //Console.WriteLine($"Your tractor bean starts pulling with {power} at {direction} degrees");
        }
    }
}
