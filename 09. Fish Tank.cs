double lenght = double.Parse(Console.ReadLine());
double width  = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine());
var volume = lenght * width * height;
var litres = volume / 1000;
var full = litres * (percent / 100);
var needed = litres - full;
Console.WriteLine(needed);