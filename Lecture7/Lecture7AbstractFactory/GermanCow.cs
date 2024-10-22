namespace Lecture7AbstractFactory
{
	internal class GermanCow : Cow
	{
		public string Name => "Kuh";


		public void Moo(TextWriter writer)
		{
			writer.Write("muuh");
		}
	}
}
