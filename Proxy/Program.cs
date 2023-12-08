/*
 * Category : Structure
 * 
 * Objective : Provides an intermidiary between a client and an object in order to control access.
 * 
 * Result : Enables de isolation of the behaviour when accessing an object
 * 
 */

using Proxy;
using Proxy.Implementations;

Client client = new();
client.Standard = new Proxy.Implementations.Proxy();
client.Process();
