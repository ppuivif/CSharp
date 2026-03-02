Random random = new Random();
int roll1 = random.Next(1, 7);
int roll2 = random.Next(1, 7);
int largestValue = Math.Max(roll1, roll2);

Console.WriteLine($"First roll is : {roll1}");
Console.WriteLine($"First roll is : {roll2}");
if (roll1 == roll2)
{
    Console.WriteLine($"The two values are equal !");
}
else
{
    Console.WriteLine($"The largest value is : {largestValue}");
}    
