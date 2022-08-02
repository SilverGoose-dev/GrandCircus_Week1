// Display a table of powers. Ask the user if they would like to go again and loop back to the beginning 



Console.WriteLine("Learn your squares and cubes!\n\n");
bool keepGoing = true;
do
{
    Console.Write("Enter an integer:    ");
    Console.WriteLine();
    int input = Convert.ToInt32(Console.ReadLine());
    if (input >= 1291|| input < 1)
    {
        Console.WriteLine("Use a valid number that is between 1 and 1290");
        continue;
    }
    Console.WriteLine();
    Console.WriteLine("Number\t\t\tSquared\t\t\tCubed");
    Console.WriteLine("======\t\t\t======\t\t\t======");
    for (int count = 1; count <= input; count++)
    {

        Console.WriteLine($"{count}\t\t\t{count * count}\t\t\t{count * count * count}");
    }
    bool valid = true;
    do
    {
        Console.Write("Would you like to go again? (y/n) ");
        string entry = Console.ReadLine().ToLower();


        if (entry == "n" || entry == "no")
        {
            valid = true;
            keepGoing = false;
        }
        else if (entry == "y" || entry == "yes")
        {
            valid = true;
        }
    } while (valid == false);

} while (keepGoing == true);

    