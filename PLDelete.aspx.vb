Imports System.Data.SqlClient

Public Class WebForm11
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As SqlConnection
        Dim sqlcmd As SqlCommand

        Dim cmd As String


        cmd = "DELETE Players WHERE pID =" & Session("PLID")
        con = New SqlConnection(ConfigurationManager.ConnectionStrings("myCS").ConnectionString)

        Dim pass As String = TextBox1.Text

        Try





            If TextBox1.Text = Session("Password") Then

                sqlcmd = New SqlCommand(cmd, con)
                sqlcmd.CommandType = CommandType.Text
                sqlcmd.Connection.Open()
                sqlcmd.ExecuteNonQuery()
                sqlcmd.Connection.Close()
                sqlcmd.Connection.Dispose()
                con.Dispose()

                Session("LoggedIn") = -False
                Server.Transfer("~/Home.aspx")
            End If

        Catch ex As Exception

        End Try



    End Sub
End Class