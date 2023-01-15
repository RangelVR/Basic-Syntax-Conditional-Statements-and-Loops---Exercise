string num = Console.ReadLine();
int sum = 0;


for (int i = 0; i < num.Length; i++)
{
    int n = (int)num[i] - '0';
    int factorial = 1;

    while (n > 1)
	{
		factorial *= n;
		n--;
	}
	sum += factorial;
}

int inputNum = int.Parse(num);

if (inputNum == sum)
{
	Console.WriteLine("yes");
}
else
{
	Console.WriteLine("no");
}