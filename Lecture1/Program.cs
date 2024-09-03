using Lecture1;


static void PrintHighways(City city)
{
	Console.WriteLine("{0}:", city.Name);
	foreach (Highway highway in city.GetHighways()) {
		Console.WriteLine("\t{0} ({1} km)", highway.OtherEnd(city).Name, highway.Length);
	}
	Console.WriteLine();
}


static bool Neighbors(City city, City destination)
{
	IList<City> neighbors = new List<City>();
	foreach (Highway highway in city.GetHighways()) {
		neighbors.Add(highway.OtherEnd(city));
	}

	return neighbors.Contains(destination);
}


static bool Connected(City city, City destination)
{
	// TODO
	return false;
}


City praha = new City("Praha");
City plzen = new City("Plzeň");
City liberec = new City("Liberec");
City brno = new City("Brno");
City bratislava = new City("Bratislava");

City newYork = new City("New York");
City newJersey = new City("New Jersey");
City lasVegas = new City("Las Vegas");
City losAngeles = new City("Los Angeles");
City sanFrancisco = new City("San Francisco");

City anchorage = new City("Anchorage");


praha.AddHighway(praha, 50);
praha.AddHighway(brno, 200);
praha.AddHighway(plzen, 100);
praha.AddHighway(liberec, 100);
plzen.AddHighway(liberec, 150);
brno.AddHighway(bratislava, 100);

newYork.AddHighway(newJersey, 150);
newYork.AddHighway(lasVegas, 1500);
lasVegas.AddHighway(losAngeles, 500);
lasVegas.AddHighway(sanFrancisco, 1000);
losAngeles.AddHighway(sanFrancisco, 150);

anchorage.AddHighway(anchorage, 10);


PrintHighways(praha);
PrintHighways(plzen);
PrintHighways(liberec);
PrintHighways(brno);
PrintHighways(bratislava);
PrintHighways(anchorage);


Console.WriteLine("Neighbors({0}, {1}) = {2}", praha.Name, praha.Name, Neighbors(praha, praha));
Console.WriteLine("Neighbors({0}, {1}) = {2}", praha.Name, brno.Name, Neighbors(praha, brno));
Console.WriteLine("Neighbors({0}, {1}) = {2}", praha.Name, plzen.Name, Neighbors(praha, plzen));
Console.WriteLine("Neighbors({0}, {1}) = {2}", praha.Name, liberec.Name, Neighbors(praha, liberec));
Console.WriteLine("Neighbors({0}, {1}) = {2}", praha.Name, bratislava.Name, Neighbors(praha, bratislava));

Console.WriteLine("Neighbors({0}, {1}) = {2}", praha.Name, newYork.Name, Neighbors(praha, newYork));
Console.WriteLine("Neighbors({0}, {1}) = {2}", praha.Name, newJersey.Name, Neighbors(praha, newJersey));
Console.WriteLine("Neighbors({0}, {1}) = {2}", praha.Name, lasVegas.Name, Neighbors(praha, lasVegas));
Console.WriteLine("Neighbors({0}, {1}) = {2}", praha.Name, losAngeles.Name, Neighbors(praha, losAngeles));
Console.WriteLine("Neighbors({0}, {1}) = {2}", praha.Name, sanFrancisco.Name, Neighbors(praha, sanFrancisco));
Console.WriteLine("Neighbors({0}, {1}) = {2}", praha.Name, anchorage.Name, Neighbors(praha, anchorage));


Console.WriteLine("Connected({0}, {1}) = {2}", praha.Name, praha.Name, Connected(praha, praha));
Console.WriteLine("Connected({0}, {1}) = {2}", praha.Name, brno.Name, Connected(praha, brno));
Console.WriteLine("Connected({0}, {1}) = {2}", praha.Name, plzen.Name, Connected(praha, plzen));
Console.WriteLine("Connected({0}, {1}) = {2}", praha.Name, liberec.Name, Connected(praha, liberec));
Console.WriteLine("Connected({0}, {1}) = {2}", praha.Name, bratislava.Name, Connected(praha, bratislava));

Console.WriteLine("Connected({0}, {1}) = {2}", praha.Name, newYork.Name, Connected(praha, newYork));
Console.WriteLine("Connected({0}, {1}) = {2}", praha.Name, newJersey.Name, Connected(praha, newJersey));
Console.WriteLine("Connected({0}, {1}) = {2}", praha.Name, lasVegas.Name, Connected(praha, lasVegas));
Console.WriteLine("Connected({0}, {1}) = {2}", praha.Name, losAngeles.Name, Connected(praha, losAngeles));
Console.WriteLine("Connected({0}, {1}) = {2}", praha.Name, sanFrancisco.Name, Connected(praha, sanFrancisco));
Console.WriteLine("Connected({0}, {1}) = {2}", praha.Name, anchorage.Name, Connected(praha, anchorage));

Console.WriteLine("Connected({0}, {1}) = {2}", anchorage.Name, anchorage.Name, Connected(anchorage, anchorage));
Console.WriteLine("Connected({0}, {1}) = {2}", anchorage.Name, praha.Name, Connected(anchorage, praha));
