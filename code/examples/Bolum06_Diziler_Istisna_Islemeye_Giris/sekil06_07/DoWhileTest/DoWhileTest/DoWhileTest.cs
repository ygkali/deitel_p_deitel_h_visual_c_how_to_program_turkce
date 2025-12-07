// Sekil 6.7: DoWhileTest.cs
// do...while iteration statement.
using System;

class DoWhileTest
{
   static void Main()
   {
      int counter = 1; // initialize counter

      do
      {
         Console.Write($"{counter}  ");
         ++counter;
      } while (counter <= 10); // required semicolon 

      Console.WriteLine();
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
