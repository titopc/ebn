@ModelType EBeneSystems.HomeModel
@Code
    ViewData("Title") = "Home Page"
End Code

<h2>@ViewData("Message")</h2>
@Using Html.BeginForm
    @<div>
    <p>
        To learn more about ASP.NET MVC visit <a href="http://asp.net/mvc" title="ASP.NET MVC Website">http://asp.net/mvc</a>.
    </p>
    <div>
    @Html.LabelFor(Function(m) m.SSN)
    @Html.EditorFor(Function(m) m.SSN)
    </div>

    <input type="submit" value="Enter"  />
    </div>
End Using