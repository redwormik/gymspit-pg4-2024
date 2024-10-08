// https://learn.microsoft.com/en-us/dotnet/csharp/methods

using Lecture6MethodOverloading;

Console.WriteLine("Length() = {0}", Utils.Length());
Console.WriteLine("Length(0) = {0}", Utils.Length(0));
Console.WriteLine("Length(1) = {0}", Utils.Length(1));
Console.WriteLine("Length(-1) = {0}", Utils.Length(-1));
Console.WriteLine("Length(5) = {0}", Utils.Length(5));
Console.WriteLine("Length(-5) = {0}", Utils.Length(-5));
Console.WriteLine("Length(10) = {0}", Utils.Length(10));
Console.WriteLine("Length(-10) = {0}", Utils.Length(-10));
Console.WriteLine("Length(50) = {0}", Utils.Length(50));
Console.WriteLine("Length(-50) = {0}", Utils.Length(-50));
Console.WriteLine("Length(10000) = {0}", Utils.Length(10000));
Console.WriteLine("Length(-10000) = {0}", Utils.Length(-10000));
Console.WriteLine("Length(\"50000\") = {0}", Utils.Length("50000"));
Console.WriteLine("Length(\"-50000\") = {0}", Utils.Length("-50000"));
Console.WriteLine("Length(\"ahoj\") = {0}", Utils.Length("ahoj"));
Console.WriteLine("Length(\"Length\") = {0}", Utils.Length("Length"));

Console.WriteLine("Length(new int[] {{ 4, 42, 24 }}) = {0}", Utils.Length(new int[] { 4, 42, 24 }));

Console.WriteLine("Length(new Parent()) = {0}", Utils.Length(new Parent()));
Console.WriteLine("Length(new Child()) = {0}", Utils.Length(new Child()));

var list = new Parent[] {
	new Parent(),
	new Child(),
};
foreach (Parent obj in list) {
	Console.WriteLine("Length(obj) = {0}", Utils.Length(obj));
	Console.WriteLine("LengthVirtual(obj) = {0}", Utils.LengthVirtual(obj));
}