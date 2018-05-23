using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

using DevExpress.ExpressApp;

namespace HowToRemoveNewButton.Module.Win {
   [ToolboxItemFilter("Xaf.Platform.Win")]
   public sealed partial class HowToRemoveNewButtonWindowsFormsModule : ModuleBase {
      public HowToRemoveNewButtonWindowsFormsModule() {
         InitializeComponent();
      }
   }
}
