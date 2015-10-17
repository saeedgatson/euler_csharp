
using System;

class P009SpecialPythagoreanTriplet {
  public static void Main (String[] args) {
    int a = 0 , b = 0, c = 0;
    int sum = 1000;
    bool isFound = false;

    for (a = 1; a < sum / 3; a++) {
      for (b = a; b < sum / 2; b++) {
        c = sum - a -b;

        if (a * a + b * b == c * c) {
          isFound = true;
          break;
        }
      }

      if(isFound) {
        break;
      }
    }

    Console.WriteLine("Triple is {0}, {1}, {2}, and the sume is {3}.\nThe product is{4}.", a, b, c, a + b + c, a * b * c);
  }
}
