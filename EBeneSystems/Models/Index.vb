Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Globalization
Public Class HomeModel
    <Required(), DisplayName("Social Security Number")> _
    Public Property SSN As String

End Class
