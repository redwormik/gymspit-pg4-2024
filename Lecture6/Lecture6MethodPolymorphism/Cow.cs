namespace Lecture6MethodPolymophism
{
	internal class Cow : Animal
	{
		public string DoSound()
		{
			return "MOOO!";
		}


		public bool DoesEat(string food)
		{
			return food == "grass";
		}
	}
}
