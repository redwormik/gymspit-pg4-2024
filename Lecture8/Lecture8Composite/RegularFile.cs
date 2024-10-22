namespace Lecture8Composite
{
	internal class RegularFile : File
	{
		public string Name { get; private set; }


		public RegularFile(string name)
		{
			Name = name;
		}


		public void PrintOn(TextWriter writer, int indent = 0)
		{
			writer.WriteLine(Name);
		}
	}
}