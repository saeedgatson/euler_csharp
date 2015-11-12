// 145 is a curious number, as 1! + 4! + 5! = 1 + 24 + 120 = 145.
// Find the sum of all numbers which are equal to the sum of the factorial of their digits.
// Note: as 1! = 1 and 2! = 2 are not sums they are not included.

using System;

public class P034DigitFactorials {

  private static int factorial(int x) {
    if (x == 0) return 1;

    int y = x;
    for (int i = 1; i < x; i++) {
        y *= i;
    }
    return y;
  }

  public static void Main() {
    int result = 0;
    for (int i = 10; i < 2540161; i++) {
      int factorialSum = 0;
      int number = i;

      while (number > 0) {
        int d = number % 10;
        number /= 10;
        factorialSum += factorial(d);
      }

      if (factorialSum == i) {
          result += i;
      }
    }
    Console.WriteLine("The sum of all numbers which are equal to the sum of the factorial of their digits is {0}.", result);
  }
}
