// Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.
// How many such routes are there through a 20×20 grid?

using System;
using System.Numerics;

class P015LatticePaths {
  public static void Main() {
    int moves = 40;
    int rights = 20;
    Console.WriteLine("Starting at the top left corner of a 20×20 grid, and only being able to move to the right and down, there are exactly {0} routes to the bottom right corner.", combination(moves, rights));
  }

  public static BigInteger factorial(int n1) {
    BigInteger n = BigInteger.One;
    for (int i = 1; i <= n1; i ++) {
      n = BigInteger.Multiply(new BigInteger(i), n);
    }
    return n;
  }

  public static BigInteger combination(int n, int r) {
    return BigInteger.Divide(factorial(n), BigInteger.Multiply(factorial(r), factorial(n - r)));
  }
}
