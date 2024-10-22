using Lecture7AbstractFactory;

OldMacDonald oldMacDonald = new OldMacDonald();
oldMacDonald.Sing(new EnglishFarm(), Console.Out);
oldMacDonald.Sing(new CzechFarm(), Console.Out);
oldMacDonald.Sing(new GermanFarm(), Console.Out);
oldMacDonald.Sing(new AnimalFarm(), Console.Out);