using System;

public class Program
{
    public static int[] CountPosSumNeg(int[] arr)
    {
        int countPos = 0, sumNeg = 0;

        foreach (int num in arr)
        {
            if (num > 0)
            {
                countPos++;
            }
            else if (num < 0)
            {
                sumNeg += num;
            }
        }

        return new int[] { countPos, sumNeg };
    }

    public static void Main()
    {
        int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
        int[] result1 = CountPosSumNeg(arr1);
        Console.WriteLine(string.Join(",", result1));

        int[] arr2 = { 92, 6, 73, -77, 81, -90, 99, 8, -85, 34 };
        int[] result2 = CountPosSumNeg(arr2);
        Console.WriteLine(string.Join(",", result2));

        int[] arr3 = { 91, -4, 80, -73, -28 };
        int[] result3 = CountPosSumNeg(arr3);
        Console.WriteLine(string.Join(",", result3));

        int[] arr4 = { };
        int[] result4 = CountPosSumNeg(arr4);
        Console.WriteLine(string.Join(",", result4));
    }
}
