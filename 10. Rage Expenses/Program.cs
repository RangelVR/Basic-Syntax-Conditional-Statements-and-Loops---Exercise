int lostGames = int.Parse(Console.ReadLine());
double headsetPrice = double.Parse(Console.ReadLine());
double mousePrice = double.Parse(Console.ReadLine());
double keyboardPrice = double.Parse(Console.ReadLine());
double displayPrice = double.Parse(Console.ReadLine());

double sumHeadsets = headsetPrice * (lostGames / 2);
double sumMouses = mousePrice * (lostGames / 3);
double sumKeyboards = keyboardPrice * (lostGames / 6);
double sumDisplays = displayPrice * (lostGames / 12);

double expenses = sumHeadsets + sumMouses + sumKeyboards + sumDisplays;

Console.WriteLine($"Rage expenses: {expenses:f2} lv.");




//int lostGames = int.Parse(Console.ReadLine());
//double headsetsPrice = double.Parse(Console.ReadLine()) * (lostGames / 2);
//double mousesPrice = double.Parse(Console.ReadLine()) * (lostGames / 3);
//double keyboardsPrice = double.Parse(Console.ReadLine()) * (lostGames / 6);
//double displaysPrice = double.Parse(Console.ReadLine()) * (lostGames / 12);


//double expenses = headsetsPrice + mousesPrice + keyboardsPrice + displaysPrice;

//Console.WriteLine($"Rage expenses: {expenses:f2} lv.");