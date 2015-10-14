// The sum of the squares of the first ten natural numbers is, 1^2 + 2^2 + ... + 10^2 = 385
// The square of the sum of the first ten natural numbers is, (1 + 2 + ... + 10)^2 = 55^2 = 3025
// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

using System;

class P006SumSquareDifference {
  public static void Main (String[] args) {
    P006SumSquareDifference sumSquareDiff = new P006SumSquareDifference();

    Console.WriteLine("The sum of square difference for first 100 natrual numbers is : {0}", (sumSquareDiff.squareOfSum(1,100) - sumSquareDiff.sumOfSquares(1,100)));
  }

  private int sumOfSquares(int start, int end) {
    int sum = 0;
    for (int i = start; i <= end; i++) {
      sum += (i * i);
    }
    return sum;
  }

  private int squareOfSum(int start, int end) {
    int sum = 0;
    for (int i = start; i <= end; i++) {
      sum += i;
    }
    return sum * sum;
  }
}
