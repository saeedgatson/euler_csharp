// A permutation is an ordered arrangement of objects. For example, 3124 is one possible permutation of the digits 1, 2, 3 and 4. If all of the permutations are listed numerically or alphabetically, we call it lexicographic order. The lexicographic permutations of 0, 1 and 2 are:
// 012   021   102   120   201   210
// What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?

using System;
using System.Collections;

public class P024LexicographicPermutations {
  private static string digits = "0123456789";
  private static ArrayList permutationList = new ArrayList();

  private static void permutation(string prefix, string str) {
    int n = str.Length;
    if(n == 0) {
      permutationList.Add(prefix);
    }
    else {
      for (int i = 0; i < n; i++) {
          permutation(prefix + str[i], str.Substring(0, i) + str.Substring(i+1));
      }
    }
  }

  public static void Main() {
    permutation("", digits);
    Console.WriteLine("The millionth lexicographic permutation is {0}", permutationList[999999]);
  }
}
