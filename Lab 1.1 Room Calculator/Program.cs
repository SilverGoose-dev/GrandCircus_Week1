Console.WriteLine("Please insert the Length of the Room");
double length = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please insert the Width of the Room");
double width = Convert.ToDouble(Console.ReadLine());

const double height = 9;

double area = length * width;
double perimeter = (2 * length) + (2 * width);
double volume = length * width * height;
double surfaceArea = (length * width) * 2 + (width * height) *2  + (length * height) * 2;

if (area <= 250)
{
    Console.WriteLine($"Area: {area}. This is a small sized room");
    Console.WriteLine($"Perimeter: {perimeter}");
    Console.WriteLine($"Volume: {volume}");
    Console.WriteLine($"Surface Area: {surfaceArea}");
}

else if (area < 650)
{
    Console.WriteLine($"Area: {area}. This is a medium sized room");
    Console.WriteLine($"Perimeter: {perimeter}");
    Console.WriteLine($"Volume: {volume}");
    Console.WriteLine($"Surface Area: {surfaceArea}");
}

else
{
    Console.WriteLine($"Area: {area}. This is a large sized room");
    Console.WriteLine($"Perimeter: {perimeter}");
    Console.WriteLine($"Volume: {volume}");
    Console.WriteLine($"Surface Area: {surfaceArea}");
}
