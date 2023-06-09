﻿using static System.Convert;

int a = 10;
double b = a; // and int can be safely cast into a double
WriteLine(b);

double c = 9.8;
int d = (int)c; 
WriteLine(d);

long e = 10;
int f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");


e = 5_000_000_000;
f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");

// Using System.Convert
double g = 11.5;
int h = ToInt32(g); // a method of System.Convert
WriteLine($"g is {g} and h is {h}");