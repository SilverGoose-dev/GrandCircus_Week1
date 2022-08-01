string name = "Fred";
Console.WriteLine(name);
string upperName = name.ToUpper(); // String are "immutable" This creates a new string with the .ToUpper Method
Console.WriteLine(upperName);
Console.WriteLine(name);

Console.WriteLine(name[0]);
Console.WriteLine(name[1]);

Console.WriteLine(name.ToLower());

//floating point types 

double pi = 3.14159256;
Console.WriteLine(pi);
double pi2 = pi * 2;
Console.WriteLine(pi2);

Console.WriteLine(      Math.Sqrt(pi)      );  //Called the Math class to find the square root of pi

double q = Math.Sqrt(25);
Console.WriteLine(q);

//float n = 3.1415926f;  We rarely use float these days. Put an F or f after it to initialize it. 

// WHEN WORKING WITH MONEY, DO NOT USE FLOAT OR DOUBLE. USE DECIMAL

decimal amount = 99.95m;  //use literal 'm' for money to initialize the decimal amount
amount = amount * 2;
Console.WriteLine(amount);

bool passed = true;
Console.WriteLine(passed);
passed = false;
Console.WriteLine(passed);
passed = !passed;       // '!' will flip the bool. It is called "Not". Passed was false; the "not" operator flips it to true. 