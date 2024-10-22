namespace Lecture7AbstractFactory
{
	internal class CzechDuck : Duck
	{
		public string Name => "kachna";


		public void Quack(TextWriter writer)
		{
			writer.Write("kač");
		}
	}
}
