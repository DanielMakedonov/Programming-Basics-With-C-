double r = double.Parse (Console.ReadLine ());
double calculatedArea = Math.PI * r * r;
double calculatedParameter = 2 * Math.PI * r;
Console.WriteLine($"{calculatedArea:F2}");
Console.WriteLine($"{calculatedParameter:F2}");


