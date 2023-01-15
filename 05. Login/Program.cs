
string userName = Console.ReadLine();
string password = string.Empty;

for (int i = userName.Length - 1; i >= 0; i--)
{
    password += userName[i];
}

int atempts = 4;

while (atempts > 0)
{
    string inputPass = Console.ReadLine();
    if (inputPass == password)
    {
        Console.WriteLine($"User {userName} logged in.");
        break;
    }
    else
    {
        atempts--;
        if (atempts > 0)
        {
            Console.WriteLine("Incorrect password. Try again.");
        }
    }
}

if (atempts == 0)
{
    Console.WriteLine($"User {userName} blocked!");
}