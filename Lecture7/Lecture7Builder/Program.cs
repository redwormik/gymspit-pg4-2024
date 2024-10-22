using Lecture7Builder;

NounClauseBuilder builder = new NounClauseBuilder("elephant");

builder.AddColor("blue")
	.AddColor("green")
	.AddColor("red")
	.SetSize("tiny");

Console.WriteLine(builder.GetNounClause());