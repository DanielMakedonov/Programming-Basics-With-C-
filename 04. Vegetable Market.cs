double vegetablesPrice = double.Parse(Console.ReadLine());
double fruitsPrice = double.Parse(Console.ReadLine());
double vegetablesWeight = double.Parse(Console.ReadLine());
double fruitsWeight = double.Parse(Console.ReadLine());
double income = ((vegetablesPrice * vegetablesWeight) + (fruitsPrice * fruitsWeight)) / 1.94;
Console.WriteLine("{0:F2}", income);
