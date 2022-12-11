using System;
namespace Fuhrparkverwaltung
{
	public class Auto
	{
		private int kilometernStand;
		private double tankinhaltInLiter = 0;
		private readonly double verbrauchInLiter = 0;

		public Auto(int kilometernStand, double tankinhaltInLiter, double verbrauchInLiter):this(kilometernStand)
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
			double moeglichtFahrbarStreckeInKilometer;
			if (streckeInKilomertern > 0)
			{
				gesamtVerbrauchInLiter = streckeInKilomertern / 100.0 * verbrauchInLiter;
				moeglichtFahrbarStreckeInKilometer = tankinhaltInLiter / verbrauchInLiter * 100.0;

				if (tankinhaltInLiter > gesamtVerbrauchInLiter)
				{
					kilometernStand += streckeInKilomertern;
					tankinhaltInLiter -= gesamtVerbrauchInLiter;
				} else
				{
					tankinhaltInLiter = 0;
					if (!Double.IsNaN(moeglichtFahrbarStreckeInKilometer))
					{
						kilometernStand += Convert.ToInt32(moeglichtFahrbarStreckeInKilometer);
					} else
					{
						kilometernStand += streckeInKilomertern;
					}
				}
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

