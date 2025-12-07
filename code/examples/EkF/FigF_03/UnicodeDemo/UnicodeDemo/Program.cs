using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UnicodeGosterim
{
   static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         Uygulamalication.EnableVisualStyles();
         Uygulamalication.SetCompatibleTextRenderingDefault( false );
         Uygulamalication.Run( new UnicodeForm() );
      }
   }
}
