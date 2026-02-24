Console.WriteLine("\n----- display strings using character escape -----\n");

Console.Write("Path to project 1 is : c:/Project/Project1\n");
Console.WriteLine(@"Path to project 2 is :
        c:/Project/Project2");

Console.WriteLine("\n\n----- display a string using string concatenation -----\n");

string projectName = "projectName";
string path = "c:/Project/" + projectName;
Console.WriteLine("Path to " + projectName + " is : " + path);

Console.WriteLine("\n\n----- display strings using string interpolation -----\n");

projectName = "newProject";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianPath = path + "/ru-RU";
Console.WriteLine($"View English output :\n\t{path}/{projectName}\n");
Console.WriteLine($"{russianMessage} :\n\t{russianPath}/{projectName}");
