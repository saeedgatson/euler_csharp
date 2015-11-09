// We shall say that an n-digit number is pandigital if it makes use of all the digits 1 to n exactly once; for example, the 5-digit number, 15234, is 1 through 5 pandigital.
// The product 7254 is unusual, as the identity, 39 × 186 = 7254, containing multiplicand, multiplier, and product is 1 through 9 pandigital.
// Find the sum of all products whose multiplicand/multiplier/product identity can be written as a 1 through 9 pandigital.
// HINT: Some products can be obtained in more than one way so be sure to only include it once in your sum.

using System;
using System.Collections.Generic;
using System.Linq;

public class P032PandigitalProducts {
  private static HashSet<int> hashSet = new HashSet<int>();

  public static bool isPandigital(int multiplicand, int multiplier) {
    int product = multiplicand * multiplier;
    string smashed = multiplier.ToString() + multiplicand.ToString() + product.ToString();
    string sorted = String.Concat(smashed.OrderBy(c => c));
    if(sorted.Length == 9 && sorted.Equals("123456789")){
      return true;
    }
    return false;
  }

  public static void Main() {
    for(int i = 1; i < 9999; i++) {
      for(int j = i + 1; j < 9999; j++) {
        int product = i * j;
        if(isPandigital(i, j)){
          hashSet.Add(product);
        }
        else if (product > 99999999 ) {
          break;
        }
      }
    }
    int sum = 0;
    foreach (int n in hashSet) {
      sum += n;
    }

    Console.WriteLine("The sum of all products whose multiplicand/multiplier/product identity can be written as a 1 through 9 is : {0}", sum);
  }
}
