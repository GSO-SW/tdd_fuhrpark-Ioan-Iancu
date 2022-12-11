using System;
namespace Fuhrparkverwaltung
{
	public class Auto
	{
		private int kilometernStand;

		public Auto(int kilometernStand)
		{
			this.kilometernStand = kilometernStand;
		}

		public int Kilometerstand
		{
			get
			{
				return this.kilometernStand;
			}
		}

		public void Fahren(int streckeInKilomertern)
		{
			if (streckeInKilomertern > 0)
			{
				kilometernStand += streckeInKilomertern;

			}
		}

	}
}

