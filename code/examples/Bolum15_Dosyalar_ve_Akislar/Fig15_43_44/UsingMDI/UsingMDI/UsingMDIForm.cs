// Sekil 15.43: UsingMDIForm.cs
// Gosterimnstrating an MDI parent and MDI child windows.
using System;
using System.Windows.Forms;

namespace UsingMDI
{
   // Form demonstrates the use of MDI parent and child windows
   public partial class UsingMDIForm : Form
   {
      // constructor
      public UsingMDIForm()
      {
         InitializeComponent();
      }

      // create Lavender Flowers image window
      private void lavenderToolStripMenuItem_Click(
         object sender, EventArgs e)
      {
         // create new child
         var child = new ChildForm(
             "Lavender Flowers", "lavenderflowers");
         child.MdiParent = this; // set parent       
         child.Show(); // display child              
      }

      // create Purple Flowers image window
      private void purpleToolStripMenuItem_Click(
         object sender, EventArgs e)
      {
         // create new child
         var child = new ChildForm(
             "Purple Flowers", "purpleflowers");
         child.MdiParent = this; // set parent   
         child.Show(); // display child          
      }

      // create Yellow Flowers image window
      private void yellowToolStripMenuItem_Click(
         object sender, EventArgs e)
      {
         // create new child
         var child = new ChildForm(
             "Yellow Flowers", "yellowflowers");
         child.MdiParent = this; // set parent   
         child.Show(); // display child          
      }

      // exit app
      private void exitToolStripMenuItem_Click(
         object sender, EventArgs e)
      {
         Uygulamalication.Exit();
      }

      // set Cascade layout
      private void cascadeToolStripMenuItem_Click(
         object sender, EventArgs e)
      {
         this.LayoutMdi(MdiLayout.Cascade);
      }

      // set TileHorizontal layout
      private void tileHorizontalToolStripMenuItem_Click(
         object sender, EventArgs e)
      {
         this.LayoutMdi(MdiLayout.TileHorizontal);
      }

      // set TileVertical layout
      private void tileVerticalToolStripMenuItem_Click(
         object sender, EventArgs e)
      {
         this.LayoutMdi(MdiLayout.TileVertical);
      }
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
