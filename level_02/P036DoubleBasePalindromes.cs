// The decimal number, 585 = 10010010012 (binary), is palindromic in both bases.
// Find the sum of all numbers, less than one million, which are palindromic in base 10 and base 2.
// (Please note that the palindromic number, in either base, may not include leading zeros.)

using System;
using System.Text;

public class P036DoubleBasePalindromes {
  public static bool isDoublePalindrome(int number){
    string numberString = number.ToString();
    string reverseNumber = ReverseString(numberString); //new StringBuilder(numberString).reverse().ToString();
    string binaryNumber = Convert.ToString(number, 2);
    string reverseBinaryNumber = ReverseString(binaryNumber); //new StringBuilder(binaryNumber).reverse().ToString();
    return reverseNumber.Equals(numberString) && reverseBinaryNumber.Equals(binaryNumber);
  }

  public static string ReverseString(string s)
  {
  	char[] arr = s.ToCharArray();
  	Array.Reverse(arr);
  	return new string(arr);
  }

  public static void Main() {
    int total = 0;
    for(int i = 1; i < 1000000; i++) {
      if(isDoublePalindrome(i)){
        total += i;
      }
    }
    Console.WriteLine("Total sum is {0}.", total);
  }
}
