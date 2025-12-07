// Screen.cs
// Represents the screen of the ATM
using System;

public class Screen
{
   // displays a message without a terminating carriage return
   public void DisplayMessage(string message)
   {
      Console.Write(message);
   } 

   // display a message with a terminating carriage return
   public void DisplayMessageLine(string message)
   {
      Console.WriteLine(message);
   } 

   // display a dollar amount
   public void DisplayDollarAmount(decimal amount)
   {
      Console.Write("{0:C}", amount);
   } 
} 

/**************************************************************************
 * (C) Telif Hakki 1992-2017 Deitel (C) Copyright 1992-2017 by Deitel & Associates, Inc. and Associates, Inc. ve               *
 * Pearson Education, Inc.e aittir. Tum Haklari Saklidir.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
