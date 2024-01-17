double budget = double.Parse(Console.ReadLine());
int videoCards = int.Parse(Console.ReadLine());
int processors  = int.Parse(Console.ReadLine());
int ramMemory  = int.Parse(Console.ReadLine());

int videoCardsPrice = videoCards * 250;
double processorsPricePerPiece = 0.35 * videoCardsPrice;
double ramMemoryPricePerPiece = 0.1 * videoCardsPrice;
double sum = videoCardsPrice + (ramMemoryPricePerPiece * ramMemory) + (processorsPricePerPiece * processors);

if (videoCards > processors)
{
    sum *= 0.85;
}
if (sum <= budget)
{
    Console.WriteLine($"You have {budget - sum:F2} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {sum - budget:F2} leva more!");
}