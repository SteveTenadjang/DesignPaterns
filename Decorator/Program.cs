using Decorator.Decorators;
using Decorator.Drinks;

Drink expresso = new Espresso();

Console.WriteLine("******************");
Console.WriteLine(expresso.Description);
Console.WriteLine(expresso.Price());
Console.WriteLine("******************");

expresso = new Chocolat(expresso);

Console.WriteLine("******************");
Console.WriteLine(expresso.Description);
Console.WriteLine(expresso.Price());
Console.WriteLine("******************");

expresso = new Chocolat(expresso);

Console.WriteLine("******************");
Console.WriteLine(expresso.Description);
Console.WriteLine(expresso.Price());
Console.WriteLine("******************");
