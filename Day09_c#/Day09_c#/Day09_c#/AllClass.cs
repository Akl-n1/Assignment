namespace Day09_c_
{
    class Parent
    {
        public virtual double Salary { get; } = 5000;
    }

    class Child : Parent
    {
        // Sealed property cannot be overridden here
        public sealed override double Salary { get; } = 7000;
        public void DisplaySalary()
        {
            Console.WriteLine($"The Salary is: {Salary}");
        }
    }

    class Utility
    {
        public static int CalculatePerimeter(int length, int width)
        {
            return 2 * (length + width);
        }
    }

    class Complex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }
        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }
        public static Complex operator *(Complex x, Complex y)
        {
            return new Complex(
                x.Real * y.Real, x.Imaginary * y.Real);
        }
        public override string ToString()
        {
            return $"{Real} , {Imaginary} ";
        }
    }

    public static class Utility2
    {
        public static double ConvertTemperature(double value, string toUnit)
        {
            if (toUnit.ToLower() == "celsius")
            {
                // Fahrenheit to Celsius
                return (value - 32) * 5 / 9;
            }
            else if (toUnit.ToLower() == "fahrenheit")
            {
                // Celsius to Fahrenheit
                return (value * 9 / 5) + 32;
            }
            else
            {
                throw new ArgumentException("Invalid unit. Use 'Celsius' or 'Fahrenheit'.");
            }
        }
    }

    class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public int CompareTo(Employee? e)
        {
            int result = this.Id.CompareTo(e.Id);
            if (result == 0)
            {
                result = this.Name.CompareTo(e.Name);
            }
            if (result == 0)
            {
                result = this.Salary.CompareTo(e.Salary);
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            if (obj is Employee other)
            {
                return this.Id == other.Id &&
                       this.Name == other.Name;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Salary: {Salary}";
        }
    }
    public class Helper<T>
    {
        public static int SearchArray(T[] array, T Item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(Item))
                {
                    return i;
                }
            }
            return -1;
        }
    }

    public class Helper2
    {
        public static T Max<T>(T a, T b) where T : IComparable<T>
        {
            return (a.CompareTo(b) > 0) ? a : b;
        }
        public static void ReplaceArray<T>(T[] array, T oldValue, T newValue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(oldValue))
                {
                    array[i] = newValue;
                }
            }
        }

    }

    struct Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override string ToString()
        {
            return $"Length: {Length}, Width: {Width}";
        }
    }
    class Department
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Department(int id, string name)
        {
            Name = name;
            Id = id;
        }
        public override string ToString()
        {
            return Name;
        }
    }
    class Employee2
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public Department? Dept { get; set; }
        public Employee2(int id, string name, Department dept)
        {
            EmpId = id;
            Name = name;
            Dept = dept;

        }
        public override string ToString()
        {
            return $"Id: {EmpId}, Name: {Name}, Department: {Dept}";
        }

    }
    class SearchArrayS
    {

        public static List<Employee2> SearchArray(Employee2[] employees, int DeptId)
        {
            List<Employee2> result = new List<Employee2>();
            foreach (var emp in employees)
            {
                if (emp.Dept != null && emp.Dept.Id == DeptId)
                {
                    result.Add(emp);
                }

            }

            return result;
        }
    }

    struct CircleStruct
    {
        public double Radius { get; set; }
        public string Color { get; set; }

        public CircleStruct(double radius, string color)
        {
            Radius = radius;
            Color = color;
        }

        // Override Equals to compare values
        public override bool Equals(object obj)
        {
            if (obj is CircleStruct other)
            {
                return Radius == other.Radius && Color == other.Color;
            }
            return false;
        }

        // Override GetHashCode when overriding Equals
        public override int GetHashCode()
        {
            return HashCode.Combine(Radius, Color);
        }

        // Overload == and != operators
        public static bool operator ==(CircleStruct c1, CircleStruct c2)
        {
            return c1.Equals(c2);
        }

        public static bool operator !=(CircleStruct c1, CircleStruct c2)
        {
            return !c1.Equals(c2);
        }
    }
    class CircleClass
    {
        public double Radius { get; set; }
        public string Color { get; set; }

        public CircleClass(double radius, string color)
        {
            Radius = radius;
            Color = color;
        }
    }

    class GenericClass
    {
        public static T[] ReverseArray<T>(T[] array)
        {
            T[] reversed = new T[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                reversed[i] = array[array.Length - 1 - i];
            }
            return reversed;
        }

        public static void Swapping<T>(T[] array, int index1, int index2)
        {
            T Temp = array[index1];
            array[index1] = array[index2];
            array[index2] = Temp;
        }

    }
    public class MyStack<T>
    {
        private List<T> elements = new List<T>();
        public void Push(T item)
        {
            elements.Add(item);
        }
        public T Pop()
        {
            if (elements.Count == 0)
                throw new InvalidOperationException("Stack is empty.");
            T item = elements[^1];  // آخر عنصر
            elements.RemoveAt(elements.Count - 1);
            return item;
        }
        public T Peek()
        {
            if (elements.Count == 0)
                throw new InvalidOperationException("Stack is empty.");
            return elements[^1]; // آخر عنصر
        }
        public int Count
        {
            get { return elements.Count; }
        }
    }

    class Max<T> where T : IComparable<T>
    {
        public static T FindMax(T[] Arr)
        {
            if (Arr == null || Arr.Length == 0)
                throw new ArgumentException("Array is empty");
            T MaxElement = Arr[0];
            for (int i = 1; i < Arr?.Length; i++)
            {
                if (Arr[i].CompareTo(MaxElement) > 0)
                    MaxElement = Arr[i];
            }
            return MaxElement;
        }
    }



}
