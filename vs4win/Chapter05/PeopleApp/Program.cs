using Packt.Shared;

Person bob = new();

bob.Name = "Bob Smith";
bob.DateOfBirth = new DateTime(1965, 12, 22); // C#1.0 or later
bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;

WriteLine("{0} was born on {1: dddd, d MMMM yyyy} and favorite wonder is {2}",
    bob.Name, bob.DateOfBirth, bob.FavoriteAncientWonder);

Person alice = new()
{
    Name = "Alice Jones",
    DateOfBirth = new(1998, 3, 7) // C# 9.0 or later
};
WriteLine("{0} was born on {1: dd MMMM yyyy}",
    alice.Name, alice.DateOfBirth);