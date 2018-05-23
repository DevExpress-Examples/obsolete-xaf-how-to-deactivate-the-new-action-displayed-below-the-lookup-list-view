using System;
using System.Collections.Generic;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;

namespace RemoveNewButtonInLookups.Module.Web {
    public sealed partial class RemoveNewButtonInLookupsAspNetModule : ModuleBase {
        public RemoveNewButtonInLookupsAspNetModule() {
            InitializeComponent();
        }
        public override IEnumerable<ModuleUpdater> GetModuleUpdaters(IObjectSpace objectSpace, Version versionFromDB) {
            return ModuleUpdater.EmptyModuleUpdaters;
        }
    }
}
