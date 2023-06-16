using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.Shared; // file-scoped namespace

public partial class Person : object
{
    // fields
    public string? Name;
    public DateTime DateOfBirth;
    public WondersOfTheAncientWorld FavoriteAncientWonder;
    public List<Person> Children = new();
    public const string Species = "Homo Sapiens"; // constant field
    public readonly string HomePlanet = "Earth"; // read-only field
    public readonly DateTime Instantiated;

    // constructors
    public Person()
    {
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }
    public Person(string initialName, string homePlanet)
    {
        Name = initialName;
        HomePlanet = homePlanet;
        Instantiated = DateTime.Now;
    }

    // methods
    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on  a {DateOfBirth: dddd}.");
    }

    public string GetOrigin()
    {
        return $"{Name} was born on {HomePlanet}.";
    }

    // tuples
    public (string, int) GetFruit()
    {
        return ("Apples", 5);
    }
    // naming fields of a tuple
    public (string Name, int Number) GetNamedFruit()
    {
        return (Name: "Apples", Number: 5);
    }

    // controlling how parameters are passed
    public void PassingParameters(int x, ref int y, out int z)
    {   
        // out parameters cannot have a default
        // AND must be initialized inside the method
        z = 99;
        // increament each parameter
        x++;
        y++;
        z++;
    }

}
