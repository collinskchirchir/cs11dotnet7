WriteLine("Before Parsing");
Write("What is your age? ");
string? input = ReadLine();
if (string.IsNullOrEmpty(input)) return; // null-handling
try
{
    int age = int.Parse(input!); // the ! is a null-forgiving operator and disables compiler warning.
    WriteLine($"You are {age} years old.");
}
catch (FormatException) when (input.Contains("$")) // catching with filters
{
    WriteLine("The age you entered CANNOT contain a dollar symbol!");
}
catch (FormatException)
{
    WriteLine("The age you entered is not a valid number format.");
}
catch (OverflowException)
{
    WriteLine("Your age is a valid number format but it is either too biig or small");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} says {ex.Message}");
}
WriteLine("After Parsing");