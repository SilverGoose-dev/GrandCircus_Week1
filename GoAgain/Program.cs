﻿// Instructions:


bool keepGoing = true;


do
{
    Console.Write("Please enter a number:  ");
    string entry = Console.ReadLine();
    double num = double.Parse(entry);
    Console.WriteLine($"That number squared is {num * num}");


    // Ask the user if they want to go again


    bool vaild = true;
    do
    {
        Console.Write("Would you like to go again? (y/n) ");
        entry = Console.ReadLine().ToLower();


        if (entry == "n" || entry == "no")
        {
            vaild = true;
            keepGoing = false;
        }
        else if (entry == "y" || entry == "yes")
        {
            vaild = true;
        }
    } while (vaild == false);

    
}while (keepGoing);