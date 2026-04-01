//string[] commands = [  "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" ];
Random random = new Random();
string[] commands = new String[10];

for (int i = 0; i < commands.Length; i++)
{
    int prefixValue = random.Next(64, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString();
    commands[i] = prefix + suffix;
}

foreach(string item in commands)
{
    if (item.StartsWith('B'))
    {
        Console.WriteLine(item);
    }
}