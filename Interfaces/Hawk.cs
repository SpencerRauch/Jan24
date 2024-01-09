class Hawk : Bird, IFly
{
    public int AirSpeed { get; set; } = 10;

    public Hawk(string name) : base(name){}

    public void Fly()
    {
        Console.WriteLine($"{Name} takes to the sky at {AirSpeed} mph");
        
    }
}