Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Globalization
Public Class DemographicModel
    <Required(), DisplayName("First Name")> _
    Public Property FirstName As String

    <Required(), DisplayName("Middle Name")> _
    Public Property MiddleName As String

    <Required(), DisplayName("Last Name")> _
    Public Property LastName As String

    <Required(), DisplayName("DOB")> _
    Public Property DOB As String

    <Required(), DisplayName("Gender")> _
    Public Property Gender As String

    <Required(), DisplayName("Address")> _
    Public Property Address1 As String

    <Required(), DisplayName("Address (cont.)")> _
    Public Property Address2 As String

    <Required(), DisplayName("City")> _
    Public Property City As String

    <Required(), DisplayName("State")> _
    Public Property State As String

    <Required(), DisplayName("Zipcode")> _
    Public Property Zip As String

    <Required(), DisplayName("Home Phone")> _
    Public Property HomePhone As String

    <Required(), DisplayName("CellPhone")> _
    Public Property Cell As String

    <Required(), DisplayName("Smoker")> _
    Public Property Smoker As String


    'Private newPasswordValue As String
    'Private confirmPasswordValue As String

    '<Required()> _
    '<DataType(DataType.Password)> _
    '<Display(Name:="Current password")> _
    'Public Property OldPassword() As String
    '    Get
    '        Return oldPasswordValue
    '    End Get
    '    Set(ByVal value As String)
    '        oldPasswordValue = value
    '    End Set
    'End Property

End Class
