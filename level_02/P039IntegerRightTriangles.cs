// If p is the perimeter of a right angle triangle with integral length sides, {a,b,c}, there are exactly three solutions for p = 120.
// {20,48,52}, {24,45,51}, {30,40,50}
// For which value of p ≤ 1000, is the number of solutions maximised?

using System;

public class P039IntegerRightTriangles {
  private static void BruteForce() {
    int[] p = new int[1001];
    int result = 0;

    for (int a = 1; a < 999; a++) {
      for (int b = 1; b + a < 1000; b++) {
            for (int c = 1; c + b + a < 1001; c++) {
                if (a * a + b * b == c * c) {
                    p[a + b + c]++;
                }
            }
        }
    }

    for (int i = 1; i < p.Length; i++) {
      if (p[i] > p[result]) {
        result = i;
      }
    }
    Console.WriteLine("The number of solutions is maximized for p= {0} resulting in {1} solutions.", result, p[result]);
  }

  public static void Main() {
    BruteForce();
  }
}
