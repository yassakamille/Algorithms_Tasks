using System;
class program
{
    static int binarySearch(int[] arr, int start, int end, int x)
    {
        if (start<=end)
        {
            int mid = (start + end) / 2;
            // If the element is present at the
            // middle itself
            if (arr[mid] == x)
                return mid;
            // If element is smaller than mid, then
            // it can only be present in left subarray
           else if (arr[mid] > x)
                return binarySearch(arr, start, mid - 1, x);
            // Else the element can only be present
            // in right subarray
           else return binarySearch(arr, mid + 1, end, x);
        }
        // We reach here when element is not present
        // in array
        return -1;
    }
  
    public static void Main()
    {
        int[] arr = { 2, 3, 4, 50, 10, 40 };
        int n = arr.Length;
        Console.WriteLine("Entetr number : ");
        int x= int.Parse(Console.ReadLine());
      
        int result = binarySearch(arr, 0, n - 1, x);
        if (result == -1)
            Console.WriteLine("Element is not present in array");
        else
            Console.WriteLine("Element is present at index " + result);
    }

}