using System;
namespace Fuhrparkverwaltung
{
	public class Auto
	{
		private int kilometernStand;
		private double tankinhaltInLiter;
		private readonly double verbrauchInLiter;

		public Auto (int kilometernStand, double tankinhaltInLiter, double verbrauchInLiter):this(kilometernStand)
        {
			this.tankinhaltInLiter= tankinhaltInLiter;
			this.verbrauchInLiter = verbrauchInLiter;
		}

		public Auto(int kilometernStand)
		{
			this.kilometernStand = kilometernStand;
		}

		public int Kilometerstand
		{
			get
			{
				return kilometernStand;
			}
		}

		public void Fahren(int streckeInKilomertern)
		{
			double gesamtVerbrauchInLiter;
			if (streckeInKilomertern > 0)
			{
				kilometernStand += streckeInKilomertern;
				gesamtVerbrauchInLiter = streckeInKilomertern / 100.0 * verbrauchInLiter;
				tankinhaltInLiter -= gesamtVerbrauchInLiter;
			}
		}

		public double TankinhaltInLiter
		{
			get
			{
				return tankinhaltInLiter;
			}
		}

		public double VerbrauchInLiter
		{
			get
			{
				return verbrauchInLiter;
			}
		}

	}
}

