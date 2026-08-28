using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    internal class Caohuy
    {
        static void Bai_1()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("Nhập số thứ nhất:");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhập số thứ hai:");
            float b = Convert.ToSingle(Console.ReadLine());
            float c = a + b;
            float d = a - b;
            float e = a * b;
            float f = a / b;
            Console.WriteLine($" a + b = {c}");
            Console.WriteLine($" a - b = {d}");
            Console.WriteLine($" a * b = {e}");
            Console.WriteLine($" a / b = {f}");
        }
        static void Bai_2()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("x = y*y + 2*y + 1");
            int y = -4;
            int x = y * y + 2 * y + 1;
            Console.WriteLine($"x = {x} với y = {y}");
            int a = -3;
            int b = a * a + 2 * a + 1;
            Console.WriteLine($"x = {b} với y = {a}");
            int c = -2;
            int d = c * c + 2 * c + 1;
            Console.WriteLine($"x = {d} với y = {c}");
            int e = -1;
            int f = e * e + 2 * e + 1;
            Console.WriteLine($"x = {f} với y = {e}");
            int g = 0;
            int h = g * g + 2 * g + 1;
            Console.WriteLine($"x = {h} với y = {g}");
            int i = 1;
            int j = i * i + 2 * i + 1;
            Console.WriteLine($"x = {j} với y = {i}");
            int k = 2;
            int l = k * k + 2 * k + 1;
            Console.WriteLine($"x = {l} với y = {k}");
            int m = 3;
            int n = m * m + 2 * m + 1;
            Console.WriteLine($"x = {n} với y = {m}");
            int o = 4;
            int p = o * o + 2 * o + 1;
            Console.WriteLine($"x = {p} với y = {o}");
        }
        static void Bai_3()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("Khoảng cách(m):");
            float distance = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Thời gian đi:");
            Console.Write("Nhập giờ :");
            float hour = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhập phút :");
            float minute = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhập giây :");
            float second = Convert.ToSingle(Console.ReadLine());
            float time = hour + (minute * 60 + second) / 3600;
            float speed1 = distance / time;
            float speed2 = (distance / 1000) / time;
            Console.WriteLine($"Tốc độ ( km/h): {speed2} km/h");
            Console.WriteLine($"Tốc độ ( m/s): {speed1} m/s");
        }
        static void Bai_4()
        {
            Console.Write("Enter the radius:");
            double radius = Convert.ToDouble(Console.ReadLine());
            double volume = 4 / 3 * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine($"Volume of sphere: {volume}");
        }
        static void Bai_5()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào kí tự:");
            char ca = char.Parse(Console.ReadLine());
            char lowerCa = char.ToLower(ca);
            if (lowerCa == 'a' || lowerCa == 'e' || lowerCa == 'i' || lowerCa == 'o' || lowerCa == 'u')
            {
                Console.WriteLine($"{ca} là nguyên âm.");
            }
            else if (char.IsDigit(ca))
            {
                Console.WriteLine($"{ca} là chữ số.");
            }
            else
            {
                Console.WriteLine($"{ca} là kí hiệu khác.");
            }
        }
        static void Bai_6()
        {
            Console.Write("Enter a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter c:");
            double c = Convert.ToDouble(Console.ReadLine());
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if ( a == 0 )
            {
                double ff = -c / b;
                Console.WriteLine($"The equation has x = {ff}");
            }
            if (delta < 0)
                Console.WriteLine("The equation has no real roots.");
            if (delta == 0)
            {
                double e = -b / (2f * a);
                Console.WriteLine($"The equation has one real root: {e}");
            }
            if ( delta >0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"The equation has two real roots: {x1} and {x2}");
            }
        }
        static void Bai_7_1()
        {
            Console.Write("Enter your number:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
        }
        static void Bai_7_2()
        {
            Console.Write("Enter first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter third number:");
            double num3 = Convert.ToDouble(Console.ReadLine());
            double[] aray = { num1, num2, num3 };
            double max = aray.Max();
            Console.WriteLine($"The biggest number is: {max}");
        }
        static void Bai_7_3()
        {
            Console.Write("Enter the first side:");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second side:");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the third side:");
            double side3 = Convert.ToDouble(Console.ReadLine());
            if (side1 == side2 && side3 == side1)
                Console.WriteLine("The triangle is equilateral triangle");
            if (side1 == side2 && side3 != side1 || side2 == side3 && side2 != side1 || side3 == side1 && side2 != side1)
                Console.WriteLine("The triangle is isosceles triangle");
            if (side3 != side1 && side1 != side2)
                Console.WriteLine("The triangle is scalene triangle");
        }
        static void Bai_7_4()
        {
            Console.Write("Enter x=");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter y=");
            double y = Convert.ToDouble(Console.ReadLine());
            if (x > 0 && y > 0)
                Console.WriteLine($"The coordinate point ({x};{y}) lies in the first quadrant ");
            if (x > 0 && y < 0)
                Console.WriteLine($"The coordinate point ({x};{y}) lies in the fourth quadrant");
            if (x < 0 && y < 0)
                Console.WriteLine($"The coordinate point ({x};{y}) lies in the third quadrant");
            if (x < 0 && y > 0)
                Console.WriteLine($"The coordinate point ({x};{y}) lies in the second quadrant");
        }
        private static void Main(string[] args)
        {
            

        }
        

        

    }
}
