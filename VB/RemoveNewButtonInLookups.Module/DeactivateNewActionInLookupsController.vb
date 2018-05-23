Imports System.ComponentModel
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.ExpressApp.SystemModule

Namespace RemoveNewButtonInLookups.Module
    Public MustInherit Class DeactivateNewActionInLookupsController
        Inherits ViewController

        Public Sub New()
            TargetViewType = ViewType.ListView
        End Sub
        Protected Overrides Sub OnFrameAssigned()
            MyBase.OnFrameAssigned()
            AddHandler Frame.TemplateChanged, AddressOf Frame_TemplateChanged
        End Sub
        Private Sub Frame_TemplateChanged(ByVal sender As Object, ByVal e As EventArgs)
            If IsLookupTemplate() Then
                Dim controller As NewObjectViewController = Frame.GetController(Of NewObjectViewController)()
                controller.NewObjectAction.Active.SetItemValue("LookupListView", False)
            End If
        End Sub
        Protected Overrides Sub OnDeactivated()
            MyBase.OnDeactivated()
            RemoveHandler Frame.TemplateChanged, AddressOf Frame_TemplateChanged
        End Sub
        Protected MustOverride Function IsLookupTemplate() As Boolean
    End Class
End Namespace
