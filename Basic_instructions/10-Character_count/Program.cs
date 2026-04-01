/*
    This code reverses a message, counts the number of times
    a particular character appears, then prints the results
    to the console window
*/

string originalMessage = "Elu par cette crapule.";

char[] charArray = originalMessage.ToCharArray();
Array.Reverse(charArray);

char letterToCount = 'u';
int letterCount = 0;

foreach (char letter in charArray) {
    if (letter == letterToCount) {
        letterCount++;
    }
}

string revertMessage = new String(charArray);

Console.WriteLine(revertMessage);
Console.WriteLine($"{letterToCount} appears {letterCount} times.");