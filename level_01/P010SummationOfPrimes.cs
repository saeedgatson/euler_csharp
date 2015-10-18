// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
// Find the sum of all the primes below two million.

using System;

class P010SummationOfPrimes {
  private static P010SummationOfPrimes summation = new P010SummationOfPrimes();

  public static void Main (String[] args) {
    Console.WriteLine("Sum of all primes below {0} is {1}.", 2000000, getSumOfPrimes(2000000));
  }

  private static long getSumOfPrimes(int max) {
    long totalSum = 0;
    for(int i = 2; i < max; i++ ) {
      if(isPrime(i)) {
        totalSum += i;
      }
    }

    return totalSum;
  }

  private static bool isPrime(int number) {
    int root = (int) Math.Sqrt(number);
    for(int i = 2; i <= root; i++) {
      if(number % i == 0) {
        return false;
      }
    }
    return true;
  }
}
