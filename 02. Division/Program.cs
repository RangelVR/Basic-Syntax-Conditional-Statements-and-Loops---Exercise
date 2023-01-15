int n = int.Parse(Console.ReadLine());
int output = 0;

if (n % 10 == 0)
{
    output = 10;
}
else if (n % 7 == 0)
{
    output = 7;
}
else if (n % 6 == 0)
{
    output = 6;
}
else if (n % 3 == 0)
{
    output = 3;
}
else if (n % 2 == 0)
{
    output = 2;
}

if (output != 0)
{
    Console.WriteLine($"The number is divisible by {output}");
}
else
{
    Console.WriteLine("Not divisible");
}