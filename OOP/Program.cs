// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Food Kiwi = new("kiwi", true, false, 0.49);

Console.WriteLine($"{Kiwi.Name} {(Kiwi.Delicious ? "is" : "is not")} delicious");
Kiwi.Name = "Apple";
Kiwi.Price = 100.00;
Kiwi.Price = -9;

// Kiwi.PrintInfo();

Fruit Apple = new("apple",true,false,0.49,true);
// Apple.PrintInfo();

Food Blank = new();
// Blank.PrintInfo();

// Apple.PrintInfo(5);

Food TestFood = (Food)Apple;
// Fruit TestFruit = (Fruit)Kiwi;
TestFood.PrintInfo();
// TestFruit.PrintInfo();