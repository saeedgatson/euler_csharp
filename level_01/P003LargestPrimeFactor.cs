// The prime factors of 13195 are 5, 7, 13 and 29.
// What is the largest prime factor of the number 600851475143?

using System;

public class P003LargestPrimeFactor {
  private static int largestPrimeFactor(long number) {
    long n = number;
    int highest = 2;
    for (int i = 2; i <= n; i++) {
      while (n % i == 0) {
        if(highest < i) {
          highest = i;
        }
        n /= i;
      }
    }
    return highest;
  }

  public static void Main (String [] args) {
    Console.WriteLine("Largest Prime Factor of 600851475143 is: {0}.", largestPrimeFactor(600851475143L));
  }
}
