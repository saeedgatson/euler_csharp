// An irrational decimal fraction is created by concatenating the positive integers:
// 0.123456789101112131415161718192021...
// It can be seen that the 12th digit of the fractional part is 1.
// If dn represents the nth digit of the fractional part, find the value of the following expression.
// d1 × d10 × d100 × d1000 × d10000 × d100000 × d1000000

using System;
using System.Text;

public class P040ChampernownesConstant {

  public static void Main() {
    StringBuilder sb = new StringBuilder();
    
    for(int i = 1; i < 1000000; i++) {
      sb.Append(i);
    }

    string dec = sb.ToString();
    Console.WriteLine("The fractional part of the special expression is {0}.",Char.GetNumericValue(dec[0]) * Char.GetNumericValue(dec[9]) * Char.GetNumericValue(dec[99]) * Char.GetNumericValue(dec[999]) * Char.GetNumericValue(dec[9999]) * Char.GetNumericValue(dec[99999]) * Char.GetNumericValue(dec[999999]));
  }
}
