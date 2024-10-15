namespace Lecture7FactoryMethod
{
	internal class PlantCell : Cell
	{
		public PlantCell(Atmosphere atmosphere) : base(atmosphere)
		{
		}


		public override void Breathe()
		{
			Photosynthesize();
			atmosphere.DecreaseOxygen(2);
			atmosphere.IncreaseCO2(2);
		}


		private void Photosynthesize()
		{
			int amount = (int) Math.Floor(12 * atmosphere.SunIntensity);
			atmosphere.DecreaseCO2(amount);
			atmosphere.IncreaseOxygen(amount);
		}
	}
}
