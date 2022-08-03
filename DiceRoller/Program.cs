using System.Threading.Tasks;

bool keepPlaying = true;

while (keepPlaying)
{
    Console.WriteLine("Welcome to the dice roller!!\n");
    Console.Write("Please choose the dice format and we will roll 2 of that type:\n");
    Console.WriteLine("1:  D4");
    Console.WriteLine("2:  D6");
    Console.WriteLine("3:  D8");
    Console.WriteLine("4:  D10");
    Console.WriteLine("5:  D12");
    Console.WriteLine("6:  D20\n");
    string choiceAsString = Console.ReadLine();
    int choice;
    bool sucessfulChoice = int.TryParse(choiceAsString, out choice);
    if (!sucessfulChoice || choice <1 || choice > 6)
    {
        
        
        Console.WriteLine("Hey! That is not a valid option!");
        Thread.Sleep(1500);
        Console.WriteLine("Try again!\n\n");
        Thread.Sleep(1000);
        continue;
    }
    else
    {
        switch (choice)
        {
            case 1:

                int d4_1 = RandomNumberGenerator(1, 5);
                int d4_2 = RandomNumberGenerator(1, 5);
                Console.WriteLine("Rolling...");
                Thread.Sleep(1500);
                Console.WriteLine($"{d4_1} and {d4_2}");
                break;
            case 2:
                int d6_1 = RandomNumberGenerator(1, 7);
                int d6_2 = RandomNumberGenerator(1, 7);
                Console.WriteLine("Rolling...");
                Thread.Sleep(1500);
                d6Combination(d6_1, d6_2);
                break;
            case 3:
                int d8_1 = RandomNumberGenerator(1, 9);
                int d8_2 = RandomNumberGenerator(1, 9);
                Console.WriteLine("Rolling...");
                Thread.Sleep(1500);
                Console.WriteLine($"{d8_1} and {d8_2}");
                break;
            case 4:
                int d10_1 = RandomNumberGenerator(1, 11);
                int d10_2 = RandomNumberGenerator(1, 11);
                Console.WriteLine("Rolling...");
                Thread.Sleep(1500);
                Console.WriteLine($"{d10_1} and {d10_2}");
                break;
            case 5:
                int d12_1 = RandomNumberGenerator(1, 13);
                int d12_2 = RandomNumberGenerator(1, 13);
                Console.WriteLine("Rolling...");
                Thread.Sleep(1500);
                Console.WriteLine($"{d12_1} and {d12_2}");
                break;
            case 6:
                int d20_1 = RandomNumberGenerator(1, 21);
                int d20_2 = RandomNumberGenerator(1, 21);
                Console.WriteLine("Rolling...");
                Thread.Sleep(1500);
                criticalHit(d20_1, d20_2);
                break;
        }

        Console.WriteLine("Would you like to roll again? (Y or N)");
        string continuing = Console.ReadLine().ToLower();
        if (continuing == "y")
        {
            continue;
        }
        else
        {
            keepPlaying = false;
            Console.WriteLine("Thanks for playing!!!!");
        }
    }

}

//Console.Write("Please choose the dice amount:\t");
//string amountAsString = Console.ReadLine();
//int amount = Convert.ToInt32(amountAsString);


static int RandomNumberGenerator(int min, int max)
{
    Random rand = new Random();
    return rand.Next(min, max);
}

static void d6Combination(int d6_1, int d6_2)
{
    if (d6_1 == 1 && d6_2 == 1)
    {
         Console.WriteLine($"Snake Eyes: 1 and 1");
    }
    else if (d6_1 == 1 || d6_1 == 2 && d6_2 == 1 || d6_2 == 2)
    {
        Console.WriteLine($"Ace Deuce: A 1 and a 2");
    }
    else if (d6_1 == 6 && d6_2 == 6)
    {
        Console.WriteLine($"Box Cars: Two 6s\n{d6_1} and {d6_2}");
    }
    else if (d6_1 + d6_2 == 7 || d6_1 + d6_2 == 11)
    {
        Console.WriteLine($"Win: A total of 7 or 11.\n{d6_1} and {d6_2}");
    }
    else if (d6_1 + d6_2 == 2 || d6_1 + d6_2 == 3 || d6_1 + d6_2 == 12)
    {
        Console.WriteLine($"Craps!! Total is either 2, 3, or 12.\n{d6_1} and {d6_2}");
    }
    else
    {
        Console.WriteLine($"{d6_1} and {d6_2}");
    }
}

static void criticalHit(int d20_1, int d20_2)
{
    if (d20_1 == 20 && d20_2 == 20)
    {
        Console.WriteLine("MASSIVE CRITICAL HIT!!! 20 and 20!");
    }
}


