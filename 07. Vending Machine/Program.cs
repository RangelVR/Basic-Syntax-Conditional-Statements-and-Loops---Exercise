using System.Runtime.Intrinsics.Arm;
using System.Transactions;

string command = Console.ReadLine();
double sum = 0;

double NUTS = 2.0;
double WATER = 0.7;
double CRISPS = 1.5;
double SODA = 0.8;
double COKE = 1.0;

while (command != "Start")
{
	double coin = double.Parse(command);

	switch (coin)
	{
		case 0.1:
		case 0.2:
		case 0.5:
		case 1: 
		case 2: 
			sum += coin;
			break;
		default: 
			Console.WriteLine($"Cannot accept {coin}");
			break;
	}

	command = Console.ReadLine();
}

string product = Console.ReadLine().ToLower();

while (product != "end")
{
	switch (product)
	{
		case "nuts":
			if (sum - NUTS >= 0)
			{
                Console.WriteLine($"Purchased {product}");
                sum -= NUTS;
            }
			else
			{
				Console.WriteLine("Sorry, not enough money");
			}
			break;
        case "water":
			if (sum - WATER >= 0)
			{
                Console.WriteLine($"Purchased {product}");
                sum -= WATER;
			}
			else
			{
                Console.WriteLine("Sorry, not enough money");
            }
            break;
        case "crisps":
            if (sum - CRISPS >= 0)
            {
                Console.WriteLine($"Purchased {product}");
                sum -= CRISPS;
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
            }
            break;
        case "soda":
            if (sum - SODA >= 0)
            {
                Console.WriteLine($"Purchased {product}");
                sum -= SODA;
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
            }
            break;
        case "coke":
            if (sum - COKE >= 0)
            {
                Console.WriteLine($"Purchased {product}");
                sum -= COKE;
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
            }
            break;

        default:
			Console.WriteLine("Invalid product");
			break;
	}
	product = Console.ReadLine().ToLower();
}

Console.WriteLine($"Change: {sum:f2}");
