namespace Lecture7FactoryMethod
{
	internal abstract class Cell
	{
		protected Atmosphere atmosphere;


		protected Cell(Atmosphere atmosphere)
		{
			this.atmosphere = atmosphere;
		}


		public abstract void Breathe();
	}
}
