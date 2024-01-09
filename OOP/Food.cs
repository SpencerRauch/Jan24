class Food
{
    private string _Name;
    public string Name {get {return _Name;} set{_Name = value;}}
    public bool Delicious;
    public bool Spicy { get;set; } // this is how we will set up our models
    private double _Price;
    public double Price {get {return _Price;} set{if(value >= 0.01) _Price = value;}}

    public Food(string name, bool delicious, bool spicy, double price)
    {
        Name = name;
        Delicious = delicious;
        Spicy = spicy;
        Price = price;
    }

    public Food(string name, bool delicious, bool spicy)
    {
        Name = name;
        Delicious = delicious;
        Spicy = spicy;
        Price = 0.00;
    }

    public Food(string name, bool spicy, double price)
    {
        Name = name;
        Delicious = true;
        Spicy = spicy;
        Price = price;
    }

    public Food()
    {
        Name = "Generic Food";
        Delicious = false;
        Spicy = false;
        Price = 0.00;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine(Name);
        Console.WriteLine($"Delicious {Delicious}");
        Console.WriteLine($"Spicy {Spicy}");
        Console.WriteLine($"Price {Price}");
    }

    public virtual void PrintInfo(int times)
    {
        for (int i = 0; i < times; i++)
        {
            PrintInfo();
        }
    }
}