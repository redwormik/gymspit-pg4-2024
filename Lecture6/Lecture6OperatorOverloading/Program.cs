// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading
// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/user-defined-conversion-operators

using Lecture6OperatorOverloading;

Console.WriteLine("5 / 1 = {0}", new Fraction(5));
Console.WriteLine("5 / 3 = {0}", new Fraction(5, 3));
Console.WriteLine("5 / 3 + 1 / 2 = {0}", new Fraction(5, 3) + new Fraction(1, 2));
Console.WriteLine("5 / 4 + 1 / 6 = {0}", new Fraction(5, 4) + new Fraction(1, 6));
Console.WriteLine("5 / 4 + 1 / 4 = {0}", new Fraction(5, 4) + new Fraction(1, 4));
Console.WriteLine("5 / 3 + 1 / 3 = {0}", new Fraction(5, 3) + new Fraction(1, 3));

Console.WriteLine("5 / 3 + 3 = {0}", new Fraction(5, 3) + 3);
Console.WriteLine("3 + 5 / 3 = {0}", 3 + new Fraction(5, 3));
Console.WriteLine("5 / 3 - 3 = {0}", new Fraction(5, 3) - 3);
Console.WriteLine("5 / 3 * 3 = {0}", new Fraction(5, 3) * 3);
Console.WriteLine("5 / 3 / 3 = {0}", new Fraction(5, 3) / 3);

Console.WriteLine((int) new Fraction(22, 7));

Console.WriteLine("==");
Console.WriteLine("5 / 3 == 10 / 6: {0}", new Fraction(5, 3) == new Fraction(10, 6));
Console.WriteLine("5 / 3 == 11 / 6: {0}", new Fraction(5, 3) == new Fraction(11, 6));
Console.WriteLine("8 / 4 == 2: {0}", new Fraction(8, 4) == 2);
Console.WriteLine("8 / 4 == 3: {0}", new Fraction(8, 4) == 3);

Console.WriteLine("!=");
Console.WriteLine("5 / 3 != 10 / 6: {0}", new Fraction(5, 3) != new Fraction(10, 6));
Console.WriteLine("5 / 3 != 11 / 6: {0}", new Fraction(5, 3) != new Fraction(11, 6));
Console.WriteLine("8 / 4 != 2: {0}", new Fraction(8, 4) != 2);
Console.WriteLine("8 / 4 != 3: {0}", new Fraction(8, 4) != 3);

Console.WriteLine(">");
Console.WriteLine("5 / 3 > 11 / 7: {0}", new Fraction(5, 3) > new Fraction(11, 7));
Console.WriteLine("5 / 3 > 12 / 7: {0}", new Fraction(5, 3) > new Fraction(12, 7));
Console.WriteLine("5 / 3 > 1: {0}", new Fraction(5, 3) > 1);
Console.WriteLine("5 / 3 > 2: {0}", new Fraction(5, 3) > 2);
Console.WriteLine("5 / 3 > 10 / 6: {0}", new Fraction(5, 3) > new Fraction(10, 6));
Console.WriteLine("8 / 4 > 2: {0}", new Fraction(8, 4) > 2);

Console.WriteLine("<");
Console.WriteLine("5 / 3 < 11 / 7: {0}", new Fraction(5, 3) < new Fraction(11, 7));
Console.WriteLine("5 / 3 < 12 / 7: {0}", new Fraction(5, 3) < new Fraction(12, 7));
Console.WriteLine("5 / 3 < 1: {0}", new Fraction(5, 3) < 1);
Console.WriteLine("5 / 3 < 2: {0}", new Fraction(5, 3) < 2);
Console.WriteLine("5 / 3 < 10 / 6: {0}", new Fraction(5, 3) < new Fraction(10, 6));
Console.WriteLine("8 / 4 < 2: {0}", new Fraction(8, 4) < 2);

Console.WriteLine(">=");
Console.WriteLine("5 / 3 >= 11 / 7: {0}", new Fraction(5, 3) >= new Fraction(11, 7));
Console.WriteLine("5 / 3 >= 12 / 7: {0}", new Fraction(5, 3) >= new Fraction(12, 7));
Console.WriteLine("5 / 3 >= 1: {0}", new Fraction(5, 3) >= 1);
Console.WriteLine("5 / 3 >= 2: {0}", new Fraction(5, 3) >= 2);
Console.WriteLine("5 / 3 >= 10 / 6: {0}", new Fraction(5, 3) >= new Fraction(10, 6));
Console.WriteLine("8 / 4 >= 2: {0}", new Fraction(8, 4) >= 2);

Console.WriteLine("<=");
Console.WriteLine("5 / 3 <= 11 / 7: {0}", new Fraction(5, 3) <= new Fraction(11, 7));
Console.WriteLine("5 / 3 <= 12 / 7: {0}", new Fraction(5, 3) <= new Fraction(12, 7));
Console.WriteLine("5 / 3 <= 1: {0}", new Fraction(5, 3) <= 1);
Console.WriteLine("5 / 3 <= 2: {0}", new Fraction(5, 3) <= 2);
Console.WriteLine("5 / 3 <= 10 / 6: {0}", new Fraction(5, 3) <= new Fraction(10, 6));
Console.WriteLine("8 / 4 <= 2: {0}", new Fraction(8, 4) <= 2);
