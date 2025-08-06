namespace Day04_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem 1
            //Initialize using new int[size]
            //int[] Arr1 = new int[3];
            //Arr1[0] = 1;
            //Arr1[1] = 2;
            //Arr1[2] = 3;

            //Initialize using initializer list
            //int[] Arr2 = new int[] { 1, 2, 3 };

            //Initialize using array syntax sugar
            //int[] Arr3 = { 1, 2, 3 };

            //foreach (int item in Arr1)
            //{
            //    Console.WriteLine(item);
            //}

            //Demonstrate IndexOutOfRangeException

            //try
            //{
            //    Console.WriteLine("Trying to access invalid index");
            //    Console.WriteLine(Arr1[3]);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            #endregion

            #region Problem 2
            //Console.WriteLine("=== Shallow Copy Example ===");
            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = arr1;  // Shallow copy (same reference)

            //// Modify arr2
            //arr2[0] = 99;

            //Console.WriteLine("arr1: " + string.Join(", ", arr1));
            //Console.WriteLine("arr2: " + string.Join(", ", arr2));
            //// Both arrays will show the modified value, because they point to the same memory

            //Console.WriteLine("\n=== Deep Copy using Clone() ===");
            //int[] arr3 = { 4, 5, 6 };
            //int[] arr4 = (int[])arr3.Clone();  // Deep copy

            //// Modify arr4
            //arr4[0] = 77;

            //Console.WriteLine("arr3: " + string.Join(", ", arr3));
            //Console.WriteLine("arr4: " + string.Join(", ", arr4));
            //// Only arr4 is affected, arr3 stays the same

            #endregion

            #region Problem 3
            //string[,] Student = new string[3, 3];
            //for (int i = 0; i < Student.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter grades for Student {i + 1}:");


            //    for (int j = 0; j < Student.GetLength(1); j++)
            //    {
            //        Console.Write($"Enter Subject {j + 1}:");
            //        Student[i, j] = Console.ReadLine();
            //    }
            //    Console.WriteLine("===========");
            //}
            //Console.WriteLine("============Result===============");
            //for (int i = 0; i < Student.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Student {i + 1}:");


            //    for (int j = 0; j < Student.GetLength(1); j++)
            //    {
            //        Console.Write($"Subject {j + 1}:{Student[i, j]} ");
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            #region Problem 4
            //int[] numbers = { 5, 3, 8, 1, 4 };

            //Console.WriteLine("Original array:");
            //Console.WriteLine("[" + string.Join(", ", numbers) + "]");

            //// 1. Sort
            //Array.Sort(numbers);
            //Console.WriteLine("After Sort:");
            //Console.WriteLine("[" + string.Join(", ", numbers) + "]");

            //// 2. Reverse
            //Array.Reverse(numbers);
            //Console.WriteLine("After Reverse:");
            //Console.WriteLine("[" + string.Join(", ", numbers) + "]");

            //// 3. IndexOf
            //int index = Array.IndexOf(numbers, 4);
            //Console.WriteLine("Index of 4 = " + index);

            //// 4. Copy
            //int[] copied = new int[3];
            //Array.Copy(numbers, copied, 3);
            //Console.WriteLine("Copied array:");
            //Console.WriteLine("[" + string.Join(", ", copied) + "]");

            //// 5. Clear
            //Array.Clear(numbers, 1, 2);
            //Console.WriteLine("After Clear:");
            //Console.WriteLine("[" + string.Join(", ", numbers) + "]"); 
            #endregion

            #region Problem 5
            //int[] numbers = { 5, 3, 8, 1, 4 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //Console.WriteLine("===========================");
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("===========================");
            //int index = numbers.Length - 1;
            //while (index >= 0)
            //{
            //    Console.Write(numbers[index] + " ");
            //    index--;
            //} 
            #endregion

            #region problem 6
            //bool num;
            //int result;
            //do
            //{
            //    Console.Write("Enter positive odd number: ");
            //    num = int.TryParse(Console.ReadLine(), out result);
            //} while (!num || result % 2 == 0 || result < 0);
            //Console.WriteLine($"positive odd number is :{result}"); 
            #endregion

            #region problem 7
            //int[,] matrix = {
            //    { 1, 2, 3 },
            //    { 4, 5, 6 },
            //    { 5, 6, 7 }, };
            //Console.WriteLine("Matrix elements:");
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write($"{matrix[i, j]}  ");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            #region Problem 8
            //Console.Write("enter a month number:");
            //int.TryParse(Console.ReadLine(), out int monthNumber);
            ////Console.WriteLine("\n--- Using if-else ---");
            //if (monthNumber == 1)
            //    Console.WriteLine("January");
            //else if (monthNumber == 2)
            //    Console.WriteLine("February");
            //else if (monthNumber == 3)
            //    Console.WriteLine("March");
            //else if (monthNumber == 4)
            //    Console.WriteLine("April");
            //else if (monthNumber == 5)
            //    Console.WriteLine("May");
            //else if (monthNumber == 6)
            //    Console.WriteLine("June");
            //else if (monthNumber == 7)
            //    Console.WriteLine("July");
            //else if (monthNumber == 8)
            //    Console.WriteLine("August");
            //else if (monthNumber == 9)
            //    Console.WriteLine("September");
            //else if (monthNumber == 10)
            //    Console.WriteLine("October");
            //else if (monthNumber == 11)
            //    Console.WriteLine("November");
            //else if (monthNumber == 12)
            //    Console.WriteLine("December");
            //else
            //    Console.WriteLine("Invalid month number!");

            ////----------------------------------------------------------
            ////Console.WriteLine("\n--- Using switch ---");
            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("January"); break;
            //    case 2:
            //        Console.WriteLine("February"); break;
            //    case 3:
            //        Console.WriteLine("March"); break;
            //    case 4:
            //        Console.WriteLine("April"); break;
            //    case 5:
            //        Console.WriteLine("May"); break;
            //    case 6:
            //        Console.WriteLine("June"); break;
            //    case 7:
            //        Console.WriteLine("July"); break;
            //    case 8:
            //        Console.WriteLine("August"); break;
            //    case 9:
            //        Console.WriteLine("September"); break;
            //    case 10:
            //        Console.WriteLine("October"); break;
            //    case 11:
            //        Console.WriteLine("November"); break;
            //    case 12:
            //        Console.WriteLine("December"); break;
            //    default:
            //        Console.WriteLine("Invalid month number!"); break;
            //}

            #endregion

            #region Problem 9
            //int[] numbers = { 5, 3, 8, 4, 9, 1, 2, 7 };

            //Console.WriteLine("Original array:");

            //Console.WriteLine("[" + string.Join(", ", numbers) + "]");
            //Array.Sort(numbers);
            //Console.WriteLine("[" + string.Join(", ", numbers) + "]");
            //int Index = Array.IndexOf(numbers, 9);
            //Console.WriteLine("[" + string.Join(", ", numbers) + "]");
            //Console.WriteLine(Index);
            //int LastIndex = Array.LastIndexOf(numbers, 9);
            //Console.WriteLine("[" + string.Join(", ", numbers) + "]");
            //Console.WriteLine(LastIndex); 
            #endregion

            #region Problem 10
            //int[] numbers = { 5, 10, 15, 20, 25 };

            //// Sum using for loop
            //int sumFor = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sumFor += numbers[i];
            //}
            //Console.WriteLine("Sum using for loop: " + sumFor);

            //// Sum using foreach loop
            //int sumForeach = 0;
            //foreach (int num in numbers)
            //{
            //    sumForeach += num;
            //}
            //Console.WriteLine("Sum using foreach loop: " + sumForeach); 
            #endregion

            char[] arr = new char[3];
            arr[0] = default;
            Console.WriteLine(arr[0]);
        }
    }
}
