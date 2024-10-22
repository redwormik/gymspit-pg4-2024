namespace Lecture7AbstractFactory
{
	internal class AnimalFarm : EnglishFarm
	{
		override public Pig CreatePig()
		{
			return new OrwellianPig();
		}
	}
}
