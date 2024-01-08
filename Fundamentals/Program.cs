// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Look I did something!");

int Age = 35;
string Name = "Spencer";

Console.WriteLine($"I am {Name} I am {Age} years old");


//length of arrays are fixed in C#

int[] Ages = new int[5];

Console.WriteLine(Ages[3]);

for (int i = 0; i < Ages.Length; i++)
{
    Ages[i] = 9;
}

foreach (int num in Ages)
{
    Console.WriteLine(num);
    
}

List<string> Names = new();
Names.Add("Spencer");
Names.Add("Kaija");
Names.Add("Ruben");
Names.Add("Judah");
Names.Add("Frank");

Names.Remove("Ruben");
Names.Add("Ruben");

Names.ForEach(Console.WriteLine);

Dictionary<string, int> PetAges = new()
{
    { "Wiley", 4 },
    { "Shepard", 4 }
};

// PetAges.Add("Wiley",9999);
PetAges["Wiley"] = 999;

foreach(KeyValuePair<string,int> entry in PetAges)
{
    Console.WriteLine($"{entry.Key} is {entry.Value} years old");
    
}



