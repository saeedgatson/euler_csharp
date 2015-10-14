// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

using System;

class P005SmallestMultiple {
  public static void Main(String[] args) {
    Console.WriteLine("Smallest multiple for 1 - 20 is : " + BruteForce(1, 20));
  }

  private static int BruteForce(int start, int end) {
    int number = start;
    while(true) {
      for(int j = start; j <= end ; j++) {
        if(number % j != 0) {
          number++;
          break;
        }

        if(j == end) {
          return number;
        }
      }
    }
  }
}
