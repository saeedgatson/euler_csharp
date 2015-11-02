// How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?

using System;

public class P019CountingSundays {
  public static void Main() {
    int sundayCount = 0;
    // LocalDate start = LocalDate.of(1901, 1, 1);
    // LocalDate end = LocalDate.of(2000, 12, 31);
    //
    // for (LocalDate date = start; date.isBefore(end); date = date.plusDays(1)) {
    //   if(DayOfWeek.SUNDAY == date.getDayOfWeek() && date.getDayOfMonth() == 1)
    //     sundayCount++;
    // }
    DateTime start = new DateTime(1901, 1, 1);
    DateTime end = new DateTime(2000, 12, 31);

    for(DateTime date = start; date.CompareTo(end) < 0; date = date.AddDays(1)) {
       if(date.DayOfWeek == DayOfWeek.Sunday && date.Day == 1) {
         sundayCount++;
       }
    }
    Console.WriteLine("{0} Sundays fell on the first of the month during the twentieth century.", sundayCount);
  }
}
