namespace Day03_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem 1
            //Console.Write("Enter a number: ");
            //string userInput = Console.ReadLine();

            //try
            //{
            //    int resultParse = int.Parse(userInput);
            //    Console.WriteLine($"int.Parse result: {resultParse}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"int.Parse threw an exception: {ex.Message}");
            //}
            ////-----------------------------------------
            //try
            //{
            //    int resultConvert = Convert.ToInt32(userInput);
            //    Console.WriteLine($"Convert.ToInt32 result: {resultConvert}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Convert.ToInt32 threw an exception: {ex.Message}");
            //} 
            #endregion

            #region Problem 2
            //Console.Write("Enter Your Number: ");
            //bool result = int.TryParse(Console.ReadLine(), out int output);
            //if (result == true)
            //    Console.WriteLine($"number Is {output}");
            //if (result == false)
            //    Console.WriteLine("number Is InValied"); 
            #endregion

            #region Problem 3
            //object obj;

            //obj = 100;
            //Console.WriteLine($"Value: {obj}, HashCode: {obj.GetHashCode()}");

            //obj = "Hello";
            //Console.WriteLine($"Value: {obj}, HashCode: {obj.GetHashCode()}");

            //obj = 99.99;
            //Console.WriteLine($"Value: {obj}, HashCode: {obj.GetHashCode()}"); 
            #endregion

            #region Problem 4
            //Person1 p1 = new Person1();
            //p1.Name = "Akl";
            //Console.WriteLine($"person1.Name = {p1.Name}");
            //Person1 p2 = p1;
            //Console.WriteLine($"person2.Name = {p2.Name}");
            //p2.Name = "Mahmoud";

            //Console.WriteLine($"person1.Name = {p1.Name}"); 
            #endregion

            #region Problem 5
            //string message = "Hi";
            //Console.WriteLine($"Original String: {message}");
            //Console.WriteLine($"Original HashCode: {message.GetHashCode()}");

            //// Modify by concatenation
            //message += " Willy";
            //Console.WriteLine($"Modified String: {message}");
            //Console.WriteLine($"Modified HashCode: {message.GetHashCode()}"); 
            #endregion

            #region Problem 6
            //StringBuilder sb = new StringBuilder("Hi");
            //Console.WriteLine($"Original StringBuilder: {sb}");
            //Console.WriteLine($"Original HashCode: {sb.GetHashCode()}");

            //// Append text
            //sb.Append(" Willy");
            //Console.WriteLine($"Modified StringBuilder: {sb}");
            //Console.WriteLine($"Modified HashCode: {sb.GetHashCode()}"); 
            #endregion

            #region Problem 7
            //Console.Write("Enter first number: ");
            //int input1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //int input2 = int.Parse(Console.ReadLine());

            //int sum = input1 + input2;
            //Console.WriteLine("Sum is " + input1 + " + " + input2 + " = " + sum);

            //Console.WriteLine(string.Format("Sum is {0} + {1} = {2}", input1, input2, sum));

            //Console.WriteLine($"Sum is {input1} + {input2} = {sum}"); 
            #endregion

            #region Problem 8
            //StringBuilder sb = new StringBuilder("Mahmoud");
            //sb.Append(" Akl");
            //sb.Replace(" Akl", " Abo_Akl");
            //sb.Insert(0, "Eng: ");
            //sb.Remove(0, 5);
            //Console.WriteLine(sb); 
            #endregion

        }
    }
}
