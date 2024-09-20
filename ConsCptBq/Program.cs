// See https://aka.ms/new-console-template for more information
using System.Numerics;

Compte c1, c2;
c1 = new Compte(12345, "toto", 1000, -500);
c2 = new Compte(45657, "titi", 2000, -1000);
c1.Transferer(1300, c2);
Console.WriteLine(c1.ToString());
Console.WriteLine(c2.ToString());
