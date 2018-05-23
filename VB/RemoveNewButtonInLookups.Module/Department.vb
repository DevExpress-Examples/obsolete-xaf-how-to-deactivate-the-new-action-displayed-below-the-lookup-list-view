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

'INSTANT VB NOTE: The variable title was renamed since Visual Basic does not allow variables and other class members to have the same name:
        Private _title As String
'INSTANT VB NOTE: The variable office was renamed since Visual Basic does not allow variables and other class members to have the same name:
        Private _office As String
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Property Title() As String
            Get
                Return _title
            End Get
            Set(ByVal value As String)
                SetPropertyValue("Title", _title, value)
            End Set
        End Property
        Public Property Office() As String
            Get
                Return _office
            End Get
            Set(ByVal value As String)
                SetPropertyValue("Office", _office, value)
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
