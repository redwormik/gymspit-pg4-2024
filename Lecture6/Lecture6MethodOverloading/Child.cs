namespace Lecture6MethodOverloading
{
	internal class Child : Parent
	{
		public override void test()
		{
			Console.WriteLine("Child");
		}


		public override string ToString()
		{
			return "Child";
		}
	}
}
