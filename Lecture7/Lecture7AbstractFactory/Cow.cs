namespace Lecture7AbstractFactory
{
	internal interface Cow
	{
		string Name { get; }

		void Moo(TextWriter writer);
	}
}
