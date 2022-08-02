// Switch Demo
// Switches are used for menu navigation
int n = 1;

if (n == 0)
{
    Console.WriteLine("Zero");
}
else if (n == 1)
{
    Console.WriteLine("One");
}
else if (n == 2)
{
    Console.WriteLine("Two");
}
else
{
    Console.WriteLine("I don't know");
}

switch (n)
{
    case 0:
        Console.WriteLine("Zero");
        break;
    case 1:
        Console.WriteLine("One");
        break;
    case 2:
        Console.WriteLine("Two");
        break;
    case 3:
    case 4:
        Console.WriteLine("It's either 3 or 4");
        break;
    case > 10:
        Console.WriteLine("Greater than 10");
        break;
    default:
        Console.WriteLine("I don't know");
        break;
}