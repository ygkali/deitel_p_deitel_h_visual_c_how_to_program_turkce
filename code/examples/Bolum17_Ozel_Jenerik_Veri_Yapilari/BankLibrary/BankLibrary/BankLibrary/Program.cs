using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BankLibrary
{
   static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main( string[] args )
      {
         Uygulamalication.EnableVisualStyles();
         Uygulamalication.Run(new BankUIForm());
      }
   }
}