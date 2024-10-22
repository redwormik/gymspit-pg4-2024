namespace Lecture7AbstractFactory
{
	internal interface Farm
	{
		Cow CreateCow();

		Duck CreateDuck();

		Pig CreatePig();
	}
}
