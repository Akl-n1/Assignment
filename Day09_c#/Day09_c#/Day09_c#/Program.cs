namespace Day09_c_
{


    internal class Program
    {
        static void Swap(ref Rectangle r1, ref Rectangle r2)
        {
            Rectangle temp = r1;
            r1 = r2;
            r2 = temp;
        }
        static void SwapItem(ref Rectangle r1, ref Rectangle r2)
        {
            Rectangle temp = new Rectangle(r1.Width, r1.Length);
            r1 = new Rectangle(r2.Width, r2.Length);
            r2 = temp;
        }

        static void Main(string[] args)
        {
            #region Problem 1
            //Child obj = new Child();
            //obj.DisplaySalary(); 
            #endregion

            #region Problem 2
            //int length = 10;
            //int width = 5;
            //int perimeter = Utility.CalculatePerimeter(length, width);
            //Console.WriteLine("Perimeter of Rectangle = " + perimeter); 
            #endregion

            #region Problem 3 
            //Complex C1 = new Complex(2, 3);
            //Complex C2 = new Complex(4, 5);
            //Complex result = C1 * C2;
            //Console.WriteLine($"Result: {result}"); 
            #endregion

            #region Problem 4
            //double D1 = Utility2.ConvertTemperature(100, "Celsius");
            //double D2 = Utility2.ConvertTemperature(1, "fahrenheit");
            //Console.WriteLine($"D1: {D1} Celsius, D2: {D2} fahrenheit");

            #endregion

            #region Problem 5
            //    Employee[] employees = new Employee[]
            //{
            //    new Employee { Id = 1, Name = "Ali" },
            //    new Employee { Id = 2, Name = "Sara" },
            //    new Employee { Id = 3, Name = "Mahmoud" }
            //};
            //    int number = Helper<Employee>.SearchArray(employees, new Employee { Id = 2, Name = "Ssaara" });
            //    Console.WriteLine(number);

            #endregion

            #region Problem 6
            //int maxInt = Helper2.Max(10, 20);
            //Console.WriteLine("Max Int: " + maxInt);

            //// Doubles
            //double maxDouble = Helper2.Max(15.5, 9.3);
            //Console.WriteLine("Max Double: " + maxDouble);

            //// Strings (يقارن أبجدياً)
            //string maxString = Helper2.Max("Apple", "Banana");
            //Console.WriteLine("Max String: " + maxString);

            //// Employees
            //Employee emp1 = new Employee { Id = 1, Name = "Ali", Salary = 5000 };
            //Employee emp2 = new Employee { Id = 2, Name = "Sara", Salary = 7000 };

            //Employee maxEmp = Helper2.Max(emp1, emp2);
            //Console.WriteLine("Max Employee: " + maxEmp); 
            #endregion

            #region Problem 7
            //int[] numbers = { 1, 2, 3, 2, 4, 2, 5 };
            //Helper2.ReplaceArray(numbers, 3, 6);
            //Console.WriteLine("After (Int): " + string.Join(", ", numbers));

            //string[] names = { "Ali", "Sara", "Ali", "Omar" };
            //Helper2.ReplaceArray(names, "Ali", "Mahmoud");
            //Console.WriteLine("After (string): " + string.Join(", ", names));

            //Employee[] employees = new Employee[]
            //{
            //    new Employee { Id = 1, Name = "Ali" },
            //    new Employee { Id = 2, Name = "Sara" },
            //    new Employee { Id = 3, Name = "Mahmoud" }
            //};
            //Helper2.ReplaceArray(employees,
            //    new Employee { Id = 1, Name = "Ali" },
            //    new Employee { Id = 1, Name = "Asmaa" });

            //foreach (var item in employees)
            //{
            //    Console.WriteLine($"After (Employee): {item}");

            //} 
            #endregion

            #region Problem 8
            //Rectangle rect1 = new Rectangle(10, 5);
            //Rectangle rect2 = new Rectangle(3, 8);
            //SwapItem(ref rect1, ref rect2);
            //Console.WriteLine("\nAfter swap:");
            //Console.WriteLine($"rect1: {rect1}");
            //Console.WriteLine($"rect2: {rect2}"); 
            #endregion

            #region Problem 9
            //    Department hr = new Department(1, "HR");
            //    Department it = new Department(2, "IT");
            //    Employee2[] employees = new Employee2[]
            //{
            //    new Employee2(101, "Ahmed", hr),
            //    new Employee2(102, "Sara", it),
            //    new Employee2(103, "Mahmoud", hr),
            //};
            //    var x = SearchArrayS.SearchArray(employees, 1);
            //    foreach (var item in x)
            //    {
            //        Console.WriteLine(item);
            //    }
            //} 
            #endregion

            #region Problem 10
            //// Struct instances
            //CircleStruct C1 = new CircleStruct(5, "red");
            //CircleStruct C2 = new CircleStruct(5, "red");
            //Console.WriteLine(C1 == C2);
            //Console.WriteLine(C2.Equals(C1));

            //// Class instances
            //CircleClass cc1 = new CircleClass(5, "Red");
            //CircleClass cc2 = new CircleClass(5, "Red");

            //Console.WriteLine("\nClass comparison:");
            //Console.WriteLine($"cc1 == cc2: {cc1 == cc2}");          // False, compares references by default
            //Console.WriteLine($"cc1.Equals(cc2): {cc1.Equals(cc2)}"); // False, compares references unless overridden

            #endregion

            #region Problem 11

            //int[] arr = { 1, 2, 3, 4, 5 };
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //var ReverseArray = GenericClass.ReverseArray(arr);
            //foreach (var item in ReverseArray)
            //{
            //    Console.Write(item + " ");
            //} 

            //===========================================

            //string[] words = { "A", "B", "C" };
            //var reversedWords = GenericClass.ReverseArray(words);
            //foreach (var item in reversedWords)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion

            #region Problem 12
            //var stack = new MyStack<int>();
            //stack.Push(10);
            //stack.Push(20);
            //Console.WriteLine(stack.Peek()); // 20
            //Console.WriteLine(stack.Pop());  // 20
            //Console.WriteLine(stack.Count); 
            #endregion

            #region Problem 13
            //int[] arr = { 1, 2, 3, 4 };
            //GenericClass.Swapping(arr, 0, 2); // arr = {3,2,1,4}
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");

            //} 
            #endregion

            #region Problem 14

            //int[] numbers = { 5, 10, 3, 8, 17, 35, 2 };
            //Console.WriteLine(Max<int>.FindMax(numbers)); // 10

            //string[] names = { "Ali", "Zain", "Omar" };
            //Console.WriteLine(Max<string>.FindMax(names)); 
            #endregion

        }
    }
}
