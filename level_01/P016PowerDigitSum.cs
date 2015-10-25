// 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
// What is the sum of the digits of the number 2^1000?
using System;
using System.Numerics;

public class P016PowerDigitSum {
    public static void Main() {
        BigInteger number = BigInteger.Pow(2, 1000);
        Console.WriteLine("The sum of digits for 2^1000 is : {0}.", sumDigits(number));
    }

    private static BigInteger sumDigits(BigInteger digits) {
        BigInteger sum = 0;
        BigInteger ten = 10;

        while ( digits > BigInteger.Zero ) {
          sum += (digits % 10);
          digits /= ten;
        }
        return sum;
    }
}
