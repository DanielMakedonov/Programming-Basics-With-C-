double record = double.Parse(Console.ReadLine());
double distanceInMeters = double.Parse(Console.ReadLine());
double timeInSecondsForOneMeter  = double.Parse(Console.ReadLine());

double timeForSwim = distanceInMeters * timeInSecondsForOneMeter;

double timesDelay = Math.Floor(distanceInMeters / 15);
double finalTimeForSwimming = timeForSwim + timesDelay * 12.5;
if (finalTimeForSwimming < record)
{
    Console.WriteLine($" Yes, he succeeded! The new world record is {finalTimeForSwimming:F2} seconds.");
}
else
{
    Console.WriteLine($"No, he failed! He was {finalTimeForSwimming - record:F2} seconds slower.");
}
