Imports System.ComponentModel

Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation

Namespace RemoveNewButtonInLookups.Module
    <DefaultClassOptions, ImageName("BO_Person"), DefaultProperty("FullName")> _
    Public Class Employee
        Inherits BaseObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
'INSTANT VB NOTE: The variable firstName was renamed since Visual Basic does not allow variables and other class members to have the same name:
        Private _firstName As String
        Public Property FirstName() As String
            Get
                Return _firstName
            End Get
            Set(ByVal value As String)
                SetPropertyValue("FirstName", _firstName, value)
            End Set
        End Property
'INSTANT VB NOTE: The variable lastName was renamed since Visual Basic does not allow variables and other class members to have the same name:
        Private _lastName As String
        Public Property LastName() As String
            Get
                Return _lastName
            End Get
            Set(ByVal value As String)
                SetPropertyValue("LastName", _lastName, value)
            End Set
        End Property
        Public ReadOnly Property FullName() As String
            Get
                Return String.Format("{0} {1}", FirstName, LastName)
            End Get
        End Property
'INSTANT VB NOTE: The variable department was renamed since Visual Basic does not allow variables and other class members to have the same name:
        Private _department As Department
        <Association("Department-Employees")> _
        Public Property Department() As Department
            Get
                Return _department
            End Get
            Set(ByVal value As Department)
                SetPropertyValue("Department", _department, value)
            End Set
        End Property
    End Class
End Namespace
