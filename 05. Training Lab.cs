double w = double.Parse(Console.ReadLine());
double h = double.Parse(Console.ReadLine());
double c = 1;
double space = h - c;
double DesksPerRows = Math.Floor(space / 0.7);
double rows = Math.Floor(w / 1.2);
double Desks = DesksPerRows * rows - 3;
Console.WriteLine(Desks);
