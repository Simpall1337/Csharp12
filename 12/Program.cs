using System;
namespace Lessons
{
    internal class Program
    {
        static void SumArray(int[] myArray, ref int sum, int i = 0)
        {
            if (i == myArray.Length)
                return;
            sum += myArray[i];
            i++;
            SumArray(myArray, ref sum, i);
        }
        static void Main(string[] args)
        {
            int sum = 0;
            int[] myArray = new int[5] { 1, 2, 3, 4, 5 };
            SumArray(myArray, ref sum);
            Console.WriteLine(sum);
        }
    }
}