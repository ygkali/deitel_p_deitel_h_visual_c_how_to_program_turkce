// Sekil 10.8: Employee.cs
// Employee class with references to other objects.
public class Employee
{
   public string FirstName { get; }
   public string LastName { get; }
   public Date BirthDate { get; }
   public Date HireDate { get; }

   // constructor to initialize name, birth date and hire date
   public Employee(string firstName, string lastName,
      Date birthDate, Date hireDate)
   {
      FirstName = firstName;
      LastName = lastName;
      BirthDate = birthDate;
      HireDate = hireDate;
   }

   // convert Employee to string format
   public override string ToString() => $"{LastName}, {FirstName} " +
       $"Hired: {HireDate}  Birthday: {BirthDate}";
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
