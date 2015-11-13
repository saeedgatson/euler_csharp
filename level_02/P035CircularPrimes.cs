// The number, 197, is called a circular prime because all rotations of the digits: 197, 971, and 719, are themselves prime.
// There are thirteen such primes below 100: 2, 3, 5, 7, 11, 13, 17, 31, 37, 71, 73, 79, and 97.
// How many circular primes are there below one million?

using System;

public class P035CircularPrimes {
  private static int LIMIT = (int) Math.Pow(10, 6);
  private static bool[] isPrime = listPrimality(LIMIT - 1);

	private static bool[] listPrimality(int n) {
		bool[] result = new bool[n + 1];
		if (n >= 2)
			result[2] = true;
		for (int i = 3; i <= n; i += 2)
			result[i] = true;

		for (int i = 3, end = (int) Math.Sqrt(n); i <= end; i += 2) {
			if (result[i]) {
				for (int j = i * i; j <= n; j += i << 1)
					result[j] = false;
			}
		}
		return result;
	}

  private static bool isCircularPrime(int n) {
		string s = n.ToString();
		for (int i = 0; i < s.Length; i++) {
			if (!isPrime[int.Parse(s.Substring(i) + s.Substring(0, i))])
				return false;
		}
		return true;
	}

  public static void Main() {
    int count = 0;
		for (int i = 0; i < isPrime.Length; i++) {
			if (isCircularPrime(i))
				count++;
		}
		Console.WriteLine("Number of circular primes below one million is {0}.", count);
  }
}
