double deposit = double.Parse(Console.ReadLine());
double period = double.Parse(Console.ReadLine());
double interest = double.Parse(Console.ReadLine());
double accumulated = deposit * (interest / 100);
double month = accumulated / 12;
var sum = deposit + period*month;
Console.WriteLine(sum);
