Namespace EBeneSystems
    Public Class EnrollmentController
        Inherits System.Web.Mvc.Controller

        '
        ' GET: /Enrollment

        'Function Index() As ActionResult
        '    Return View()
        'End Function

        Function Demographic() As ActionResult
            Return View()
        End Function
        <HttpPost()> _
        Function Demographic(ByVal model As DemographicModel) As ActionResult
            If ModelState.IsValid Then
                ' Call the function to save the information



            End If



            Return View(model)
        End Function
    End Class
End Namespace
