int pages = int.Parse(Console.ReadLine());
int reading = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());
int combine = pages / reading;
int hours = combine / days;
Console.WriteLine(hours);
