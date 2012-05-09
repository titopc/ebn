Public Class Repo
    Public Function GetEmployee(ByVal strSSN As String) As DemographicModel
        Dim ctx As New SQLDBDataContext

        Dim table = (From c In ctx.tblEmployees
                     Where c.strEmployeeSSN = strSSN
                     Select c).FirstOrDefault

        If table Is Nothing Then

            ' We will have to send somthing here cause is giong to bomb if it's null.

        Else
            Dim model As New DemographicModel
            model.FirstName = table.strFName
            Return model

        End If


    End Function
End Class
