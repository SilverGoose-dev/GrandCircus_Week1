// Prompts user to enter a number between 1 and 100
// display the associated result based on the integer range entered
//****** if the integer entered is odd and less than 60, print the number entered and "Odd and less than 60"
//If the integer entered is even and in the inclusive range of 2 to 24, print “Even and less than 25.”
// ******If the integer entered is even and in the inclusive range of 26 to 60, print “Even and between 26 and 60 inclusive.”
// *****If the integer entered is even and greater than 60, print the number entered and “Even and greater than 60.”
//****** If the integer entered is odd and greater than 60, print the number entered and “Odd and greater than 60.”

// BONUS
// Ask the user if they want to continue 
// Ask for user information (ex. name) at the beginning of the application, and use it to refer to the user throughout the application.
// Add validation to guarantee that a user enters a positive integer between 1 and 100.
//bool playAgain = true;
bool keepGoing = true;
do
{
    Console.WriteLine("Please insert a number between 1 and 100 and I will analyze it for you!");
    string userInput = Console.ReadLine();
    int userNumber;
    bool IsRealInteger = int.TryParse(userInput, out userNumber);
    

    if (IsRealInteger = false||userNumber > 100 || userNumber < 1)
    {
        Console.WriteLine("Hey! That's not a valid number");
        continue;

    }
    else if (userNumber % 2 == 1 && userNumber < 60 )
    {
        Console.WriteLine("Odd and less than 60");
        Console.WriteLine();
    }
    else if (userNumber % 2 == 1 && userNumber > 60 )
    {
        Console.WriteLine("Odd and greater than 60");
        Console.WriteLine();
    }
    else if (userNumber % 2 == 0 && userNumber > 60)
    {
        Console.WriteLine("Even and greater than 60");
        Console.WriteLine();
    }
    else if (userNumber % 2 == 0 && userNumber >= 26 && userNumber <= 60)
    {
        Console.WriteLine("Even and between 26 and 60 inclusive");
        Console.WriteLine();
    }
    else if (userNumber % 2 == 0 && userNumber >= 2 && userNumber <= 24)
    {
        Console.WriteLine("Even and less than 25");
        Console.WriteLine();
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

