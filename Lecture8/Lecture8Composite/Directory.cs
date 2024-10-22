namespace Lecture8Composite
{
	internal class Directory : File
	{
		public string Name { get; private set; }

		public File[] Files { get; private set; }


		public Directory(string name, File[] files)
		{
			Name = name;
			Files = files;
		}


		public void PrintOn(TextWriter writer, int indent = 0)
		{
			writer.WriteLine("{0}:", Name);

			foreach (File file in Files) {
				writer.Write("".PadLeft(indent * 3));
				writer.Write(" - ");
				file.PrintOn(writer, indent + 1);
			}
		}
	}
}
