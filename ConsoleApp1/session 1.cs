using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main1(string[] args)
    {
        int number1 = 10;
        int number2 = 12;
        //1.to Add / Sum Two Numbers.
        int sum = number1 + number2;
        Console.WriteLine($"{number1}+{number2}={sum}");
        //2.to Swap Values of Two Variables.
        Console.WriteLine($"Before swap number1 = {number1}, number2 = {number2}");
        int temp = number1;
        number1 = number2;
        number2 = temp;
        Console.WriteLine($"After swap number1 = {number1}, number2 = {number2}");
        //3.to Multiply two Floating Point Numbers
        float f1 = 5.1f; float f2 = 3.2f;
        float f3 = f1 * f2;
        Console.WriteLine($"{f1} * {f2} = {f3}");
        //4.to convert feet to meter
        double feet = 13.5;
        double meter = feet * 0.3048;
        Console.WriteLine($"{feet} feet = {meter} meters");
        //5.to convert Celsius to Fahrenheit and vice versa
        double fahrenheit1 = 37.6;
        double celsius1 = (fahrenheit1 - 32) * 5 / 9;
        Console.WriteLine($"{fahrenheit1} Fahrenheit = {celsius1} Celsius");
        double celsius2 = 25.0;
        double fahrenheit2 = (celsius2 * 9 / 5) + 32;
        Console.WriteLine($"{celsius2} Celsius = {fahrenheit2} Fahrenheit");
        //6.to find the Size of data types
        Console.WriteLine($" Size of double data : {sizeof(double)}");
        Console.WriteLine($" Size of int data : {sizeof(int)}");
        //7.to Print ASCII Value(tip: read character, print number of this char)
        Console.Write("Enter a character:");
        string input = Console.ReadLine();
        char c = input[0];
        Console.WriteLine($"ASCII code of {c} is {(int)c}");
        //8.to Calculate Area of Circle
        Console.WriteLine("Enter radius of circle:");
        float rad = Convert.ToSingle(Console.ReadLine());
        float area = rad * rad * 3.14f;
        Console.WriteLine($"Area of circle is {area}");
        //9.to Calculate Area of Square
        Console.WriteLine("Enter side of square:");
        float side = Convert.ToSingle(Console.ReadLine());
        float areaSquare = side * side;
        Console.WriteLine($"Area of square is {areaSquare}");
        //10.to convert days to years, weeks and days
        Console.WriteLine("Enter number of days:");
        int days = Convert.ToInt32(Console.ReadLine());
        int years = days / 365;
        int weeks  = (days - 365 * years) / 7;
        int daysleft = days - (years * 365 + weeks * 7);
        Console.WriteLine($"{days} days = {years} years, {weeks} weeks , {daysleft} days");
    }
}