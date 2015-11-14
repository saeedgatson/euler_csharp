// The number 3797 has an interesting property. Being prime itself, it is possible to continuously remove digits from left to right, and remain prime at each stage: 3797, 797, 97, and 7. Similarly we can work from right to left: 3797, 379, 37, and 3.
// Find the sum of the only eleven primes that are both truncatable from left to right and right to left.
// NOTE: 2, 3, 5, and 7 are not considered to be truncatable primes.

using System;

public class P037TruncatablePrimes {
  private static bool isTruncatablePrime(int number) {
    string numberString = number.ToString();
    string reverseNumber = ReverseString(numberString);

    for(int i = 0; i < numberString.Length; i++){
      if(!isPrime(int.Parse(numberString.Substring(i)))) {
        return false;
      }

      if(!isPrime(int.Parse(reverseNumber.Substring(i)))) {
        return false;
      }
    }
    return true;
  }

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

  public static string ReverseString(string s) {
  	char[] arr = s.ToCharArray();
  	Array.Reverse(arr);
  	return new string(arr);
  }

  public static void Main() {
    long sum = 0;
		for (int count = 0, n = 10; count < 11; n++) {
			if (isTruncatablePrime(n)) {
				sum += n;
				count++;
			}
		}
    Console.WriteLine("The sum of the eleven truncatable primes is {0}.", sum);
  }
}
