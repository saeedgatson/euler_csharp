// The Fibonacci sequence is defined by the recurrence relation:
// What is the index of the first term in the Fibonacci sequence to contain 1000 digits?
using System;
using System.Numerics;

public class P025ThousandDigitFibonacci {
  public static void Main() {
    int index = 2;
    BigInteger number_1 = 1;
    BigInteger number_2 = 1;
    BigInteger next_number = 0;
    BigInteger MAX = BigInteger.Pow(10, 999);

    while (next_number <= MAX) {
      next_number = number_1 + number_2;
      index += 1;
      number_1 = number_2;
      number_2 = next_number;
    }
    Console.WriteLine("The index of the first term in the Fibonacci sequence to contain 1000 digits is {0}", index);
  }
}
