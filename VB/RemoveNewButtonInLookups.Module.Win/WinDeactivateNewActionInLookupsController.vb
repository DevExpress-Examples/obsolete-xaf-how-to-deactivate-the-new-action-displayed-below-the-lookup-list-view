Imports DevExpress.ExpressApp.Editors

Namespace RemoveNewButtonInLookups.Module.Win
    Public Class WinDeactivateNewActionInLookupsController
        Inherits DeactivateNewActionInLookupsController

        Protected Overrides Function IsLookupTemplate() As Boolean
            Return TypeOf Frame.Template Is ILookupPopupFrameTemplate
        End Function
    End Class
End Namespace
