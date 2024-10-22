using Lecture8Composite;


Lecture8Composite.File file = new Lecture8Composite.Directory("dir", new Lecture8Composite.File[] {
	new RegularFile("hello.txt"),
	new Lecture8Composite.Directory("dir2", new Lecture8Composite.File[] {
		new RegularFile("inner.txt"),
		new RegularFile("inner2.txt"),
		new Lecture8Composite.Directory("dir2", new Lecture8Composite.File[] {
			new RegularFile("inner.txt"),
			new RegularFile("inner2.txt"),
		}),
	}),
	new RegularFile("hello3.txt"),
});

file.PrintOn(Console.Out);

// (15 + (3 * 9))
Expression expr = new Addition(
	new Value(15),
	new Multiplication(new Value(3), new Value(9))
);
Console.WriteLine(expr.GetValue());
