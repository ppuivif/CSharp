## C# Console Application : implement a temperature converter from Fahrenheit degrees to Celsius degrees

### Goal
Hard coding a temperature in Fahrenheit degrees.
Calculate and display the conversion to Celsius degrees.
The result in Celsius degree is displayed in rounded decimal form, with a precision of 2 digit after dot.

### Instructions
- Fahrenheit degrees are chosen are integers (int type).
- Celsius degrees are decimals (decimal type).
- Operations with integers give integers.
- To explicite cast on a decimal celsius, use :
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
