// https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/polymorphism

using Lecture6MethodPolymophism;

void TryFeed(Animal animal, string food)
{
	if (animal.DoesEat(food)) {
		Console.WriteLine("Successfully fed {0} to {1}.", food, animal.ToString());
	} else {
		Console.WriteLine("{1} DOES NOT EAT {0}!", food, animal.ToString());
	}
}

Dog dog = new Dog();
Giraffe giraffe = new Giraffe();
Cow cow = new Cow();

Animal[] animals = new Animal[] {
	dog,
	giraffe,
	cow,
	// new Animal(),
	// new Omnivore(),
};


Console.WriteLine(dog.DoSound());
Console.WriteLine(giraffe.DoSound());
Console.WriteLine(cow.DoSound());

foreach (Animal animal in animals) {
	Console.WriteLine(animal.DoSound());
}

Console.WriteLine();


Console.WriteLine("dog.DoesEat(\"meat\") = {0}", dog.DoesEat("meat"));
Console.WriteLine("dog.DoesEat(\"high meat\") = {0}", dog.DoesEat("high meat"));
Console.WriteLine("dog.DoesEat(\"grass\") = {0}", dog.DoesEat("grass"));
Console.WriteLine("giraffe.DoesEat(\"meat\") = {0}", giraffe.DoesEat("meat"));
Console.WriteLine("giraffe.DoesEat(\"high meat\") = {0}", giraffe.DoesEat("high meat"));
Console.WriteLine("giraffe.DoesEat(\"grass\") = {0}", giraffe.DoesEat("grass"));
Console.WriteLine("cow.DoesEat(\"meat\") = {0}", cow.DoesEat("meat"));
Console.WriteLine("cow.DoesEat(\"high meat\") = {0}", cow.DoesEat("high meat"));
Console.WriteLine("cow.DoesEat(\"grass\") = {0}", cow.DoesEat("grass"));

TryFeed(dog, "meat");
TryFeed(dog, "high meat");
TryFeed(dog, "grass");
TryFeed(giraffe, "meat");
TryFeed(giraffe, "high meat");
TryFeed(giraffe, "grass");
TryFeed(cow, "meat");
TryFeed(cow, "high meat");
TryFeed(cow, "grass");

Console.WriteLine();


Console.WriteLine("dog.GetStomachCount() = {0}", dog.GetStomachCount());
Console.WriteLine("giraffe.GetStomachCount() = {0}", giraffe.GetStomachCount());

foreach (Animal animal in animals) {
	if (animal is Omnivore omnivore) {
		Console.WriteLine("omnivore === animal = {0}", omnivore == animal);
		Console.WriteLine(
			"omnivore({1}).GetStomachCount() = {0}",
			// animal.GetStomachCount(),
			omnivore.GetStomachCount(),
			omnivore.ToString()
		);
	}
}