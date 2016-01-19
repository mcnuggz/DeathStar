using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class HangarBay
    {
        int numberOfRepairStations;
        int numberOfFuelStations;
        int totalShipsInHanger;
        int numberOfShips;
        int numberOfEngineers;
        int numberOfShipsToRepair;
        int numberOfShipsToFuel;
        int numberOfDrones;
        string[] typesOfDrones;
        string[] typesOfShips;
        bool hangerDoorOpen;
        bool repairStationActive;
        bool fuelStationActive;
        
        bool repairStationOccupied;
        bool FuelStationOccupied;


        public HangarBay(int numberOfRepairStation, int numberOfFuelStation, int numberOfShips, bool hangerDoorOpen, bool repairStationActive, bool fuelStationActive)
        {
        }

        public void shipModels()
        {
            string[] typesOfShips = { "Super Hornet", "Stealth Bomber", "Invader", "Dragonfly", "Cargo" };
        }

        public void droneModels()
        {
            string[] typesOfDrones = { "Predator Warrior", "Hunter", "Hummingbird", "Raven" };
        }
        public void CheckHangerOccupancy()
        {
            totalShipsInHanger = numberOfShipsToRepair + numberOfShipsToFuel;
        }
        public void CheckShipsToRepair()
        {
            Console.WriteLine("How many ships need repair?");
            numberOfShipsToRepair = int.Parse(Console.ReadLine());
        }

        public void CheckShipsToFuel()
        {
            Console.WriteLine("How many ships need Fuel?");
            numberOfShipsToFuel = int.Parse(Console.ReadLine());
        }

        public bool IsDoorOpen()
        {
            return hangerDoorOpen;
        }

        public void repairStationCount()
        {
            Console.WriteLine("How many repair stations?");
            numberOfRepairStations = int.Parse(Console.ReadLine());
        }

        public void fuelStationCount()
        {
            Console.WriteLine("How many fuel stations?");
            numberOfFuelStations = int.Parse(Console.ReadLine());
        }

        public void TotalNumberOfStatations()
        {
            int numberOfStations = numberOfRepairStations + numberOfFuelStations;
            Console.WriteLine("Total number of stations: " + numberOfStations);
        }

        public bool IsRepairStationOccupied()
        {
            return repairStationOccupied;
        }

        public bool IsFuelStationOccupied()
        {
            return FuelStationOccupied;
        }
    }
}