class Ostrich : Bird, IRun
{
    public int LandSpeed { get; set; } = 45;
    public Ostrich(string name) : base(name){}


    public void Run()
    {
        Console.WriteLine($"{Name} runs off at {LandSpeed} mph");
    }
}