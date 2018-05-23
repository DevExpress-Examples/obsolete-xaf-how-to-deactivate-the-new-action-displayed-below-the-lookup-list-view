Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.ExpressApp.SystemModule

Namespace RemoveNewButtonInLookups.Module
    Partial Public Class DeactivateNewActionInLookupsController
        Inherits ViewController
        Public Sub New()
            InitializeComponent()
            RegisterActions(components)
            TargetViewType = ViewType.ListView
        End Sub
        Protected Overrides Overloads Sub OnFrameAssigned()
            MyBase.OnFrameAssigned()
            AddHandler Frame.TemplateChanged, AddressOf Frame_TemplateChanged
        End Sub
        Private Sub Frame_TemplateChanged(ByVal sender As Object, ByVal e As EventArgs)
            If TypeOf Frame.Template Is ILookupPopupFrameTemplate Then
                Dim controller As NewObjectViewController = Frame.GetController(Of NewObjectViewController)()
                controller.NewObjectAction.Active.SetItemValue("LookupListView", False)
            End If
        End Sub
        Protected Overrides Overloads Sub OnDeactivated()
            MyBase.OnDeactivated()
            RemoveHandler Frame.TemplateChanged, AddressOf Frame_TemplateChanged
        End Sub
    End Class
End Namespace
