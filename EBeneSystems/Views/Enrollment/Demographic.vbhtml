@ModelType EBeneSystems.DemographicModel
@Code
    ViewData("Title") = "Employee Information"
End Code

<h2>Employee Information</h2>
<table>
<tr>
<td valign="top">
<fieldset>
<legend>General</legend>
            <div class="editor-label">
                @Html.LabelFor(Function(m) m.FirstName)
            </div>
            <div class="editor-field">
                @Html.TextBoxFor(Function(m) m.FirstName)
                @Html.ValidationMessageFor(Function(m) m.FirstName)
            </div>

            <div class="editor-label">
                @Html.LabelFor(Function(m) m.MiddleName)
            </div>
            <div class="editor-field">
                @Html.TextBoxFor(Function(m) m.MiddleName)
                @Html.ValidationMessageFor(Function(m) m.MiddleName)
            </div>

            <div class="editor-label">
                @Html.LabelFor(Function(m) m.LastName)
            </div>
            <div class="editor-field">
                @Html.TextBoxFor(Function(m) m.LastName)
                @Html.ValidationMessageFor(Function(m) m.LastName)
            </div>

            <div class="editor-label">
                @Html.LabelFor(Function(m) m.DOB)
            </div>
            <div class="editor-field">
                @Html.TextBoxFor(Function(m) m.DOB)
                @Html.ValidationMessageFor(Function(m) m.DOB)
            </div>

            <div class="editor-label">
                @Html.LabelFor(Function(m) m.Gender)
            </div>
            <div class="editor-field">
                @Html.TextBoxFor(Function(m) m.Gender)
                @Html.ValidationMessageFor(Function(m) m.Gender)
            </div>

            <div class="editor-label">
                @Html.LabelFor(Function(m) m.Smoker)
            </div>
            <div class="editor-field">
                @Html.TextBoxFor(Function(m) m.Smoker)
                @Html.ValidationMessageFor(Function(m) m.Smoker)
            </div>
</fieldset>
</td>
<td valign="top">
<fieldset>
<legend>Demographics</legend>
            <div class="editor-label">
                @Html.LabelFor(Function(m) m.Address1)
            </div>
            <div class="editor-field">
                @Html.TextBoxFor(Function(m) m.Address1)
                @Html.ValidationMessageFor(Function(m) m.Address1)
            </div>

            <div class="editor-label">
                @Html.LabelFor(Function(m) m.Address2)
            </div>
            <div class="editor-field">
                @Html.TextBoxFor(Function(m) m.Address2)
                @Html.ValidationMessageFor(Function(m) m.Address2)
            </div>

            <div class="editor-label">
                @Html.LabelFor(Function(m) m.City)
            </div>
            <div class="editor-field">
                @Html.TextBoxFor(Function(m) m.City)
                @Html.ValidationMessageFor(Function(m) m.City)
            </div>

            <div class="editor-label">
                @Html.LabelFor(Function(m) m.State)
            </div>
            <div class="editor-field">
                @Html.TextBoxFor(Function(m) m.State)
                @Html.ValidationMessageFor(Function(m) m.State)
            </div>

            <div class="editor-label">
                @Html.LabelFor(Function(m) m.Zip)
            </div>
            <div class="editor-field">
                @Html.TextBoxFor(Function(m) m.Zip)
                @Html.ValidationMessageFor(Function(m) m.Zip)
            </div>

            <div class="editor-label">
                @Html.LabelFor(Function(m) m.HomePhone)
            </div>
            <div class="editor-field">
                @Html.TextBoxFor(Function(m) m.HomePhone)
                @Html.ValidationMessageFor(Function(m) m.HomePhone)

            <div class="editor-label">
                @Html.LabelFor(Function(m) m.Cell)
            </div>
            <div class="editor-field">
                @Html.TextBoxFor(Function(m) m.Cell)
                @Html.ValidationMessageFor(Function(m) m.Cell)
            </div>
            </div>
</fieldset>
</td>
@*<td valign="bottom">
<input type="submit" value="Next"  />
</td>*@
</tr>
</table>


<input id="Submit" type="submit" value="Next"  />

