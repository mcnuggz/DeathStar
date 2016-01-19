using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSecretPlans
{
	public class MainPowerGenerator : Reactor
	{
		public int startupPowerLevel
		{
			private set
			{
				startupPowerLevel = value;
			}
			get
			{
				return startupPowerLevel;
			}
		}
		public int maxPower
		{
			private set
			{
				maxPower = value;
			}
			get
			{
				return maxPower;
			}
		}
		public MainPowerGenerator(int PowerRate, int startupPowerLevel, int maxPower)
			: base(PowerRate)
		{
			this.maxPower = maxPower;
			this.startupPowerLevel = startupPowerLevel;
		}
		public bool CanPowerUp()
		{
			if (startupPowerLevel >= PowerRate)
			{
				return true;	
			} else
			{
				return false;
			}
		}
		public bool isAtMaxPower()
		{
			if (maxPower == PowerRate)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool isOverHeated()
		{
			if (PowerRate > maxPower)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
