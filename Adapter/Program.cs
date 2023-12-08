/*
 * Category : structure
 * 
 * objective : 
 *  - Convert an interface used by client in to another interface.
 *  - Permit classes with incompatible interfaces to work together.
 *  
 *  Result: permit the adaptation of a system with a sub-system
 *  
 *  - there are 02 possible implementation, one with inheritance and another with composition
 */





using Adapter;
using Adapter.Adapters;
using Adapter.Implementations;

Client client = new();
client.Standard = new Standard();
client.Process(6, 7);

client.Standard = new Standard1();
client.Process(6, 7);

client.Standard = new Adapt();
client.Process(6, 7);

client.Standard = new AdaptWithInheritance();
client.Process(6, 7);
