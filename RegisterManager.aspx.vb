Imports System.Data.SqlClient

Public Class WebForm4
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As SqlConnection
        Dim sqlcmd As SqlCommand
        Dim cmd As String

        con = New SqlConnection(ConfigurationManager.ConnectionStrings("myCS").ConnectionString)

        cmd = "INSERT into [Managers] VALUES (@Name, @UserName, @Password)"


        sqlcmd = New SqlCommand(cmd, con)
            sqlcmd.CommandType = CommandType.Text
            con.Open()

            sqlcmd.Parameters.AddWithValue("@Name", TextBox1.Text)
            sqlcmd.Parameters.AddWithValue("@UserName", TextBox2.Text)
            sqlcmd.Parameters.AddWithValue("@Password", TextBox3.Text)

            sqlcmd.ExecuteNonQuery()
            con.Close()
            sqlcmd.Dispose()

            Server.Transfer("~/LoginMain.aspx")






    End Sub
End Class