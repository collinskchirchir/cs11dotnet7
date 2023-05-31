partial class Program
{
	static void TimesTable(byte number, byte size = 12)
	{
		WriteLine($"This is the {number} times table with {size} rows:");
		for (int row = 1; row <= size; row++)
		{
			WriteLine($"{row} x {number} = {row * number}");
		}
		WriteLine();
	}
}
