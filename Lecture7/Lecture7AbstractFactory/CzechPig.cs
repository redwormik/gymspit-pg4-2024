namespace Lecture7AbstractFactory
{
	internal class CzechPig : Pig
	{
		public string Name => "prase";


		public void Oink(TextWriter writer)
		{
			writer.Write("chro");
		}
	}
}
