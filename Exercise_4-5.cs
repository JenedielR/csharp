using System;
using static System.Console;
using System.Globalization;

class CheckMonth {
  static void Main() {

  Write("Enter your birth month: ");
  int month = Convert.ToInt32(ReadLine());
  // LOGIC
  if (month > 12 || month < 1) {
    WriteLine("{0} is a valid month.", month);
  else {
    WriteLine("{0} is a valid month.", month);
  }
  }
  }
}
