int group = int.Parse(Console.ReadLine());
string type = Console.ReadLine();
string day = Console.ReadLine();

double price = 0;
double totalPrice = 0;

if (type == "Students")
{
	switch (day)
	{
		case "Friday": price = 8.45; break;
		case "Saturday": price = 9.80; break;
		case "Sunday": price = 10.46; break;
	}
    if (group >= 30)
    {
        totalPrice = (price * group) * 0.85;
    }
    else
    {
        totalPrice = price * group;
    }
}
else if (type == "Business")
{
    switch (day)
    {
        case "Friday": price = 10.90; break;
        case "Saturday": price = 15.60; break;
        case "Sunday": price = 16.00; break;
    }
    if (group >= 100)
    {
        totalPrice = price * (group - 10);
    }
    else
    {
        totalPrice = price * group;
    }
}
else if (type == "Regular")
{
    switch (day)
    {
        case "Friday": price = 15.00; break;
        case "Saturday": price = 20.00; break;
        case "Sunday": price = 22.50; break;
    }
    if (group >= 10 && group <= 20)
    {
        totalPrice = (price * group) * 0.95;
    }
    else
    {
        totalPrice = price * group;
    }
}

Console.WriteLine($"Total price: {totalPrice:f2}");