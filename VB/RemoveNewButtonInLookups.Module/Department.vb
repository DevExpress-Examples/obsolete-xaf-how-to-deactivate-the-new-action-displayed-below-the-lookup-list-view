Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel

Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation

Namespace RemoveNewButtonInLookups.Module
    <DefaultClassOptions, ImageName("BO_Department"), System.ComponentModel.DefaultProperty("Title")> _
    Public Class Department
        Inherits BaseObject
        Private title_Renamed As String
        Private office_Renamed As String
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Property Title() As String
            Get
                Return title_Renamed
            End Get
            Set(ByVal value As String)
                SetPropertyValue("Title", title_Renamed, value)
            End Set
        End Property
        Public Property Office() As String
            Get
                Return office_Renamed
            End Get
            Set(ByVal value As String)
                SetPropertyValue("Office", office_Renamed, value)
            End Set
        End Property
        <Association("Department-Employees")> _
        Public ReadOnly Property Employees() As XPCollection(Of Employee)
            Get
                Return GetCollection(Of Employee)("Employees")
            End Get
        End Property
    End Class
End Namespace
