// For loop (for TAB TAB for shorthand)

for (int index = 0; index < 10; index ++) // statement, expression, incriment. These are the parts that create a for loop.  It will continue until the expression is true or false
{
    Console.WriteLine(index);
}

Console.WriteLine();

for (int index = 0; index < 10; index+=2) // the variable declared in the loop will only exist in the loop then it is forgotten 
{
    Console.WriteLine(index);
}

Console.WriteLine();

for (int index = 21; index >=9; index -= 3)
{
    Console.WriteLine(index);
}

Console.WriteLine("All done! On to While loops");
Console.WriteLine();

// While loop (While TAB TAB for shorthand)

int w = 1;

while (w < 5)
{
    Console.WriteLine("inside while loop.");
    Console.WriteLine(w);
    w++;
}

// Example of a break statement a while(true)
Console.WriteLine();

int w2 = 10;
while(w2 >= 0)
{
    if (w2 == 4)
    {
        Console.WriteLine("oops, found corrunpted data");
        break; //exits the loop immediately
    }
    Console.WriteLine(w2);
    w2--;
}

Console.WriteLine("Finished with while loops. On to do-while loops");
Console.WriteLine();
//Do-while loops
//While loops, the condition is tested before each iteration.
//do-while loops will test the condition after each iteration. 

int w3 = 0;
do //Code will always run at least once in a do-while loop since the condition is tested after
{
    Console.WriteLine(w3);
    w3++;
} while (w3 < 10);

Console.WriteLine("All done with do-while loops! Now on to nested for loop");

Console.WriteLine("How about a clock!");

for (int hour = 0; hour < 24; hour++)
{
    Console.WriteLine($"The hour is {hour}");
    for (int minute = 0; minute < 60; minute++) //inner loop contains the faster looping 
    {
        Console.WriteLine($"{hour}:{minute}");
    }
}


