Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base

Imports DevExpress.ExpressApp.SystemModule

Public Class MyController
	Inherits DevExpress.ExpressApp.ViewController

	Public Sub New()
		MyBase.New()

		'This call is required by the Component Designer.
		InitializeComponent()
		RegisterActions(components) 

	End Sub

    Private Sub MyController_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        'By default, the List Views displayed in Lookup Editors contain "LookupListView" in their names
        If View.Id.EndsWith("LookupListView") Then
            Dim standardController As NewObjectViewController = Frame.GetController(Of NewObjectViewController)()
            If Not standardController Is Nothing Then
                standardController.Active.SetItemValue("LookupListView", False)
            End If
        End If
    End Sub

    Private Sub MyController_FrameAssigned(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FrameAssigned
        Frame.GetController(Of NewObjectViewController)().Active.SetItemValue("Custom", IsNewActionEnabled())
    End Sub
    'Define conditions under which the NewObjectViewController must be activated/deactivated
    Private Function IsNewActionEnabled() As Boolean
        Return (TypeOf View Is ListView) AndAlso View.IsRoot
    End Function
End Class
