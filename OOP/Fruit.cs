class Fruit : Food
{
    public bool Ripe { get;set; }

    public Fruit(string name, bool delicious, bool spicy, double price, bool ripe) : base(name,delicious,spicy,price)
    {
        Ripe = ripe;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Is Ripe? {Ripe}");
    }
}