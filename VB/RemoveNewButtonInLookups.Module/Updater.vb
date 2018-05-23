Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.BaseImpl

Namespace RemoveNewButtonInLookups.Module
    Public Class Updater
        Inherits ModuleUpdater
        Public Sub New(ByVal objectSpace As ObjectSpace, ByVal currentDBVersion As Version)
            MyBase.New(objectSpace, currentDBVersion)
        End Sub
        Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
            MyBase.UpdateDatabaseAfterUpdateSchema()
            Dim department As Department = ObjectSpace.FindObject(Of Department)(CriteriaOperator.Parse("Title == 'Development Department'"))
            If department Is Nothing Then
                department = ObjectSpace.CreateObject(Of Department)()
                department.Title = "Development Department"
                department.Office = "101"
                department.Save()
            End If
            Dim employee As Employee = ObjectSpace.FindObject(Of Employee)(CriteriaOperator.Parse("FirstName == 'Robert' && LastName == 'King'"))
            If employee Is Nothing Then
                employee = ObjectSpace.CreateObject(Of Employee)()
                employee.FirstName = "Robert"
                employee.LastName = "King"
                employee.Department = department
                employee.Save()
            End If

        End Sub
    End Class
End Namespace
