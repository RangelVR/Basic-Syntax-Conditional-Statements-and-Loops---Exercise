int age = int.Parse(Console.ReadLine());
string output = string.Empty;

switch (age)
{
    case <= 2: output = "baby"; break;
    case <= 13: output = "child"; break;
    case <= 19: output = "teenager"; break;
    case <= 65: output = "adult"; break;
    case > 65: output = "elder"; break;
}
Console.WriteLine(output);