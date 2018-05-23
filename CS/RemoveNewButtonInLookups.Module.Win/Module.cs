using System;
using System.Collections.Generic;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;

namespace RemoveNewButtonInLookups.Module.Win {
    public sealed partial class RemoveNewButtonInLookupsWinModule : ModuleBase {
        public RemoveNewButtonInLookupsWinModule() {
            InitializeComponent();
        }
        public override IEnumerable<ModuleUpdater> GetModuleUpdaters(IObjectSpace objectSpace, Version versionFromDB) {
            return ModuleUpdater.EmptyModuleUpdaters;
        }
    }
}
