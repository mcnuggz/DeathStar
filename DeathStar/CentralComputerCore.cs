using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
    public class CentralComputerCore
    {
        string command;
        int computerPower;
        int coreHealth = 100;
        int shieldHealth = 100;
        bool shieldStatus;

        public CentralComputerCore(string Command, int ComputerPower)
        {
            command = Command;
            computerPower = ComputerPower;
        }

        public string IssueCommands(string newCommand)
        {
            return newCommand;
        }
        public void UseComputer()
        {
            computerPower--;
        }
        public void TakeCoreDamage()
        {
            coreHealth--;
        }
        public void TakeShieldDamage()
        {
            shieldHealth--;
        }

        public bool TurnShieldOnOrOff(bool shieldStatus)
        {
            this.shieldStatus = shieldStatus;
            return this.shieldStatus;
        }

        public void hasEmail()
        {

            int emailProbMin = 0;
            int emailProbMax = 2;

            Random emailProbability = new Random();
            int eProb = emailProbability.Next(emailProbMin, emailProbMax);

            if (eProb >= 1)
            {
                Console.WriteLine("You have mail!");
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("Scott.wav");
            }
            else
            {
                Console.WriteLine("You have no mail.");

            }

        }
    }
}
