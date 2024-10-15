namespace Lecture7FactoryMethod
{
	internal abstract class Organism
	{
		protected Atmosphere atmosphere;

		private IList<Cell> cells = new List<Cell>();


		protected Organism(Atmosphere atmosphere)
		{
			this.atmosphere = atmosphere;
		}


		public void Breathe()
		{
			foreach (Cell cell in cells) {
				cell.Breathe();
			}
		}


		public void Grow()
		{
			cells.Add(createCell());
		}


		// factory method
		protected abstract Cell createCell();
	}
}
