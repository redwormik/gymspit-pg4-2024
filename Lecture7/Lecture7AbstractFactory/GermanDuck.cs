namespace Lecture7AbstractFactory
{
	internal class GermanDuck : Duck
	{
		public string Name => "Ente";


		public void Quack(TextWriter writer)
		{
			writer.Write("kwa");
		}
	}
}
