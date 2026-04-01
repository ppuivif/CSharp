Console.WriteLine("----- declaration of the array -----\n");

string [] fraudulentOrderIDs = new string[3];

Console.WriteLine("\n----- array's content affectation -----\n");

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";

Console.WriteLine("\n----- display part of the array's content -----\n");

Console.WriteLine($"first value of the array is : {fraudulentOrderIDs[0]}");

Console.WriteLine("\n----- new assignation for a part of the array's content -----\n");

fraudulentOrderIDs[0] = "D000";
Console.WriteLine($"reassigned first value of the array is : {fraudulentOrderIDs[0]}");

Console.WriteLine("\n----- declaration and initialization of the array -----\n");

string [] newFraudulentOrderIDs = ["A123", "B456", "C789"];

Console.WriteLine("\n----- declaration and initialization of the array in an old syntax -----\n");

string [] oldFraudulentOrderIDs = {"A123", "B456", "C789"};

Console.WriteLine("\n----- display length of the array -----\n");

Console.WriteLine($"number of array's values is : {fraudulentOrderIDs.Length}");

Console.WriteLine("\n----- display full array's content -----\n");

foreach (string ID in fraudulentOrderIDs)
{
    Console.WriteLine(ID);
}

Console.WriteLine("\n----- calculate cumulative amount of elements of the array -----\n");

int [] inventory = [ 100, 200, 300, 400, 500];
int sum = 0;
int index = 0;
foreach ( int item in inventory)
{
    sum += item;
    Console.WriteLine($"In locker {index}, you have {item} elements (running total: {sum})");
    index++;
}
Console.WriteLine($"total number of elements is : {sum}");
