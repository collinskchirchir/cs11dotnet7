namespace Packt.Shared;

public partial class Person
{
    // a read-only property defined using C# 1 - 5 syntax
    public string Origin
    {
        get
        {
            return string.Format("{0} was born on {1}", Name, HomePlanet);
        }
    }

    // 2 read-only properties defined using C# 6+ Lambda expression body syntax
    public string Greeting => $"{Name} says 'Hello'!";
    public int Age => DateTime.Today.Year - DateOfBirth.Year;
}
