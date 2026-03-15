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
