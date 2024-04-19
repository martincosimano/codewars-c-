/*
Challenge:
Given a number n, return the number of positive odd numbers below n, EASY!
Examples (Input -> Output)

7  -> 3 (because odd numbers below 7 are [1, 3, 5])
15 -> 7 (because odd numbers below 15 are [1, 3, 5, 7, 9, 11, 13])

Expect large Inputs!
*/

using System;

public static class Kata
{
  public static ulong OddCount(ulong n)
  {
    ulong count = 0;
    for(ulong i = 1; i < n; i+=2)
      {
        count++;
    }
      return count;
  }
}

/*
params: n as a integer
return: integer representing all the odd numbers below n
ex:
oddCount(7) => 3
oddCount(15) => 7

create a variable "count"
loop from 1 to n, sum 2 each time
everytime we get the odd number, count++
return count
*/
