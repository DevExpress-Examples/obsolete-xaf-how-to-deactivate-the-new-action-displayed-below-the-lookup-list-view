Imports System.Text
Imports DevExpress.ExpressApp.Web.Templates
Imports DevExpress.ExpressApp.Editors

Namespace RemoveNewButtonInLookups.Module.Win
    Public Class WebDeactivateNewActionInLookupsController
        Inherits DeactivateNewActionInLookupsController

        Protected Overrides Function IsLookupTemplate() As Boolean
            Dim page = TryCast(Frame.Template, BaseXafPage)
            If page IsNot Nothing Then
                Return TypeOf page.TemplateContent Is ILookupPopupFrameTemplate
            End If
            Return False
        End Function
    End Class
End Namespace
