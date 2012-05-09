Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("Message") = "Welcome to your online enrollment"

        Return View()
    End Function
    <HttpPost()> _
    Function Index(ByVal model As HomeModel) As ActionResult

        Return RedirectToAction("Demographic", "Enrollment")
        ' Return View(model)
    End Function
    Function About() As ActionResult
        Return View()
    End Function
End Class
