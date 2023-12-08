/*
 * Category : Structure
 * 
 * Objective : This pattern attahe dynamically additional responsibilities to 
 *  to an object. it provides a simple alternative to inheritance to extend fonctionalities 
 * 
 * Result: Isolate the responsibilities of an object
 */


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
