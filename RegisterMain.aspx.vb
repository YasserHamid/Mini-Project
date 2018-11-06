Imports System.Data.SqlClient

Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As SqlConnection
        Dim sqlcmd As SqlCommand
        Dim cmd As String

        con = New SqlConnection(ConfigurationManager.ConnectionStrings("myCS").ConnectionString)
        Dim def As Integer = 0

        cmd = "Insert INTO [Players] VALUES (@Name, @Username, @Password, @MatchesPlayed, @Victories, @Goals)"

        Try
            sqlcmd = New SqlCommand(cmd, con)
            sqlcmd.CommandType = CommandType.Text
            con.Open()

            sqlcmd.Parameters.AddWithValue("@Name", TextBox1.Text)
            sqlcmd.Parameters.AddWithValue("@Username", TextBox2.Text)
            sqlcmd.Parameters.AddWithValue("@Password", TextBox3.Text)
            sqlcmd.Parameters.AddWithValue("@MatchesPlayed", def)
            sqlcmd.Parameters.AddWithValue("@Victories", def)
            sqlcmd.Parameters.AddWithValue("@Goals", def)


            sqlcmd.ExecuteNonQuery()
            con.Close()
            sqlcmd.Dispose()

            Server.Transfer("~/LoginMain.aspx")
        Catch ex As Exception

        End Try







    End Sub


End Class