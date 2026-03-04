## C# Console Application : implement a temperature converter from Fahrenheit degrees to Celsius degrees

### Goal
The goal of this exercise is to write a simple C# console application that :
- stores a temperature expressed in Fahrenheit (hard-coded),
- converts it into Celsius,
- displays the result rounded to 2 decimal places.

### Instructions
- Fahrenheit degrees are chosen are integers (int type).
- Celsius degrees are decimals (decimal type).
- Integer division returns an integer result, unless at least one operand is a decimal.
- To explicitly cast a decimal to an integer, use :
```C#
(int) celsius;
```
- To obtain a decimal when operating on integers, use at least a decimal dividend or a decimal divider :
```C#
int a = 1;
int b = 2;
decimal c = (decimal) a / b;
```
or
```
int a = 1;
decimal c = a / 10m;
```
- Use modulo to build a decimal.
To calculate the first digit from `decimal degree` :
```C#
int firstDigit = (int) (celsius * 10) % 10;
```
- If necessary, don't forget to check that divider is different form 0.

### Business rules
To convert Fahrenheit degrees to Celsius degrees, you have to use the following rule :
```
celsius degree = (fahrenheit degree - 32) * (5 / 9)
```

### Example of output
```Output
The temperature is 94 Fahrenheit.
The corresponding rounded temperature is 34.44 Celsius.
```
