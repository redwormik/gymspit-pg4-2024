namespace Lecture7AbstractFactory
{
	internal class GermanFarm : Farm
	{
		public Cow CreateCow()
		{
			return new GermanCow();
		}


		public Duck CreateDuck()
		{
			return new GermanDuck();
		}


		public Pig CreatePig()
		{
			return new GermanPig();
		}
	}
}
