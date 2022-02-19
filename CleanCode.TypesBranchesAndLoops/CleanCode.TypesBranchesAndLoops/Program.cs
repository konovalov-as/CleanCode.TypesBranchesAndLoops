// See https://aka.ms/new-console-template for more information
using System;

namespace YourNamespace
{
    class TestClass
    {
    }

    struct TestStruct
    {
    }

    interface TestInterface
    {
    }

    delegate int TestDelegate();

    enum TestEnum
    {
    }

    namespace TestNestedNamespace
    {
        struct TestStruct
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine(10d);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);
            
            Console.WriteLine();
            Console.WriteLine("C# operators and expressions");
            int a = 5, b = 63, c = 969;
            Console.WriteLine($"a = {a}, b = {b}, c = {c}");
            Console.WriteLine($"b++ = {c = b++}");
            Console.WriteLine($"c = {c}");
            Console.WriteLine($"c = {c}");
            c = ++b;
            Console.WriteLine($"++b = {c}");
            b = a + b * c;
            Console.WriteLine($"a + b * c = {b}");
            c = a >= 215 ? b : c / 33;
            Console.WriteLine($"a >= 215 ? b : c / 33 = {c}");
            a = (int)Math.Sqrt(b * b + c * c);
            Console.WriteLine($"(int)Math.Sqrt(b * b + c * c) = {c}");

            Console.WriteLine();
            string str = "It's the most important string";
            Console.WriteLine($"str = {str}");
            char literal = str[str.Length - 1];
            Console.WriteLine($"str[str.Length - 1] = {literal}");

            Console.WriteLine();
            var numbers = new List<int>(new[] { 1, 2, 3, 4, 5, 6, 7, 8 });
            Console.WriteLine($"new List<int>(new[] 1, 2, 3, 4, 5, 6, 7, 8) = {numbers}");
            b = numbers.FindLast(n => n > 1);
            Console.WriteLine($"numbers.FindLast(n => n > 1) = {b}");

            Console.WriteLine();
            Console.WriteLine("Interpolated string expressions");
            var radius = 7.77;
            var message = $"The area of a circle with radius {radius} is {Math.PI * radius * radius:F3}.";
            Console.WriteLine(message);

            Console.WriteLine();
            Console.WriteLine("Lambda expressions");
            int[] numbers2 = { 2, 3, 4, 5, 6, 7, 8, 9 };
            var maximumSquare = numbers2.Max(x => x * x);
            Console.WriteLine(maximumSquare);

            Console.WriteLine();
            Console.WriteLine("Query expressions");
            var scores = new[] { 9, 179, 877, 65, 1085, 45 };
            IEnumerable<int> highScoresQuery =
                from score in scores
                where score > 80
                orderby score descending
                select score;
            Console.WriteLine(string.Join(" ", highScoresQuery));

            Console.WriteLine();
            Console.WriteLine("Operator precedence");
            var d = 5 + 5 * 5;
            Console.WriteLine($"5 + 5 * 5 = {d}");
            var e = (5 + 5) * 5;
            Console.WriteLine($"(5 + 5) * 5 = {e}");

            Console.WriteLine();
            Console.WriteLine("Operator associativity");
            int f = 13 / 5 / 2;
            int g = 13 / (5 / 2);
            Console.WriteLine($"13 / 5 / 2 = {f}");
            Console.WriteLine($"13 / (5 / 2) = {g}");

            Console.WriteLine();
            Console.WriteLine("Arithmetic operators");
            Console.WriteLine("Increment operator ++");
            int i = 100;
            Console.WriteLine($"i = {i}");
            Console.WriteLine($"i++ = {i++}");
            Console.WriteLine($"i = {i}");

            Console.WriteLine();
            Console.WriteLine("Postfix increment operator");
            double j = 100.101;
            Console.WriteLine($"j= {j}");
            Console.WriteLine($"++j = {++j}");
            Console.WriteLine($"j = {j}");

            Console.WriteLine();
            Console.WriteLine("Decrement operator --");
            int x = 100;
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"x++ = {x--}");
            Console.WriteLine($"x = {x}");

            Console.WriteLine();
            Console.WriteLine("Postfix decrement operator");
            double y = 100.101;
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"--y = {--y}");
            Console.WriteLine($"y = {y}");

            Console.WriteLine();
            Console.WriteLine("Unary plus and minus operators");
            Console.WriteLine($"+10: {+10}");
            Console.WriteLine($"-10: {-10}");
            Console.WriteLine($"-(-10): {-(-10)}");

            uint k = 10;
            var m = -k;
            Console.WriteLine($"m = {m}");
            Console.WriteLine($"b.GetType() = {b.GetType()}");
            Console.WriteLine($"-double.NaN = {-double.NaN}");

            Console.WriteLine();
            Console.WriteLine("Multiplication operator *");
            Console.WriteLine($"5 * 2 = {5 * 2}");
            Console.WriteLine($"0.5 * 2.5 = {0.5 * 2.5}");
            Console.WriteLine($"0.1m * 23.4m = {0.1m * 23.4m}");

            Console.WriteLine();
            Console.WriteLine("Division operator /");
            Console.WriteLine("Integer division");
            Console.WriteLine($"14 / 5 = {14 / 5}");
            Console.WriteLine($"-14 / 5 = {-14 / 5}");
            Console.WriteLine($"14 / -5 = {14 / -5}");
            Console.WriteLine($"-14 / -5 = {-14 / -5}");

            Console.WriteLine();
            Console.WriteLine("Floating-point number");
            Console.WriteLine($"13 / 5.0 = {13 / 5.0}");
            Console.WriteLine($"(double)13 / 5 = {(double)13 / 5}");

            Console.WriteLine();
            Console.WriteLine("Floating-point division");
            Console.WriteLine($"16.8f / 4.1f = {16.8f / 4.1f}");
            Console.WriteLine($"16.8d / 4.1d = {16.8d / 4.1d}");
            Console.WriteLine($"16.8m / 4.1m = {16.8m / 4.1m}");

            Console.WriteLine();
            Console.WriteLine("Remainder operator %");
            Console.WriteLine("Integer remainder");
            Console.WriteLine($"5 % 4 = {5 % 4}");
            Console.WriteLine($"5 % -4 = {5 % -4}");
            Console.WriteLine($"-5 % 4 = {-5 % 4}");
            Console.WriteLine($"-5 % -4 = {-5 % -4}");

            Console.WriteLine();
            Console.WriteLine("Floating-point remainder");
            Console.WriteLine($"-5.2f % 2.0f = {-5.2f % 2.0f}");
            Console.WriteLine($"5.9 % 3.1 = {5.9 % 3.1}");
            Console.WriteLine($"5.9m % 3.1m = {5.9m % 3.1m}");

            Console.WriteLine();
            Console.WriteLine("Addition operator +");
            Console.WriteLine($"5 + 4 = {5 + 4}");
            Console.WriteLine($"5 + 4.3 = {5 + 4.3}");
            Console.WriteLine($"5.1m + 4.2m = {5.1m + 4.2m}");

            Console.WriteLine();
            Console.WriteLine("Subtraction operator -");
            Console.WriteLine($"47 - 3 = {47 - 3}");
            Console.WriteLine($"5 - 4.3 = {5 - 4.3}");
            Console.WriteLine($"7.5m - 2.3m = 7.5m - 2.3m");

            Console.WriteLine();
            Console.WriteLine("Compound assignment");
            int h = 5;
            Console.WriteLine($"h = {h}");
            Console.WriteLine($"h += 9 = {h += 9}");
            Console.WriteLine($"h -= 4 = {h -= 4}");
            Console.WriteLine($"h *= 2 = {h *= 2}");
            Console.WriteLine($"h /= 4 = {h /= 4}");
            Console.WriteLine($"h %= 3 = { h %= 3 }");

            Console.WriteLine();
            Console.WriteLine("Integer arithmetic overflow");
            int o = int.MaxValue;
            int p = 3;
            Console.WriteLine($"{int.MaxValue} + {p} = {unchecked(o + p)}");  // output: -2147483646
            try
            {
                int r = checked(o + p);
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Overflow occurred when adding {o} to {p}.");
            }

            Console.WriteLine();
            Console.WriteLine("Floating-point arithmetic overflow");
            double q = 1.0 / 0.0;
            Console.WriteLine($"1.0 / 0.0 = {q}");
            Console.WriteLine($"1.0 / 0.0 IsInfinity = {double.IsInfinity(q)}");
            Console.WriteLine($"{double.MaxValue} + {double.MaxValue} = {double.MaxValue + double.MaxValue}");

            Console.WriteLine();
            double s = 0.0 / 0.0;
            Console.WriteLine($"0.0 / 0.0 = {s}");
            Console.WriteLine($"0.0 / 0.0 IsNaN = {double.IsNaN(s)}");

            Console.WriteLine();
            Console.WriteLine("Equality operator ==");
            int figure_a = 1 + 2 + 3;
            int figure_b = 6;
            Console.WriteLine($"{figure_a} == {figure_b} = {figure_a == figure_b}");
            char c1 = 'a';
            char c2 = 'A';
            Console.WriteLine($"{c1} == {c2} = {c1 == c2}");
            Console.WriteLine($"{c1} == char.ToLower({c2}) = {c1 == char.ToLower(c2)}");

            Console.WriteLine();
            Console.WriteLine("Inequality operator !=");
            int a1 = 1 + 1 + 2 + 3;
            int b1 = 6;
            Console.WriteLine($"{a1} != {b1} = {a1 != b1}");

            string s1 = "Hello";
            string s2 = "Hello";
            Console.WriteLine($"{s1} != {s2} = {s1 != s2}");

            object o1 = 1;
            object o2 = 1;
            Console.WriteLine($"{o1} != {o2} = {o1 != o2}");

            
            int a3 = 5;
            int b3 = 13;
            if (a3 + b3 > 10)
                Console.WriteLine($"{a3} + {b3} > 10 The answer is greater than 10");
            else
                Console.WriteLine($"{a3} + {b3} The answer is not greater than 10");

            Console.WriteLine();
            Console.WriteLine("Use loops to repeat operations");
            Console.WriteLine("while");
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }

            Console.WriteLine("do while");
            int counter2 = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter2}");
                counter2++;
            } while (counter2 < 10);

            Console.WriteLine("for");
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"Hello World! The index is {index}");
            }

            Console.WriteLine("Another loop can generate the columns");
            for (char column = 'a'; column < 'k'; column++)
            {
                Console.WriteLine($"The column is {column}");
            }

            Console.WriteLine("You can nest one loop inside the other to form pairs");
            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }
        }
    }
}