// n! means n × (n − 1) × ... × 3 × 2 × 1
// For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800, and the sum of the
// digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
// Find the sum of the digits in the number 100!

using System;
using System.Numerics;

public class P020FactorialDigitSum {

  public static void Main() {
    Console.WriteLine("The sum of digits in the factorial of 100 is {0}.", sumDigits(factorial100()));
  }

  private static BigInteger factorial100() {
    BigInteger sum = 1;
    BigInteger i = 1;
    BigInteger hundred = 100;

    while(i != hundred) {
      sum *= i;
      i++;
    }
    return sum;
  }

  private static BigInteger sumDigits(BigInteger number) {
    BigInteger sum = 0;
    BigInteger ten = 10;

    while(number != 0) {
      sum += number % 10; //sum.add(number.mod(ten));
      number = number / ten; //number.divide(ten);
    }
    return sum;
  }
}
