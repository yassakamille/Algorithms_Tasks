using System;
public class Program
{
    public static bool calc(int[] arr, int start, int end)
    {
        // Base case: when the array contains only one element
        if (start == end)
        {
            if (arr[start] % 2 == 0)
            {
                return false;
            }
            else { return true; };
            // returns true if even, false if odd
        }
        // Divide: split the array into two halves
        int mid = (start + end) / 2;
        // Conquer: recursively check the 2 halves
        bool a = calc(arr, start, mid);
        bool b = calc(arr, mid + 1, end);
        // Combine: check the returned status from the two halves
        if (a == b) { return false; }
        else
        {
            return true; // even + odd = odd
        }
    }
    public static void Main(string[] args)
    {
        int[] arr = { 2, 4, 6, 8, 1, 3, 5, 7 };
        int start = 0;
        int end = arr.Length - 1;
        bool isEvenOdd = calc(arr, start, end);
        Console.WriteLine("The array contains an even number of even and odd elements: " + isEvenOdd);
    }
}
  