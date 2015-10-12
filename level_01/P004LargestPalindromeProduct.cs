//A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
//Find the largest palindrome made from the product of two 3-digit numbers.

using System;

public class P004LargestPalindromeProduct {

  public static void Main(String[] args) {
    int largestPalindrome = 0;
    int product = 0;
    int num1 = 0;
    int num2 = 0;

    for (int i = 100; i < 1000; i++ ) {
      for (int j = 100; j < 1000; j++) {
        product = i * j;
        if(isPalindrome(product)) {
          if(largestPalindrome < product) {
            num1 = i;
            num2 = j;
            largestPalindrome = product;
          }
        }
      }
    }
    Console.WriteLine("Largest palindrome product for 3-digits is : {0} = {1} x {2}", largestPalindrome, num1, num2);
  }

  private static bool isPalindrome(int number) {
    String numberString = number.ToString();
    char[] charArray = numberString.ToCharArray();
    Array.Reverse(charArray);
    String reversedString = new string(charArray);
    return numberString.Equals(reversedString);
  }
}
