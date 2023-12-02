/*
 * Category : Structure
 * 
 * Objective :
 *  - oragnise object in an arboresente structure to represent hierachy
 *  - Gives the possibility to the client to manipulate a unique object and a compotie object seamlessly
 */

using Composite;

Folder root = new("Root");
Folder f1 = new("Structure");
Folder f2 = new("Compenent"); 
Folder f3 = new("Creation");

root.AddComponent(f1);
root.AddComponent(f2);
root.AddComponent(f3);

f1.AddComponent(new Composite.File("Composite"));
f1.AddComponent(new Composite.File("Decorator"));

f2.AddComponent(new Composite.File("Stratergy"));

f3.AddComponent(new Composite.File("Singleton"));
f3.AddComponent(new Composite.File("Builder"));

f1.AddComponent(new Folder("Structure1"));

Folder? folder = (Folder?) f1.FindByName("Structure1");
folder?.AddComponent(new Composite.File("Composite version 2"));

root.View();