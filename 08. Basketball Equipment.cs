double subscription = double.Parse(Console.ReadLine());
var sneakers = subscription - (subscription * 0.40);
var outfit = sneakers - (sneakers * 0.20);
var ball = outfit  * 0.25;
var others = ball  * 0.20;
var sum = subscription + sneakers + outfit + ball + others;
Console.WriteLine(sum);
