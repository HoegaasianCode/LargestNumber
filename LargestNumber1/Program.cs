using System;

namespace LargestNumber1
{
    class Program
    {
        // https://edabit.com/challenge/nermqxzovZbfFBC9X
        // SOLVED
        // He don't need no LINQ, nonoooo

        static void Main(string[] args)
        {
            var arr1 = new int[] { 4, 2, -7, 1 };
            var arr2 = new int[] { 20, 70, 40, 90, 100, 200, 500, -900 };
            var arr3 = new int[] { 1, 2, 0 };
            var arrArr = new Calc(new int[][] { arr1, arr2, arr3 });
            var arr = arrArr.Calc1();
            foreach (var x in arr) Console.WriteLine(x);
        }
    }
}
