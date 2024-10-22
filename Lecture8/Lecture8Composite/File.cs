namespace Lecture8Composite
{
	internal interface File
	{
		string Name { get; }

		void PrintOn(TextWriter writer, int indent = 0);
	}
}