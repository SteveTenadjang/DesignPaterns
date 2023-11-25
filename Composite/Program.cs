// See https://aka.ms/new-console-template for more information

/*
 * This partern is used t define a heirachy of object with properties in common
 * 
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