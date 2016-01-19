using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class ReactorCore : IChangeTemperature
    {
        public int Temperature;
        public int fuelRods;
        public int fuelRodLevel;
        public int controlRods;
        public int controlRodLevel;
        public int waterReactorLevel;
        public int uraniumAmount;
        public int boronAmount;

        public ReactorCore(int FuelRods, int FuelRodLevel, int ControlRods, int ControlRodLevel, int WaterReactorLevel, int UraniumAmount, int BoronAmount)
        {
            this.fuelRods = FuelRods;
            this.fuelRodLevel = FuelRodLevel;
            this.controlRods = ControlRods;
            this.controlRodLevel = ControlRodLevel;
            this.waterReactorLevel = WaterReactorLevel;
            this.uraniumAmount = UraniumAmount;
            this.boronAmount = BoronAmount;

        }

        List<int> evasionCheckList;
        public void  EvasionCheck(int fuelRods, int fuelRodLevel, int controlRods, int controlRodLevel, int waterReactorLevel, int uraniumAmount, int boronAmount )
        {
            if  (evasionCheckList != null)
            {

                //iterate through to make sure evasive action can be taken safely
                List<int> EvasionCheckList = evasionCheckList;
                EvasionCheckList.Add(fuelRods);
                EvasionCheckList.Add(fuelRodLevel);
                EvasionCheckList.Add(controlRods);
                EvasionCheckList.Add(controlRodLevel);
                EvasionCheckList.Add(waterReactorLevel);
                EvasionCheckList.Add(uraniumAmount);
                EvasionCheckList.Add(boronAmount);

                
            }
            
        }

        public void CoolDown()
        {
            this.Temperature--;
        }

        public void HeatUp()
        {
            this.Temperature++;
        }
    }
}
