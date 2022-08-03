
int first = TimesTwo(5);
Console.WriteLine(first);

int second = SomeNumber(); //We called the method that takes no paramaters and gives us back 20 
Console.WriteLine(second);

double area = CircleArea(3);
Console.WriteLine(area);

double area2 = TriangleArea(3, 3);
Console.WriteLine(area2);

PrintArea(10);



static int TimesTwo(int num)
{
    // the variables num and result have a scope of this function only. They don't exist outside of the function
    int result = num * 2;
    return result; // this result gets assigned to "first" as this is where the method was called 
}

static int SomeNumber()
{
    return 20;
}

static double CircleArea(double radius)
{
    return Math.PI * radius * radius;
}

static double TriangleArea(int height, int width)
{
    return height * width / 2.0;  //Add a .0 to the 2 to force the calculation to be a double. 
}

static void PrintArea(double radius) //Void will not return anything. This can be used to re-use methods to save time 
{
    double area = CircleArea(radius);
    Console.WriteLine(area);
}