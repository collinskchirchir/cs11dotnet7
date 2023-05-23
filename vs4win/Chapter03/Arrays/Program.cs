string[] names; // can reference any size array of strings

// allocating memory for 4 strings in an array
names = new string[4];

// storing items at index positions

names[0] = "Kate";
names[1] = "Jack";
names[2] = "Rebecca";
names[3] = "Tom";


// alt to defining arrays

string[] names2 = new[] { "Kate", "Jack", "Rebbeca2", "Tom2" };

// looping through the names
for (int i = 0; i < names2.Length; i++)
{
    // output the item at index position 1
    WriteLine(names2[i]);
}