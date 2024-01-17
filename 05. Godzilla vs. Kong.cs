double budget = double.Parse(Console.ReadLine());
int extra = int.Parse(Console.ReadLine());
double clothing = double.Parse(Console.ReadLine());

double decor = budget * 0.1;

if (extra >= 150)
{
    clothing = clothing - (clothing * 0.1);
}

double expense = decor + clothing * extra;
if (expense > budget)
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {expense - budget:F2} leva more.");
}
else
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {budget - expense:F2} leva left.");
}