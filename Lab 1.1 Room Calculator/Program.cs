Console.WriteLine("Please insert the Length of the Room");
double length = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please insert the Width of the Room");
double width = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please insert the height");
double height = Convert.ToDouble(Console.ReadLine());

double area = length * width;
double perimeter = (length + width) * 2;
double volume = length * width * height;
double surfaceArea = (length * width) + (length * width) + (width * height) + (width * height) + (length * height) + (length * height);

if (area < 250)
{
    Console.WriteLine($"Area: {area}. This is a small sized room");
    Console.WriteLine($"Perimeter: {perimeter}");
    Console.WriteLine($"Volume: {volume}");
    Console.WriteLine($"Surface Area: {surfaceArea}");
}

else if (area > 250 && area < 650)
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
