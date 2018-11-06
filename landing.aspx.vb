Public Class landing
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'write your code here
    End Sub
    Protected Sub btnSelectTab2_Click(sender As Object, e As EventArgs) Handles btnSelectTab2.Click
        hfTab.Value = "tab2"
    End Sub
    Protected Sub btnSelectTab3_Click(sender As Object, e As EventArgs) Handles btnSelectTab3.Click
        hfTab.Value = "tab3"

    End Sub

End Class