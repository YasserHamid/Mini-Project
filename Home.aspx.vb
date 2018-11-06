Public Class WebForm3
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("Username") = Nothing Then
            Session("LoggedIn") = False
        End If
    End Sub

End Class