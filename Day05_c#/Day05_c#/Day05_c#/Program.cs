namespace Day05_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem 1 
            //try
            //{
            //    Console.Write("Enter the first integer: ");
            //    int numerator = int.Parse(Console.ReadLine()!);

            //    Console.Write("Enter the second integer: ");
            //    int denominator = int.Parse(Console.ReadLine()!);

            //    int result = numerator / denominator;
            //    Console.WriteLine($"Result: {result}");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Error: Cannot divide by zero.");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Error: Please enter valid integers.");
            //}
            //finally
            //{
            //    Console.WriteLine("Operation complete.");
            //} 
            #endregion

            #region problem 2
            //int? nullableInt = 15;

            //int valueOrDefault = nullableInt ?? 100;
            //Console.WriteLine($"Value or default: {valueOrDefault}");

            //if (nullableInt.HasValue)
            //{
            //    Console.WriteLine($"Has value: {nullableInt.Value}");
            //} 
            #endregion

            #region Problem 3
            //int[,] matrix = new int[3, 3];

            //Console.WriteLine("Enter values for a 3x3 matrix:");

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write($"Enter value for element [{i},{j}]: ");
            //        while (!int.TryParse(Console.ReadLine(), out matrix[i, j]))
            //        {
            //            Console.Write("Invalid input. Please enter an integer: ");
            //        }
            //    }
            //}
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    int? sum = 0;
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        sum += matrix[i, j];
            //    }
            //    Console.WriteLine($"Sum of row {i + 1}: {sum}");
            //}
            //Console.WriteLine("==================================");
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    int? sum = 0;
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        sum += matrix[j, i];
            //    }
            //    Console.WriteLine($"Sum of Col {i + 1}: {sum}");
            //} 
            #endregion

            #region Problem 4 
            //int[] arr = new int[5] { 10, 20, 30, 40, 50 };

            //try
            //{
            //    Console.WriteLine(arr[10]);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("Error: Attempted to access an index that is out of bounds.");
            //    Console.WriteLine("Exception message: " + ex.Message);
            //} 
            #endregion

            #region Problem 5
            //int[][] jaggedArray = new int[3][];

            //jaggedArray[0] = new int[2];
            //jaggedArray[1] = new int[4];
            //jaggedArray[2] = new int[3];

            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    Console.WriteLine($"Enter {jaggedArray[i].Length} values for row {i + 1}:");
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        while (!int.TryParse(Console.ReadLine(), out jaggedArray[i][j]))
            //        {
            //            Console.Write("Invalid input, please enter an integer: ");
            //        }
            //    }
            //}

            //Console.WriteLine("\nValues in jagged array:");
            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    Console.Write($"Row {i}: ");
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.Write(jaggedArray[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            #region Problem 6
            //string? UserName;
            //Console.Write("Enter Your Name:");
            //string Name = Console.ReadLine()!;
            //UserName = String.IsNullOrWhiteSpace(Name) ? null : Name;
            //Console.WriteLine($"Hello, {UserName ?? "Guest"}"); 
            #endregion

            #region Problem 7
            //int number = 42;
            //object boxedNumber = number; // Boxing
            //Console.WriteLine($"Boxed value: {boxedNumber}");

            //int unboxedNumber = (int)boxedNumber; // Unboxing
            //Console.WriteLine($"Unboxed value: {unboxedNumber}");
            //try
            //{
            //    double WrongUnbox = (double)boxedNumber;
            //    Console.WriteLine(WrongUnbox);
            //}
            //catch (InvalidCastException ex)
            //{
            //    Console.WriteLine(ex.Message);

            //}

            #endregion

            #region Problem 10 
            //double s, p;
            //SumAndMultiply(10, 20, out s, out p);
            //Console.WriteLine(s);
            //Console.WriteLine(p); 
            #endregion

            #region Problem 11
            //PrintMultipleTimes("Mahmoud"); 
            //PrintMultipleTimes("Mahmoud", 3);

            //Console.WriteLine("-----");

            //PrintMultipleTimes(times: 2, Text: "Named Parameters Example");
            #endregion

            #region Problem 12
            //int[]? arr = default;

            //for (int i = 0; i < arr?.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //arr = new int[] { 1, 2, 3 };
            //for (int i = 0; i < (arr?.Length ?? 0); i++)
            //{
            //    Console.WriteLine(arr![i]);
            //} 
            #endregion

            #region Problem 13
            //Console.Write("Enter a day of the week: ");
            //string? input = Console.ReadLine()?.Trim().ToLower();
            //int day = input switch
            //{
            //    "monday" => 1,
            //    "tuesday" => 2,
            //    "wednesday" => 3,
            //    "thursday" => 4,
            //    "friday" => 5,
            //    "saturday" => 6,
            //    "sunday" => 7,
            //    _ => 0
            //};
            //if (day == 0)
            //    Console.WriteLine("Invalid day entered.");
            //else
            //    Console.WriteLine($"{input} corresponds to day number {day}.");
            #endregion

            #region Problem 14
            //int[] arr = { 1, 2, 3, 4, 5 };
            //int result1 = SumArray(arr);
            //Console.WriteLine("Sum of array: " + result1);

            //int result2 = SumArray(10, 20, 30);
            //Console.WriteLine("Sum of individual values: " + result2); 
            #endregion

            #region Problem 15 
            //bool x;
            //int number;
            //do
            //{
            //    Console.WriteLine("insert a positive integer");
            //    x = int.TryParse(Console.ReadLine(), out number);
            //} while (!x || number <= 0);
            //for (int i = 1; i <= number; i++)
            //{
            //    if (i < number)
            //        Console.Write($"{i},");
            //    else
            //        Console.Write(i);
            //} 
            #endregion

            #region Problem 16 
            //Console.Write("Enter a positive integer: ");
            //if (int.TryParse(Console.ReadLine(), out int num) && num > 0)
            //{
            //    for (int i = 1; i < 12; i++)
            //    {
            //        Console.WriteLine($"{num} * {i} = {num * i}");
            //    }
            //    Console.WriteLine();
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input! Please enter a positive integer.");
            //} 
            #endregion

            #region Problem 17 
            //Console.Write("Enter a positive Even integer: ");
            //if (int.TryParse(Console.ReadLine(), out int num) && num > 0)
            //{
            //    bool first = false;
            //    for (int i = 2; i <= num; i += 2)
            //    {
            //        if (first)
            //            Console.Write(", ");
            //        Console.Write($"{i}");
            //        first = true;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input! Please enter a positive integer.");
            //}

            #endregion

            #region Problem 18
            //Console.Write("Enter the base number: ");
            //int baseNum = int.Parse(Console.ReadLine()!);

            //Console.Write("Enter the exponent: ");
            //int exponent = int.Parse(Console.ReadLine()!);
            //int result = 1;
            //for (int i = 0; i < exponent; i++)
            //{
            //    result *= baseNum;
            //}
            //Console.WriteLine($"{baseNum} raised to the power of {exponent} is {result}");
            #endregion

            #region Problem 19
            //Console.Write("Enter String :");
            //String? input = Console.ReadLine() ?? "s";
            //char[] X = input.ToCharArray();

            //Array.Reverse(X);
            //Console.WriteLine(String.Join(",", X)); 
            #endregion

            #region Problem 20
            //Console.Write("Enter an integer: ");
            //string input = Console.ReadLine() ?? "";

            //if (int.TryParse(input, out int number))
            //{
            //    char[] digits = input.ToCharArray();
            //    Array.Reverse(digits);
            //    string reversed = new string(digits);

            //    Console.WriteLine("Reversed number: " + reversed);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input! Please enter a valid integer.");
            //} 
            #endregion

            #region Problem 21 
            //Console.Write("Enter the size of the array: ");
            //if (!int.TryParse(Console.ReadLine(), out int Size) || Size <= 0)
            //{
            //    Console.WriteLine("Invalid size!");
            //    return;
            //}
            //Console.WriteLine($"Enter {Size} numbers separated by commas:");
            //string? input = Console.ReadLine();

            //if (input == null)
            //{
            //    Console.WriteLine("No input!");
            //    return;
            //}
            //string[] parts = input.Split(',');
            //if (parts.Length != Size)
            //{
            //    Console.WriteLine("The number of elements does not match the size!");
            //    return;
            //}

            //int[] arr = new int[Size];
            //for (int i = 0; i < arr?.Length; i++)
            //{
            //    if (!int.TryParse(parts[i].Trim(), out arr[i]))
            //    {
            //        Console.WriteLine($"Invalid number at position {i + 1}.");
            //        return;
            //    }
            //}
            //int maxDistance = -1, numberWithMaxDistance = 0;
            //for (int i = 0; i < Size; i++)
            //    for (int j = Size - 1; j > i; j--)
            //        if (arr[i] == arr[j])
            //        {
            //            int dist = j - i - 1;
            //            if (dist > maxDistance)
            //            {
            //                maxDistance = dist;
            //                numberWithMaxDistance = arr[i];
            //            }
            //            break;
            //        }
            //if (maxDistance == -1)
            //    Console.WriteLine("No identical elements found.");
            //else
            //    Console.WriteLine($"Number {numberWithMaxDistance} has the longest distance of {maxDistance} cells between identical elements.");

            #endregion

            #region Problem 22
            //Console.Write("Enter String :");
            //string? name = Console.ReadLine() ?? "";
            //string[] part = name.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //Array.Reverse(part);
            //Console.Write(String.Join(",", part));
            #endregion


        }


        #region Problem 9
        //static void SumAndMultiply(int num1, int num2, out double sum, out double product)
        //{
        //    sum = num1 + num2;
        //    product = num1 * num2;
        //} 
        #endregion

        #region Problem 10
        //static void PrintMultipleTimes(string Text, int times = 5)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        Console.WriteLine(Text);
        //    }
        //}
        #endregion

        #region Problem 13 
        //static int SumArray(params int[] number)
        //{
        //    int sum = 0;
        //    foreach (int num in number)
        //    {
        //        sum += num;
        //    }
        //    return sum;
        //} 
        #endregion


    }
}
