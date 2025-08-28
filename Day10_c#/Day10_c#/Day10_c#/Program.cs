



namespace Day10_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem 1

            //     Employee[] employees =
            //{
            //               new Employee { Id = 1, Name = "Ali", Salary = 5000 },
            //               new Employee { Id = 2, Name = "Mona", Salary = 3000 },
            //               new Employee { Id = 3, Name = "Omar", Salary = 7000 },
            //               new Employee { Id = 4, Name = "Sara", Salary = 4000 }
            //           };
            //     SortingAlgorithm1<Employee>.Sort(employees);
            //     foreach (var employee in employees)
            //     {
            //         Console.WriteLine(employee);
            //     }

            #endregion

            #region Problem 2
            //int[] numbers = { 6, 3, 5, 2, 7 };

            //SortingAlgorithm2.Sort(numbers, (a, b) => b.CompareTo(a));
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //} 
            #endregion

            #region Problem 3
            //string[] numbers = { "Ali", "Mahmoud", "Akl", "Sara" };

            //SortingAlgorithm2.Sort(numbers, (a, b) => b.Length.CompareTo(a.Length));

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);

            //} 
            #endregion

            #region Problem 4
            //    Manager[] managers =
            //  {
            //    new Manager { Id = 1, Name = "Ahmed", Salary = 9000 },
            //    new Manager { Id = 2, Name = "Mona", Salary = 12000 },
            //    new Manager { Id = 3, Name = "Omar", Salary = 8000 },
            //    new Manager { Id = 4, Name = "Omar", Salary = 7000 },
            //    new Manager { Id = 5, Name = "Omar", Salary = 10000 }
            //};

            //    Console.WriteLine("Before Sorting:");
            //    foreach (var m in managers) Console.WriteLine(m);

            //    SortingAlgorithm4.Sort(managers, (a, b) => b.CompareTo(a));

            //    Console.WriteLine("\nAfter Sorting by Salary (Ascending):");
            //    foreach (var m in managers) Console.WriteLine(m);

            #endregion

            #region Problem 5
            // Employee[] employees =
            //  {
            // new Employee { Id = 1, Name = "Ahmed", Salary = 9000 },
            // new Employee { Id = 2, Name = "Mona", Salary = 12000 },
            // new Employee { Id = 3, Name = "Omar", Salary = 8000 },
            // new Employee { Id = 4, Name = "Ali", Salary = 7000 },
            // new Employee { Id = 5, Name = "Mostafa", Salary = 10000 }
            // };

            // Func<Employee, Employee, bool> compareByNameLength =
            //(a, b) => a.Name.Length > b.Name.Length;

            // SortingAlgorithm5.Sort(employees, compareByNameLength);

            // foreach (Employee employee in employees)
            // {
            //     Console.WriteLine(employee);
            // } 
            #endregion

            #region Problem 6
            //int[] numbers = { 5, 2, 9, 1, 6 };

            //SortingAlgorithm5.Sort(numbers, (a, b) => a < b);
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Problem 7
            //int[] numbers = { 5, 2, 8, 1, 9, 7 };

            //Console.WriteLine("Before Swap:");
            //Console.WriteLine(string.Join(", ", numbers));

            //SortingAlgorithm7.Swap(ref numbers[0], ref numbers[4]);

            //Console.WriteLine("\nAfter Swapping first and last elements:");
            //Console.WriteLine(string.Join(", ", numbers));

            //SortingAlgorithm7.Sort(numbers);

            //Console.WriteLine("\nAfter Sorting:");
            //Console.WriteLine(string.Join(", ", numbers)); 
            #endregion

            #region Problem 8
            //    Employee[] employees =
            //{
            //    new Employee { Id = 1, Name = "Ahmed", Salary = 9000 },
            //    new Employee { Id = 2, Name = "Mona", Salary = 12000 },
            //    new Employee { Id = 3, Name = "Omar", Salary = 12000 },
            //    new Employee { Id = 4, Name = "Ali", Salary = 7000 },
            //    new Employee { Id = 5, Name = "Mostafa", Salary = 9000 }
            //};

            //    Console.WriteLine("Before Sorting:");
            //    foreach (var e in employees)
            //        Console.WriteLine(e);

            //    SortingAlgorithm8.Sort(employees);

            //    Console.WriteLine("\nAfter Sorting (by Salary, then Name):");
            //    foreach (var e in employees)
            //        Console.WriteLine(e); 
            #endregion

            #region Problem 9

            //    Employee[] employees =
            //{
            //    new Employee { Id = 1, Name = "Ahmed", Salary = 9000 },
            //    new Employee { Id = 2, Name = "Mona", Salary = 12000 },
            //    new Employee { Id = 3, Name = "Omar", Salary = 8000 },
            //    new Employee { Id = 4, Name = "Ali", Salary = 7000 },
            //    new Employee { Id = 5, Name = "Mostafa", Salary = 10000 }
            //};

            //    Console.WriteLine("Original Employees:");
            //    foreach (var emp in employees)
            //        Console.WriteLine(emp);

            //    Console.WriteLine("\nSorted Employees (cloned):");
            //    Employee[] sorted = SortingAlgorithm<Employee>.Sort(employees);

            //    foreach (var emp in sorted)
            //        Console.WriteLine(emp);

            //    Console.WriteLine("\nAfter Sorting, Original still unchanged:");
            //    foreach (var emp in employees)
            //        Console.WriteLine(emp);


            #endregion

            #region Problem 10
            //List<string> names = new List<string> { "mahmoud", "ahmed", "sara" };

            //var upperNames = Transformation.ApplyTransformation(names, s => s.ToUpper());
            //Console.WriteLine("Uppercase: " + string.Join(", ", upperNames));


            #endregion

            #region problem 11
            //int sum = operations.Calculate(10, 20, (a, b) => a + b);
            //Console.WriteLine(sum);

            //int add = operations.Calculate(10, 20, (a, b) => a * b);
            //Console.WriteLine(add);

            //int divid = operations.Calculate(10, 20, (a, b) => a / b);
            //Console.WriteLine(divid); 
            #endregion

            #region Problem 12
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            //var num = TransformList.TransformListMethos(numbers, e => e.ToString());
            //num.ForEach(Console.WriteLine);

            //Console.WriteLine("===============================================");

            //List<string> words = new List<string> { "apple", "banana", "cherry" };
            //List<int> lengths = TransformList.TransformListMethos(words, w => w.Length);
            //Console.WriteLine("\nWords to Lengths:");
            //lengths.ForEach(Console.WriteLine); 
            #endregion

            #region Problem 13
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            //var x = TransformList.Squre(numbers, e => Math.Pow(e, 2));
            //x.ForEach(Console.WriteLine); 
            #endregion

            #region Problemn 14
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var result = TransformList.Filter(numbers, e => e % 2 == 0);
            //result.ForEach(e => Console.WriteLine(e)); 
            #endregion

            #region Problem 15
            //    List<string> names = new List<string>
            //{
            //    "Alice", "Ahmed", "Bob", "Amira", "Charlie", "Anna", "David"
            //};

            //    var startWithA = TransformList.FilterStrings(names, s => s.StartsWith("A"));
            //    Console.WriteLine("Strings starting with A:");
            //    startWithA.ForEach(Console.WriteLine); 
            #endregion

            #region Problem 16

            //int x = 10, y = 5;

            //int sum = TransformList.PerformOperation(x, y, Add);
            //Console.WriteLine($"Addition: {x} + {y} = {sum}"); 
            #endregion

            #region Problem 17
            //double x = 10.0, y = 2.0;

            //double division = TransformList.PerformOperation(x, y, (a, b) => b != 0 ? a / b : double.NaN);
            //Console.WriteLine($"{x} / {y} = {division}");

            //double power = TransformList.PerformOperation(x, y, (a, b) => Math.Pow(a, b));
            //Console.WriteLine($"{x} ^ {y} = {power}"); 
            #endregion

        }

        private static int Add(int arg1, int arg2)
        {
            return arg1 + arg2;
        }
    }
}
