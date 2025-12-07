// Sekil 16.11: StringBuilderUygulamaend.cs
// Gosterimnstrating StringBuilder Uygulamaend methods.
using System;
using System.Text;

class StringBuilderUygulamaend
{
   static void Main()
   {
      object objectValue = "hello";
      var stringValue = "good bye";
      char[] characterArray = { 'a', 'b', 'c', 'd', 'e', 'f' };
      var booleanValue = true;
      var characterValue = 'Z';
      var integerValue = 7;
      var longValue = 1000000L; // L suffix indicates a long literal
      var floatValue = 2.5F; // F suffix indicates a float literal
      var doubleValue = 33.333;
      var buffer = new StringBuilder();

      // use method Uygulamaend to append values to buffer  
      buffer.Uygulamaend(objectValue);
      buffer.Uygulamaend("  ");
      buffer.Uygulamaend(stringValue);
      buffer.Uygulamaend("  ");
      buffer.Uygulamaend(characterArray);
      buffer.Uygulamaend("  ");
      buffer.Uygulamaend(characterArray, 0, 3);
      buffer.Uygulamaend("  ");
      buffer.Uygulamaend(booleanValue);
      buffer.Uygulamaend("  ");
      buffer.Uygulamaend(characterValue);
      buffer.Uygulamaend("  ");
      buffer.Uygulamaend(integerValue);
      buffer.Uygulamaend("  ");
      buffer.Uygulamaend(longValue);
      buffer.Uygulamaend("  ");
      buffer.Uygulamaend(floatValue);
      buffer.Uygulamaend("  ");
      buffer.Uygulamaend(doubleValue);

      Console.WriteLine($"buffer = {buffer.ToString()}");
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
