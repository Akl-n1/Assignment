using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_c_
{

    #region Main Employee
    //class Employee : IComparable<Employee>
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public int Salary { get; set; }

    //    //public int CompareTo(Employee? other)
    //    //{
    //    //    if (other == null) return 1;
    //    //    return this.Id.CompareTo(other.Id);
    //    //}
    //    public int CompareTo(Employee? other)
    //    {
    //        if (other == null) return 1;
    //        int result = this.Salary.CompareTo(other.Salary);
    //        if (result == 0)
    //            return this.Name.CompareTo(other.Name);
    //        return result;
    //    }
    //    public override string ToString()
    //    {
    //        return $"{Id} - {Name} - Salary: {Salary}";
    //    }
    //}
    #endregion

    class Employee : ICloneable, IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        // Implement Clone
        public object Clone()
        {
            return new Employee
            {
                Id = this.Id,
                Name = this.Name,
                Salary = this.Salary
            };
        }

        public int CompareTo(Employee other)
        {
            if (other == null) return 1;
            int result = this.Salary.CompareTo(other.Salary);
            if (result == 0)
                result = this.Name.CompareTo(other.Name);

            return result;
        }

        public override string ToString()
        {
            return $"Id={Id}, Name={Name}, Salary={Salary}";
        }
    }

    #region p1
    //class SortingAlgorithm1<T> where T : Employee
    //{
    //    public static void Sort(T[] Arr)
    //    {

    //        for (int i = 0; i < Arr.Length - 1; i++)
    //        {
    //            int min = i;
    //            for (int j = i + 1; j < Arr.Length; j++)
    //            {
    //                if (Arr[j].CompareTo(Arr[min]) < 0)
    //                    min = j;
    //            }
    //            T Temp = Arr[min];
    //            Arr[min] = Arr[i];
    //            Arr[i] = Temp;

    //        }

    //    }
    //}

    #endregion

    #region P2

    //class SortingAlgorithm2
    //{
    //    public static void Sort<T>(T[] Arr, Func<T, T, int> compare)
    //    {

    //        for (int i = 0; i < Arr.Length - 1; i++)
    //        {
    //            int min = i;
    //            for (int j = i + 1; j < Arr.Length; j++)
    //            {
    //                if (compare(Arr[j], (Arr[min])) < 0)
    //                    min = j;
    //            }
    //            T Temp = Arr[min];
    //            Arr[min] = Arr[i];
    //            Arr[i] = Temp;

    //        }

    //    }
    //} 
    #endregion

    #region P3
    //class SortingAlgorithm3
    //{
    //    public static void Sort<T>(T[] Arr, Func<T, T, int> compare)
    //    {

    //        for (int i = 0; i < Arr.Length - 1; i++)
    //        {
    //            int min = i;
    //            for (int j = i + 1; j < Arr.Length; j++)
    //            {
    //                if (compare(Arr[j], (Arr[min])) < 0)
    //                    min = j;
    //            }
    //            T Temp = Arr[min];
    //            Arr[min] = Arr[i];
    //            Arr[i] = Temp;

    //        }

    //    }
    //} 
    #endregion

    #region P4

    //class Manager : Employee, IComparable<Manager>
    //{
    //    public int CompareTo(Manager? other)
    //    {
    //        if (other == null) return 1;
    //        return this.Salary.CompareTo(other.Salary);
    //    }

    //    public override string ToString()
    //    {
    //        return $"Manager: {Name}, Salary: {Salary}";
    //    }
    //}
    //class SortingAlgorithm4
    //{
    //    public static void Sort<T>(T[] Arr, Func<T, T, int> Compare)
    //    {
    //        for (int i = 0; i < Arr.Length - 1; i++)
    //        {
    //            int min = i;
    //            for (int j = i + 1; j < Arr.Length; j++)
    //            {
    //                if (Compare(Arr[j], Arr[min]) < 0)
    //                {
    //                    min = j;
    //                }
    //            }
    //            T temp = Arr[min];
    //            Arr[min] = Arr[i];
    //            Arr[i] = temp;
    //        }

    //    }
    //} 
    #endregion


    class SortingAlgorithm5
    {
        public static void Sort<T>(T[] Arr, Func<T, T, bool> Compare)
        {
            for (int i = 0; i < Arr.Length - 1; i++)
            {
                for (int j = i + 1; j < Arr.Length; j++)
                {
                    if (!Compare(Arr[i], Arr[j]))
                    {
                        T temp = Arr[i];
                        Arr[i] = Arr[j];
                        Arr[j] = temp;
                    }

                }
            }

        }
    }

    class SortingAlgorithm6
    {
        public static void Sort<T>(T[] Arr, Func<T, T, bool> Compare)
        {
            for (int i = 0; i < Arr.Length - 1; i++)
            {
                for (int j = i + 1; j < Arr.Length; j++)
                {
                    if (!Compare(Arr[i], Arr[j]))
                    {
                        T temp = Arr[i];
                        Arr[i] = Arr[j];
                        Arr[j] = temp;
                    }

                }
            }

        }
    }

    class SortingAlgorithm7
    {
        public static void Swap<U>(ref U num1, ref U num2)
        {
            U temp = num1;
            num1 = num2;
            num2 = temp;
        }
        public static void Sort<U>(U[] Arr) where U : IComparable<U>
        {
            for (int i = 0; i < Arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < Arr.Length; j++)
                {
                    if (Arr[j].CompareTo(Arr[min]) < 0)
                    {
                        min = j;
                    }
                }
                Swap(ref Arr[i], ref Arr[min]);
            }

        }
    }

    class SortingAlgorithm8
    {
        public static void Sort<T>(T[] arr) where T : IComparable<T>
        {
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    int min = i;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[j].CompareTo(arr[min]) < 0)
                        {
                            T temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }
        }
    }

    class SortingAlgorithm<T> where T : ICloneable, IComparable<T>
    {
        public static T[] Sort(T[] arr)
        {
            T[] CloneArr = new T[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                CloneArr[i] = (T)arr[i].Clone();
            }
            for (int i = 0; i < CloneArr.Length - 1; i++)
            {
                for (int j = i + 1; j < CloneArr.Length; j++)
                {
                    if (CloneArr[j].CompareTo(CloneArr[i]) < 0)
                    {
                        T temp = CloneArr[j];
                        CloneArr[j] = CloneArr[i];
                        CloneArr[i] = temp;
                    }
                }
            }
            return CloneArr;
        }
    }


    class Transformation
    {
        public delegate string StringTransformer(string input);
        public static List<string> ApplyTransformation(List<string> input, StringTransformer stringTransformer)
        {
            List<string> output = new List<string>();
            foreach (string inputItem in input)
            {
                output.Add(stringTransformer(inputItem));
            }
            return output;
        }
    }

    class operations
    {
        public delegate int Operations(int num1, int num2);
        public static int Calculate(int num1, int num2, Operations op)
        {
            return op(num1, num2);
        }
    }

    public class TransformList
    {
        public delegate R Transform<T, R>(T list);
        public static List<R> TransformListMethos<T, R>(List<T> list, Transform<T, R> transform)
        {
            List<R> Result = new List<R>();
            foreach (T item in list)
            {
                Result.Add(transform(item));
            }
            return Result;

        }

        public static List<TResult> Squre<T, TResult>(List<T> values, Func<T, TResult> squre)
        {
            var result = new List<TResult>();
            foreach (T item in values)
                result.Add(squre(item));
            return result;
        }

        public static List<T> Filter<T>(List<T> values, Predicate<T> condition)
        {
            var Result = new List<T>();
            foreach (var item in values)
                if (condition(item))
                    Result.Add(item);
            return Result;
        }

        public static List<string> FilterStrings(List<string> list, Predicate<string> condition)
        {
            List<string> result = new List<string>();
            foreach (var str in list)
            {
                if (condition(str)) // الشرط اللى اتبعت
                {
                    result.Add(str);
                }
            }
            return result;
        }

        public static int PerformOperation(int a, int b, Func<int, int, int> operation)
        {
            return operation(a, b);
        }

        public static double PerformOperation(double a, double b, Func<double, double, double> operation)
        {
            return operation(a, b);
        }
    }


}

