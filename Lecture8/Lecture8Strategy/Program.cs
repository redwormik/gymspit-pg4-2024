using Lecture8Strategy;

BinaryOperation addition = new Addition();
BinaryOperation subtraction = new Subtraction();
BinaryOperation multiplication = new Multiplication();
BinaryOperation division = new Division();

// (15 + (3 * 9))
Expression expr = new BinaryExpression(
	new Value(15),
	new BinaryExpression(new Value(3), new Value(9), multiplication),
	addition
);
Console.WriteLine(expr.GetValue());

// ((93 - (15 / 7)) / 3) * (4 + 1)
Expression expr2 = new BinaryExpression(
	new BinaryExpression(new BinaryExpression(
		new Value(93),
		new BinaryExpression(new Value(15), new Value(7), division),
		subtraction
	), new Value(3), division),
	new BinaryExpression(new Value(4), new Value(1), addition),
	multiplication
);
Console.WriteLine(expr2.GetValue());