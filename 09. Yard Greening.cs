double squaremeter = double.Parse(Console.ReadLine());
double price = squaremeter * 7.61;
double discount = 0.18 * price;
double bill = price - discount;
Console.WriteLine("The final price is: {0} lv.", bill);
Console.WriteLine("The discount is: {0} lv.", discount);
