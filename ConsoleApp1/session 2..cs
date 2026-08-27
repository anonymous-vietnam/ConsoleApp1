using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Class1
    {
        private static void Main2(string[] args)
        {
            Console.Write("Enter number of celsius:");
            int celsius = Convert.ToInt32(Console.ReadLine());
            int fahrenheit = celsius + 273;
            int kelvin = celsius * 18 / 10 + 32;
            Console.WriteLine($"fahrenheit = {fahrenheit}");
            Console.WriteLine($"kelvin = {kelvin}");

            Console.Write("Enter number of radius:");
            float radius = Convert.ToSingle(Console.ReadLine());
            float surface =(float)( 4f * Math.PI * radius * radius);
            float volume = (float)(4f / 3f * Math.PI * radius * radius * radius);
            Console.WriteLine($"Surface of sphere = { surface}");
            Console.WriteLine($"Volume of sphere = { volume}");

            Console.Write("a=");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.Write("b=");
            float b = Convert.ToSingle(Console.ReadLine());
            float c = a + b;
            float d = a - b;
            float e = a * b;
            float g = a / b;
            float h = a % b;
            Console.WriteLine($"{a} + {b} = {c}");
            Console.WriteLine($"{a} - {b} = {d}");
            Console.WriteLine($"{a} * {b} = {e}");
            Console.WriteLine($"{a} / {b} = {g}");
            Console.WriteLine($"{a} % {b} = {h}");
        }
    }
}
