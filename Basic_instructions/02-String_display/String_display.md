## C# Console Application : different ways to display a string

### Goal
Display simple messages in the console using different way.

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
