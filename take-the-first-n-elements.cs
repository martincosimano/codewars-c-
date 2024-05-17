/*
Challenge:
Create a function that accepts a list/array and a number n, and returns a list/array of the first n elements from the list/array.
*/

using System;

public static class Kata
{
    public static int[] Take(int[] arr, int n)
    {
      if (n >= arr.Length)
        return arr;

      int[] result = new int[n];

      Array.Copy(arr, 0, result, 0, n);

      return result;
    }
}
