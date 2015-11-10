// The fraction 49/98 is a curious fraction, as an inexperienced mathematician in attempting to simplify it may incorrectly believe that 49/98 = 4/8, which is correct, is obtained by cancelling the 9s.
// We shall consider fractions like, 30/50 = 3/5, to be trivial examples.
// There are exactly four non-trivial examples of this type of fraction, less than one in value, and containing two digits in the numerator and denominator.
// If the product of these four fractions is given in its lowest common terms, find the value of the denominator.

using System;

public class P033DigitCancellingFractions {
  public int numeratorProduct = 0;
  public int denominatorProduct = 0;

  private static int gcd(int a, int b) {
    while (b > 0) {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
  }

  public static void Main() {
    int numerator = 1;
		int denomrator = 1;
		for (int d = 10; d < 100; d++) {
			for (int n = 10; n < d; n++) {
        int n1 = n % 10;
        int n2 = n / 10;
				int d1 = d % 10;
        int d2 = d / 10;
				if (n2 == d1 && n1 * d == n * d2 || n1 == d2 && n2 * d == n * d1) {
					numerator *= n;
					denomrator *= d;
				}
			}
		}
		Console.WriteLine(denomrator / gcd(numerator, denomrator));
  }
}
