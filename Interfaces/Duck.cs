class Duck : Bird, IFly, ISwim
{
    public int AirSpeed { get ; set ; }
    public int NauticalSpeed { get ; set ; }

    public Duck(string name):base(name){}


    public void Fly()
    {
        Console.WriteLine($"{Name} takes to the sky at {AirSpeed} mph");

    }

    public void Swim()
    {
        Console.WriteLine($"{Name} paddles off at {NauticalSpeed} knots");

    }
}