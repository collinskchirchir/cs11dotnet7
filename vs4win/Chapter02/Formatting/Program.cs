//Write("Type your first name and press ENTER: ");
//string firstName = ReadLine();
//Write("Type your age and press ENTER: ");
//string age = ReadLine();
//WriteLine($"Hello {firstName}, you look good for {age}");

// Getting key input from the user using ReadKey method
Write("Press any key combination");
ConsoleKeyInfo key = Console.ReadKey();
WriteLine();
WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
    key.Key,
    key.KeyChar,
    key.Modifiers);
