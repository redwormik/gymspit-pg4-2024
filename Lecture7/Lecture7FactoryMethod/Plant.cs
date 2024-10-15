namespace Lecture7FactoryMethod
{
	internal class Plant : Organism
	{
		public Plant(Atmosphere atmosphere) : base(atmosphere)
		{
		}


		// factory method
		protected override Cell createCell()
		{
			return new PlantCell(atmosphere);
		}
	}
}
