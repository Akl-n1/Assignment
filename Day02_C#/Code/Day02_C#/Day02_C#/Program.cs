namespace Day02_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem1
            // Declare and initialize variable x with value 10
            //int x = 10;

            // Declare and initialize variable y with value 20
            //int y = 20;

            /*
              Add the values of x and y,
              and store the result in the variable sum
            */
            //int sum = x + y;
            // Display the value of sum in the console output
            //Console.WriteLine(sum);

            #endregion

            #region Q2
            //Comment Selected Code
            //    Ctrl + K, then Ctrl +C

            //Uncomment Selected Code
            //    Ctrl + K, then Ctrl +U 
            #endregion

            #region Identify and fix the errors in this code snippet
            //int x = "10";                    //Type mismatch
            //console.WriteLine(x + y);       //Undefined variable y

            //==============Fixed==========
            //int x = 10;                 // Correct: assigning integer value
            //int y = 5;                  // Declare and initialize variable y
            //Console.WriteLine(x + y);  // Correct casing and valid variables

            #endregion

            #region Declare variables using proper naming conventions to store
            //Using camelCase
            //string fullName = "Mahmoud Akl";
            //int age = 22;
            //decimal monthlySalary = 5000.75m;
            //bool isStudent = true;
            ////--------
            //Console.WriteLine("Name: " + fullName);
            //Console.WriteLine("Age: " + age);
            //Console.WriteLine("Monthly Salary: $" + monthlySalary);
            //Console.WriteLine("Student: " + isStudent); 
            #endregion

            #region  changing the value of a reference type affects all references pointing to that object.
            //Person person1 = new Person();
            //person1.Name = "Ali";

            //Person person2 = person1;

            //person2.Name = "Dad";

            //Console.WriteLine("person1.Name: " + person1.Name);  // Outputs: Dad
            //Console.WriteLine("person2.Name: " + person2.Name);  // Outputs: Dad 
            #endregion

            #region Create a program that calculates the following using variables x = 15 and y = 4
            //int x = 15, y = 4;
            //Console.WriteLine($"Sum: {x + y}");
            //Console.WriteLine($"Difference: {x - y}");
            //Console.WriteLine($"Product:{x * y} ");
            //Console.WriteLine($"Division Result: {(double)x / y}");
            //Console.WriteLine($"Remainder: {x % y}"); 
            #endregion

            #region Write a program that checks if a given number is both: Greater than 10 - Even. 
            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //string Result = (number > 10 && number % 2 == 0) ?
            //                "The number is greater than 10 and even."
            //                : "The number does NOT meet both conditions.";
            //Console.WriteLine(Result); 
            #endregion

            #region Implement a program that takes a double input from the user and casts it to an int Use both implicit and explicit

            //Console.Write("Enter Your number");
            //double number = double.Parse(Console.ReadLine());

            //int explicitCast = (int)number;
            //double implicitCast = explicitCast;
            //Console.WriteLine("Original double value: " + number);
            //Console.WriteLine("After explicit cast to int: " + explicitCast);
            //Console.WriteLine("After implicit cast back to double: " + implicitCast); 
            #endregion

            #region Prompts the user for their age as a string. 
            //Console.WriteLine("Enter Your Age");
            //int Age = int.Parse(Console.ReadLine());

            //if (Age > 0)
            //    Console.WriteLine($"Valid age entered: {Age}");
            //else
            //    Console.WriteLine("Age must be greater than 0."); 
            #endregion

            #region Write a program that demonstrates the difference between prefix and postfix increment operators using a variable x.

            //int x = 5;
            //// Postfix increment
            //Console.WriteLine("x++ = " + (x++)); //(5) uses x, then increments
            //Console.WriteLine("Value after x++: " + x);//6

            //Console.WriteLine("++x = " + (++x)); //(7) increments, then uses x
            //Console.WriteLine("Value after ++x: " + x);//7
            #endregion

        }
    }
}
