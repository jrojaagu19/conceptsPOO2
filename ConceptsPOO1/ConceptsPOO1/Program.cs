// See https://aka.ms/new-console-template for more information
using ConceptsPOO1;

Console.WriteLine("Concepts POO");
Console.WriteLine("============");

try
{
    Console.WriteLine(new Date(2024, 2, 29));
    Console.WriteLine(new Date(1974, 9, 23));
    Console.WriteLine(new Date(1999, 11, 18));
}
catch (Exception error)
{

    Console.WriteLine(error.Message);
}