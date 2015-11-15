// By concatenating each product we get the 1 to 9 pandigital, 192384576. We will call 192384576 the concatenated product of 192 and (1,2,3)
// The same can be achieved by starting with 9 and multiplying by 1, 2, 3, 4, and 5, giving the pandigital, 918273645, which is the concatenated product of 9 and (1,2,3,4,5).
// What is the largest 1 to 9 pandigital 9-digit number that can be formed as the concatenated product of an integer with (1,2, ... , n) where n > 1?

using System;

public class P038PandigitalMultiples {
  public static int getPandigital(int multiplicand) {
    int number = 1;
    string check = "";
    string smashed = "";
    while(check.Length < 9) {
      int product = multiplicand * number;
      smashed += product.ToString();
      char[] chars = smashed.ToCharArray();
      Array.Sort(chars);
      check = new string(chars);
      if(check.Length == 9 && check.Equals("123456789")){
        return int.Parse(smashed);
      }
      number++;
    }
    return 0;
  }
  
  public static void Main() {
    int max = 999999;
    int largest = 1;

    for(int i = 0; i <= max; i++) {
      int check = getPandigital(i);
      if(check >= largest) {
        largest = check;
      } else if(check > 99999999) {
        break;
      }
    }
    Console.WriteLine("The largest 1 to 9 pandigital 9-digit number that can be formed as the concatenated product of an integer with (1,2, ... , n) where n > 1 is {0}", largest);
  }
}
