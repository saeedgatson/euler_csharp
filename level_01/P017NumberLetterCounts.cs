// If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
// If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?
// NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. The use of "and" when writing out numbers is in compliance with British usage.

using System;

public class P017NumberLetterCounts {
  private static string[] ONES = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
  private static string[] TEENS = {"ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
  private static string[] TENS = {"twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};

  public static void Main() {
    int wordCount = 0;
		for (int i = 1; i <= 1000; i++) {
			wordCount += english(i).Length;
    }

    Console.WriteLine("The number of letter in the sum of 1 to 1000 written out in words is {0}.", wordCount);
  }

	private static string english(int number) {
		if (number < 100)
			return tens(number);
		else {
			string result = "";
			if (number >= 1000)
				result += tens(number / 1000) + "thousand";
			if (number / 100 % 10 != 0)
				result += ONES[number / 100 % 10] + "hundred";
			if (number % 100 != 0)
				result += "and" + tens(number % 100);
			return result;
		}
	}

	private static string tens(int number) {
    if (number < 10)
      return ONES[number];
		else if (number < 20)
			return TEENS[number - 10];
		else
			return TENS[number / 10 - 2] + (number % 10 != 0 ? ONES[number % 10] : "");
	}
}
