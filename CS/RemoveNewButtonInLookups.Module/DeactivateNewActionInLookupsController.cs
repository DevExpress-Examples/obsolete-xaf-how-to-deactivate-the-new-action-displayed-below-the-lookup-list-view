using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.SystemModule;

namespace RemoveNewButtonInLookups.Module {
    public abstract class DeactivateNewActionInLookupsController : ViewController {
        public DeactivateNewActionInLookupsController() {
            TargetViewType = ViewType.ListView;
        }
        protected override void OnActivated() {
            base.OnActivated();
            Frame.TemplateChanged += Frame_TemplateChanged;
            if (Frame.Template != null) {
                HideNewAction();
            }
        }
        void Frame_TemplateChanged(object sender, EventArgs e) {
            HideNewAction();
        }
        private void HideNewAction() {
            if (IsLookupTemplate()) {
                NewObjectViewController controller = Frame.GetController<NewObjectViewController>();
                controller.NewObjectAction.Active.SetItemValue("LookupListView", false);
            }
        }
        protected override void OnDeactivated() {
            base.OnDeactivated();
            Frame.TemplateChanged -= Frame_TemplateChanged;
        }
        protected abstract bool IsLookupTemplate();
    }
}
