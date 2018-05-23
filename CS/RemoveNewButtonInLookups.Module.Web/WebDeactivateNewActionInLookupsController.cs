using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.ExpressApp.Web.Templates;
using DevExpress.ExpressApp.Editors;

namespace RemoveNewButtonInLookups.Module.Win {
    public class WebDeactivateNewActionInLookupsController : DeactivateNewActionInLookupsController {
        protected override bool IsLookupTemplate() {
            var page = Frame.Template as BaseXafPage;
            if (page != null) 
                return page.TemplateContent is ILookupPopupFrameTemplate;
            return false;
        }
    }
}
