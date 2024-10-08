namespace Lecture6MethodPolymophism
{
	internal abstract class Omnivore : Animal
	{
		public abstract string DoSound();


		public bool DoesEat(string _)
		{
			return true;
		}


		public virtual int GetStomachCount()
		{
			return 1;
		}
	}
}
