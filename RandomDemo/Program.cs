Random rand = new Random();

for (int i = 0; i <= 10; i++)
{
    int num = rand.Next(1,21);
    Console.WriteLine(num+1);
}