namespace Lecture7AbstractFactory
{
	internal class GermanPig : Pig
	{
		public string Name => "Schwein";


		public void Oink(TextWriter writer)
		{
			writer.Write("grunz");
		}
	}
}
