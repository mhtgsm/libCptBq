// See https://aka.ms/new-console-template for more information
using libCptBq;
using System.Numerics;

static void Main()
{
    Compte c1;
    c1 = new Compte(12345, "toto", 1000, -500);
    c1.crediter(2000);
    c1.debiter(1300);
    Console.WriteLine(c1.ToString());
}
