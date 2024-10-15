namespace Lecture7FactoryMethod
{
	internal class Animal : Organism
	{
		public Animal(Atmosphere atmosphere) : base(atmosphere)
		{
		}


		// factory method
		protected override Cell createCell()
		{
			return new AnimalCell(atmosphere);
		}
	}
}
