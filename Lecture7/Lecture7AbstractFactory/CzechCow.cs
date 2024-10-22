namespace Lecture7AbstractFactory
{
	internal class CzechCow : Cow
	{
		public string Name => "kráva";


		public void Moo(TextWriter writer)
		{
			writer.Write("bůůů");
		}
	}
}
