## C# Console Application : different ways to display a string

### Goal
Reproduce the following messages :
```OUTPUT
Path to project 1 is : C:/Project/Project1
Path to project 2 is :
        C:/Project/Project
```

```OUTPUT
Path to projectName is : C:/Project/projectName
```

```OUTPUT
View English output :
        C:/Project/projectName/newProject

Посмотреть русский вывод :
        C:/Project/projectName/ru-RU/newProject
```

### Instructions
Use the `Console.WriteLine` and `Console.Write` methods to print the text.
Use :
 - escape character `\`, carrior return `\n`, tabulation `\t` ,
 - string concatenation,
 - string interpolation.

### Examples
```C#
Console.WriteLine(@"Hello \
    World !");
```

```C#
Console.Write("Hello \\\n\tWorld !\n");
```

```C#
string message = "Hello \\";
Console.WriteLine(message + "\n\tWorld !");
```

```C#
string message = "Hello \\";
Console.WriteLine($"{message}\n\tWorld !");
```
