// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Hawk Redtail = new("red tail");
Console.WriteLine(Redtail.Name);
// Redtail.Fly();

Ostrich Bob = new("Bob");
// Bob.Run();

Duck Daffy = new("daffy");

List<Bird> AllMyBirds = new(){Redtail,Bob,Daffy};

foreach (Bird bird in AllMyBirds)
{

    if (bird is IFly f)
    {
        f.Fly();
    }
    if (bird is IRun r)
    {
        r.Run();
    }
    if (bird is ISwim swimmer)
    {
        swimmer.Swim();
    }
}

