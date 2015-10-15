// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
// What is the 10001st prime number?

using System;

class P007Prime10001 {
  public static void Main (String[] args) {
    int answer = 2;

    for(int i = 2, j = 0; j < 10001; i++) {
      if(isPrime(i)) {
        answer = i;
        j++;
      }
    }
    Console.WriteLine("The 10001 prime number is : {0}.", answer);
  }

  private static bool isPrime(int number) {
    double rootDbl = Math.Sqrt(number);
    int root = (int) rootDbl;
    for(int i = 2; i <= root; i++) {
      if(number % i == 0) {
        return false;
      }
    }
    return true;
  }
}
