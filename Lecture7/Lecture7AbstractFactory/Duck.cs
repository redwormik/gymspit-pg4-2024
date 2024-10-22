namespace Lecture7AbstractFactory
{
	internal interface Duck
	{
		string Name { get; }

		void Quack(TextWriter writer);
	}
}
