namespace Lecture7FactoryMethod
{
	internal class AnimalCell : Cell
	{
		public AnimalCell(Atmosphere atmosphere) : base(atmosphere)
		{
		}


		public override void Breathe()
		{
			atmosphere.DecreaseOxygen(6);
			atmosphere.IncreaseCO2(6);
		}
	}
}
