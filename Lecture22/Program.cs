// string path = "TestFile.txt";
// string path = @"..\..\..\TestFile.txt";
// string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TestFile.txt");
// string path = "TestFile.txt"; // setting working directory
// string path = "TestFile.txt"; // copy on build

#if DEBUG
string path = @"..\..\..\TestFile.txt";
#else
string path = "TestFile.txt";
#endif


List<string> lines = new List<string>();
string line;


Console.WriteLine(Path.GetFullPath(path));

try {
	using (StreamReader sr = new StreamReader(path)) {
		while ((line = sr.ReadLine()) != null) {
			Console.WriteLine(line);
			lines.Add(line);
		}
	}
} catch (Exception e) {
	Console.Error.WriteLine("The file could not be read:");
	Console.Error.WriteLine(e.Message);
}

lines.Add(DateTime.Now.ToString());

try {
	using (StreamWriter sr = new StreamWriter(path)) {
		foreach (string l in lines) {
			sr.WriteLine(l);
		}
	}
} catch (Exception e) {
	Console.Error.WriteLine("The file could not be written:");
	Console.Error.WriteLine(e.Message);
}