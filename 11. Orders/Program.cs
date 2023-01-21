int orders = int.Parse(Console.ReadLine());

double totalPrice = 0;

for (int i = 0; i < orders; i++)
{
    double capsulePrice = double.Parse(Console.ReadLine());
    int days = int.Parse((Console.ReadLine()));
    int capsules = int.Parse(Console.ReadLine());

    double cofePrice = 0;
    cofePrice = days * capsules * capsulePrice;
    Console.WriteLine($"The price for the coffee is: ${cofePrice:f2}");
    totalPrice += cofePrice;
}

Console.WriteLine($"Total: ${totalPrice:f2}");