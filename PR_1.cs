using System;
internal class Program
{
   static void Main()
    {
        double a, b, c;

        Console.Write("Введіть сторону a: ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть сторону b: ");
        b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть сторону c: ");
        c = Convert.ToDouble(Console.ReadLine());

        if (a <= 0 || b <= 0 || c <= 0)
        {
            Console.WriteLine("Помилка: сторони мають бути додатними.");
        }
        else if (a + b <= c || a + c <= b || b + c <= a)
        {
            Console.WriteLine("Трикутник з такими сторонами не існує.");
        }
        else
        {
            double p = a + b + c;
            double s = p / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            Console.WriteLine("Периметр: " + p);
            Console.WriteLine("Площа: " + area);

            if (a == b && b == c)
            {
                Console.WriteLine("Трикутник рівносторонній.");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Трикутник рівнобедрений.");
            }
            else
            {
                Console.WriteLine("Трикутник довільний.");
            }

            double max = Math.Max(a, Math.Max(b, c));
            double x, y;

            if (max == a)
            {
                x = b;
                y = c;
            }
            else if (max == b)
            {
                x = a;
                y = c;
            }
            else
            {
                x = a;
                y = b;
            }

            if (Math.Abs(max * max - x * x - y * y) < 0.000001)
            {
                Console.WriteLine("Трикутник прямокутний.");
            }
            else
            {
                Console.WriteLine("Трикутник не є прямокутним.");
            }
        }
    }
}