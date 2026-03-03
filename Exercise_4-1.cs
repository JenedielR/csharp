using System;
using static System.Console;
using System.Globalization;

class CheckCredit
{
  static void Main()
  {
    const double LIMIT = 8000;
    double price;

    Write("Enter the price: ")
    price = Convert.ToDouble(ReadLine());

    // LOGIC
    if(price > LIMIT) 
    {
      WriteLine("You have exceeded the credit limit");
    }
    else 
    {
    WriteLine("Approved");
    }
    // OUTPUT
  }
}
