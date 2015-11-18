// We shall say that an n-digit number is pandigital if it makes use of all the digits 1 to n exactly once. For example, 2143 is a 4-digit pandigital and is also prime.
// What is the largest n-digit pandigital prime that exists?

using System;

public class P041PandigitalPrime {
  private static bool isPrime(int number) {
    if(number < 2) return false;

    double rootDbl = Math.Sqrt(number);
    long root = (long) rootDbl;

    for(long i = 2; i <= root; i++) {
      if(number % i == 0) {
        return false;
      }
    }
    return true;
  }

  public static bool isPandigitalPrime(int number) {
    if(!isPrime(number)) return false;

    char[] chars = number.ToString().ToCharArray();
    Array.Sort(chars);
    string sorted = new string(chars);
    if(sorted.Equals("1234567")){
      return true;
    }
    return false;
  }

  public static void Main() {
    int largest = 1;
    for(int i = 10; i < 7654321; i++) {
      if(isPandigitalPrime(i) && i > largest) {
        largest = i;
      }
    }
    Console.WriteLine("The largest n-digit pandigital prime that exists is {0}.", largest);
  }
}
