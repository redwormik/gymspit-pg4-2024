namespace Lecture6MethodOverloading
{
	internal class Parent
	{
		public virtual void test()
		{
			Console.WriteLine("Parent");
		}


		public override string ToString()
		{
			return "Parent";
		}
	}
}
