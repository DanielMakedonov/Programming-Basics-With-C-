double HolidayPrice = double.Parse(Console.ReadLine());
int puzzle = int.Parse(Console.ReadLine());
int talkingDolls = int.Parse(Console.ReadLine());
int teddyBear = int.Parse(Console.ReadLine());
int minions = int.Parse(Console.ReadLine());
int trucks = int.Parse(Console.ReadLine());

double puzzlePrice = puzzle * 2.60;
int talkingDollPrice = talkingDolls * 3;
double teddyBearPrice = teddyBear * 4.10;
double minionsPrice = minions * 8.20;
int trucksPrice = trucks * 2;

double bill =  puzzlePrice +  talkingDollPrice + teddyBearPrice +  minionsPrice +  trucksPrice;
double NumberOfToys = puzzle + talkingDolls + teddyBear + minions + trucks;


if (NumberOfToys >= 50)
{
    bill = bill - bill * 0.25;
}

double rent = bill * 0.1;

double income = bill - rent;


if (income >= HolidayPrice)
{
    Console.WriteLine($"Yes! {income - HolidayPrice:F2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {HolidayPrice - income:F2} lv needed.");
}
