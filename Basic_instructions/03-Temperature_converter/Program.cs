int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * (5m / 9m);
int leadingDigit = (int) celsius;
int firstDigit = (int) (celsius * 10) % 10;
int secondDigit = (int) (celsius * 100) % 10;
decimal roundedCelsius = leadingDigit + firstDigit / 10m + (decimal) secondDigit / 100;
Console.WriteLine("The temperature is " + fahrenheit + " Fahrenheit.");
Console.WriteLine("The corresponding rounded temperature is " + roundedCelsius + " Celsius.");