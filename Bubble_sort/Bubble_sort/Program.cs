﻿using System;
class program
{

    public static void Main()
    {

        int[] arr = { 64, 34, 25, 12, 22, 11, 90};
        int n = arr.Length;
        bubbleSort(arr, n);
        Console.WriteLine("Sorted array:");
        printArray(arr, n);

    }

    static void bubbleSort(int[] arr, int n)
    {
        int i, j, temp;
        bool swapped = false; 
        for (i = 0; i < n - 1; i++)
        {
           
            for (j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                  
                    // Swap arr[j] and arr[j+1]
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }

            // If no two elements were
            // swapped by inner loop, then break
            if (swapped == false)
                break;
        }
    }

    // Function to print an array
    static void printArray(int[] arr, int size)
    {
        int i;
        for (i = 0; i < size; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
}