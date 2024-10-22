namespace Lecture7AbstractFactory
{
	internal interface Pig
	{
		string Name { get; }


		void Oink(TextWriter writer);
	}
}
