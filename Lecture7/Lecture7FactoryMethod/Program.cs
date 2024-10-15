using Lecture7FactoryMethod;

// https://en.wikipedia.org/wiki/Factory_method_pattern
// https://refactoring.guru/design-patterns/factory-method

Atmosphere atmosphere = new Atmosphere(100, 100, 0.5f);

Animal animal = new Animal(atmosphere);
Plant plant = new Plant(atmosphere);
Organism[] organisms = new Organism[] { animal, plant };

animal.Grow();
animal.Grow();
plant.Grow();
plant.Grow();
plant.Grow();

try {
	for (int i = 0; i < 1000; i++) {
		foreach (Organism organism in organisms) {
			organism.Breathe();
		}
	}
} catch (ArgumentOutOfRangeException) {
	Console.WriteLine("Atmosphere was depleted!");
	return;
}

Console.WriteLine("Atmosphere was balanced!");
