string rowSeparator = new('-', count: 74);
WriteLine(rowSeparator);

WriteLine("{0,-8}{1}{2,18}{3,31}",
    "Type",
    "Byte(s) of memory",
    "Min",
    "Max");

WriteLine(rowSeparator);

WriteLine("{0,-8}{1,-4}{2,31}{3,31}", "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
WriteLine("{0,-8}{1,-4}{2,31}{3,31}", "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
WriteLine("{0,-8}{1,-4}{2,31}{3,31}", "short", sizeof(short), short.MinValue, short.MaxValue);
WriteLine("{0,-8}{1,-4}{2,31}{3,31}", "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
WriteLine("{0,-8}{1,-4}{2,31}{3,31}", "int", sizeof(int), int.MinValue, int.MaxValue);
WriteLine("{0,-8}{1,-4}{2,31}{3,31}", "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
WriteLine("{0,-8}{1,-4}{2,31}{3,31}", "long", sizeof(long), long.MinValue, long.MaxValue);
WriteLine("{0,-8}{1,-4}{2,31}{3,31}", "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
WriteLine("{0,-8}{1,-4}{2,31}{3,31}", "float", sizeof(float), float.MinValue, float.MaxValue);
WriteLine("{0,-8}{1,-4}{2,31}{3,31}", "double", sizeof(double), double.MinValue, double.MaxValue);
WriteLine("{0,-8}{1,-4}{2,31}{3,31}", "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);

WriteLine(rowSeparator);