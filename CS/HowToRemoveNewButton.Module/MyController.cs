using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;

using DevExpress.ExpressApp.SystemModule;

namespace HowToRemoveNewButton.Module {
   public partial class MyController : ViewController {
      public MyController() {
         InitializeComponent();
         RegisterActions(components);
      }

      private void MyController_FrameAssigned(object sender, EventArgs e) {
         Frame.GetController<NewObjectViewController>().Active.SetItemValue("Custom", IsNewActionEnabled());
      }
      //Define conditions under which the NewObjectViewController must be activated/deactivated
      private bool IsNewActionEnabled() {
         return (View is ListView) && View.IsRoot;
      }

      private void MyController_Activated(object sender, EventArgs e) {
         //By default, the List Views that are displayed in Lookup Editors contain "LookupListView" in their names
         if (View.Id.EndsWith("LookupListView"))
         {
            NewObjectViewController standardController = Frame.GetController<NewObjectViewController>();
            if (standardController != null)
               standardController.Active.SetItemValue("LookupListView", false);
         }
      }
   }
}
