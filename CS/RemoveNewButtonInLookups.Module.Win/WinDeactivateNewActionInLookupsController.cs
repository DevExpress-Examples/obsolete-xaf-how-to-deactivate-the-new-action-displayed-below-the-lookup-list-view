using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.ExpressApp.Editors;

namespace RemoveNewButtonInLookups.Module.Win {
    public class WinDeactivateNewActionInLookupsController : DeactivateNewActionInLookupsController {
        protected override bool IsLookupTemplate() {
            return Frame.Template is ILookupPopupFrameTemplate;
        }
    }
}
