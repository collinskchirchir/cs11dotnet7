using Packt.Shared;

Person bob = new();

bob.Name = "Bob Smith";
bob.DateOfBirth = new DateTime(1965, 12, 22); // C#1.0 or later
bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
bob.Children.Add(new() { Name = "Alfred" }); // C# 9.0 and later
bob.Children.Add(new Person { Name="Zoe" }); // C# 3.0 and later

WriteLine("{0} was born on {1: dddd, d MMMM yyyy} and favorite wonder is {2}",
    bob.Name, bob.DateOfBirth, bob.FavoriteAncientWonder);

Person alice = new()
{
    Name = "Alice Jones",
    DateOfBirth = new(1998, 3, 7) // C# 9.0 or later
};
WriteLine("{0} was born on {1: dd MMMM yyyy}",
    alice.Name, alice.DateOfBirth);

WriteLine($"{bob.Name} has {bob.Children.Count} children");
for (int childIndex = 0; childIndex < bob.Children.Count; childIndex++)
{
    WriteLine($"> {bob.Children[childIndex].Name}");
}

// Making a Field Static
BankAccount.InterestRate = 0.012M; // strore a shared value
BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;
WriteLine("{0} earned {1:C} interest",
    jonesAccount.AccountName, jonesAccount.Balance * BankAccount.InterestRate);

Person blankPerson = new(initialName: "Garry", homePlanet: "Mars");
WriteLine("{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}",
    blankPerson.Name, blankPerson.HomePlanet, blankPerson.Instantiated);

// methods
bob.WriteToConsole();
WriteLine(bob.GetOrigin());

// tuples
(string, int) fruits = bob.GetFruit();
WriteLine($"{fruits.Item1}, {fruits.Item2} there are.");

// named fields of a tuples
var fruitNamed = bob.GetNamedFruit();
WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}.");

int a = 10;
int b = 20;
int c = 30;
WriteLine($"Before: a = {a}, b = {b}, c = {c}");
bob.PassingParameters(a, ref b, out c);
WriteLine($"After: a = {a}, b = {b}, c = {c}");

Person sam = new()
{
    Name = "Sam",
    DateOfBirth = new(1966, 9, 1)
};
WriteLine(sam.Origin);
WriteLine(sam.Greeting);
WriteLine(sam.Age);