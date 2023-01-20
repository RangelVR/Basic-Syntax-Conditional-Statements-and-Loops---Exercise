double money = double.Parse(Console.ReadLine());
int students = int.Parse(Console.ReadLine());
double saberPrice = double.Parse(Console.ReadLine());
double robePrice = double.Parse(Console.ReadLine());
double beltPrice = double.Parse(Console.ReadLine());

double priceOfBelts = students * beltPrice;
double priceOfSabers = Math.Ceiling(students * 1.1) * saberPrice;
double priceOfRobes = students * robePrice;


if (students >= 6)
{
    priceOfBelts -= (students / 6) * beltPrice;
}

double neededMoney = priceOfBelts + priceOfSabers + priceOfRobes;

if (neededMoney <= money)
{
    Console.WriteLine($"The money is enough - it would cost {neededMoney:f2}lv.");
}
else
{
    Console.WriteLine($"John will need {(neededMoney - money):f2}lv more.");
}