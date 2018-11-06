Public Class WebForm5
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session("LoggedIn") = False
        Session("Username") = Nothing
        Session("Password") = Nothing
        Session("Manager") = False
        Session("Player") = False
        Session("PLID") = Nothing
        Session("MGID") = Nothing
        Server.Transfer("~/Home.aspx")
    End Sub

End Class