//A unit fraction contains 1 in the numerator. The decimal representation of the unit fractions with denominators 2 to 10 are given:
//Where 0.1(6) means 0.166666..., and has a 1-digit recurring cycle. It can be seen that 1/7 has a 6-digit recurring cycle.
//Find the value of d < 1000 for which 1/d contains the longest recurring cycle in its decimal fraction part.

using System;

public class P026ReciprocalCycles {
  public static void Main() {
    int longestCycle = 1;

    for(int index = 1001; index >= 0; index--) {
      if (longestCycle >= index) break;
      int[] found = new int[index + 1];
      int value = 1;
      int position = 0;

      while(found[value] == 0 && value != 0) {
        found[value] = position;
        value *= 10;
        value %= index;
        position += 1;
      }

      if(position - found[value] > longestCycle) {
        longestCycle = position - found[value];
      }
    }
    Console.WriteLine("The longest recurring cycle length is {0}.", longestCycle);
  }
}
