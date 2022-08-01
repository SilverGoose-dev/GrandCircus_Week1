Console.WriteLine("Insert a number");
string entry = Console.ReadLine();
int n = int.Parse(entry);

if (n > 50)
{
    Console.WriteLine($"Yes, n is greater than 50");
    Console.WriteLine($"n is {n}");
}
else
{
    Console.WriteLine("No, n is not greater than 50");
    Console.WriteLine($"n is {n}");
}

// Let's see if a number is between 3 and 10 exclusives

if (n > 3 && n < 10)
{
    Console.WriteLine("Yes, n is between 3 and 10 exclusive");
}
else
{
    Console.WriteLine("No, n is not between 3 and 10 exclusive");
}

// Let's see if a number is between 3 and 10 inclusive

if (n >= 3 && n <= 10)
{
    Console.WriteLine("Yes, n is between 3 and 10 inclusive");
}
else
{
    Console.WriteLine("No, n is not between 3 and 10 inclusive");
}


