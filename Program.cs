#region Q1
// Part 1 — Enums
// using System;

// enum DayOfWeekEnum
// {
//     Saturday,
//     Sunday,
//     Monday,
//     Tuesday,
//     Wednesday,
//     Thursday,
//     Friday
// }

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter a day number (0-6): ");
//         int num = int.Parse(Console.ReadLine());

//         DayOfWeekEnum day = (DayOfWeekEnum)num;

//         Console.WriteLine("Day: " + day);

//         switch (day)
//         {
//             case DayOfWeekEnum.Saturday:
//             case DayOfWeekEnum.Friday:
//                 Console.WriteLine("It's the Weekend");
//                 break;

//             default:
//                 Console.WriteLine("It's a Workday");
//                 break;
//         }
//     }
// }
 #endregion
#region Q2
// Part 2 — Arrays (Array Statistics)

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter array size: ");
//         int size = int.Parse(Console.ReadLine());

//         int[] arr = new int[size];

//         for (int i = 0; i < size; i++)
//         {
//             Console.Write($"Enter element [{i}]: ");
//             arr[i] = int.Parse(Console.ReadLine());
//         }

//         int sum = 0;
//         int max = arr[0];
//         int min = arr[0];

//         for (int i = 0; i < size; i++)
//         {
//             sum += arr[i];

//             if (arr[i] > max)
//                 max = arr[i];

//             if (arr[i] < min)
//                 min = arr[i];
//         }

//         double avg = (double)sum / size;

//         Console.WriteLine("Sum = " + sum);
//         Console.WriteLine("Average = " + avg);
//         Console.WriteLine("Max = " + max);
//         Console.WriteLine("Min = " + min);

//         Console.Write("Reverse = ");

//         for (int i = size - 1; i >= 0; i--)
//             Console.Write(arr[i] + " ");
//     }
// }
// Part 2 — Q2 (Matrix)

// using System;

// class Program
// {
//     static void Main()
//     {
//         int[,] grades = new int[3, 4];
//         double total = 0;

//         for (int i = 0; i < 3; i++)
//         {
//             int sum = 0;

//             Console.WriteLine($"Student {i + 1}");

//             for (int j = 0; j < 4; j++)
//             {
//                 Console.Write($"Enter grade {j + 1}: ");
//                 grades[i, j] = int.Parse(Console.ReadLine());
//                 sum += grades[i, j];
//             }

//             double avg = sum / 4.0;
//             total += avg;

//             Console.WriteLine("Average = " + avg);
//         }

//         Console.WriteLine("Class Average = " + total / 3);
//     }
// }
 #endregion
 #region Q3
//  Part 3 — Functions (Calculator)

// using System;

// class Program
// {
//     static double Add(double a, double b) => a + b;

//     static double Subtract(double a, double b) => a - b;

//     static double Multiply(double a, double b) => a * b;

//     static double Divide(double a, double b)
//     {
//         if (b == 0)
//         {
//             Console.WriteLine("Cannot divide by zero");
//             return 0;
//         }

//         return a / b;
//     }

//     static void Main()
//     {
//         Console.Write("Enter first number: ");
//         double a = double.Parse(Console.ReadLine());

//         Console.Write("Enter second number: ");
//         double b = double.Parse(Console.ReadLine());

//         Console.Write("Operation (+ - * /): ");
//         char op = char.Parse(Console.ReadLine());

//         double result = 0;

//         switch (op)
//         {
//             case '+': result = Add(a, b); break;
//             case '-': result = Subtract(a, b); break;
//             case '*': result = Multiply(a, b); break;
//             case '/': result = Divide(a, b); break;
//         }

//         Console.WriteLine("Result = " + result);
//     }
// }
// Part 3 — Q2 Circle

// using System;

// class Program
// {
//     static void CalculateCircle(double r, out double area, out double circumference)
//     {
//         area = Math.PI * r * r;
//         circumference = 2 * Math.PI * r;
//     }

//     static void Main()
//     {
//         Console.Write("Enter radius: ");
//         double r = double.Parse(Console.ReadLine());

//         double area, circumference;

//         CalculateCircle(r, out area, out circumference);

//         Console.WriteLine("Area = " + area);
//         Console.WriteLine("Circumference = " + circumference);
//     }
// }
// (Student Grade Manager)

// using System;

// enum Grade { A, B, C, D, F }

// class Program
// {
//     static Grade GetGrade(int score)
//     {
//         if (score >= 90) return Grade.A;
//         else if (score >= 80) return Grade.B;
//         else if (score >= 70) return Grade.C;
//         else if (score >= 60) return Grade.D;
//         else return Grade.F;
//     }

//     static double CalculateAverage(int[] scores)
//     {
//         int sum = 0;

//         foreach (int s in scores)
//             sum += s;

//         return (double)sum / scores.Length;
//     }

//     static void GetMinMax(int[] scores, out int min, out int max)
//     {
//         min = scores[0];
//         max = scores[0];

//         foreach (int s in scores)
//         {
//             if (s < min) min = s;
//             if (s > max) max = s;
//         }
//     }

//     static void Main()
//     {
//         int[] scores = new int[5];

//         for (int i = 0; i < 5; i++)
//         {
//             Console.Write($"Enter score for Student {i + 1}: ");
//             scores[i] = int.Parse(Console.ReadLine());
//         }

//         Console.WriteLine("\n--- Report ---");

//         for (int i = 0; i < 5; i++)
//         {
//             Grade g = GetGrade(scores[i]);
//             Console.WriteLine($"Student {i + 1}: {scores[i]} -> Grade: {g}");
//         }

//         double avg = CalculateAverage(scores);

//         GetMinMax(scores, out int min, out int max);

//         Console.WriteLine("Average: " + avg);
//         Console.WriteLine("Highest Score: " + max);
//         Console.WriteLine("Lowest Score: " + min);
//     }
// }
