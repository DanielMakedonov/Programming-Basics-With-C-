string figure = Console.ReadLine();
if (figure == "square")
{
    double a = double. Parse(Console.ReadLine());
    double result = a * a;
    Console.WriteLine($"{result:F3}");
}
else if (figure == "rectangle")
{
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double result = a * b;
    Console.WriteLine($"{result:F3}");
}
else if (figure == "circle")
{
    double r = double.Parse(Console.ReadLine());
    double result = Math.PI * r * r;
    Console.WriteLine($"{result:F3}");
}
else if (figure == "triangle")
{
    double a = double.Parse(Console.ReadLine());
    double h = double.Parse(Console.ReadLine());
    double result = (a * h) / 2;
    Console.WriteLine($"{result:F3}");
}
