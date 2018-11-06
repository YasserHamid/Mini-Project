Imports System.Data.SqlClient

Public Class WebForm14
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As SqlConnection
        Dim sqlcmd As SqlCommand
        Dim cmd As String

        con = New SqlConnection(ConfigurationManager.ConnectionStrings("myCS").ConnectionString)
        Dim def As Integer = 0

        cmd = "Insert INTO [Venues] VALUES (@Address, @Image, @Name, @mID)"


        sqlcmd = New SqlCommand(cmd, con)
            sqlcmd.CommandType = CommandType.Text
            con.Open()

            sqlcmd.Parameters.AddWithValue("@Address", TextBox2.Text)
            sqlcmd.Parameters.AddWithValue("@Image", "default.png")
            sqlcmd.Parameters.AddWithValue("@Name", TextBox1.Text)
            sqlcmd.Parameters.AddWithValue("@mID", Integer.Parse(Session("MGID")))



            sqlcmd.ExecuteNonQuery()
            con.Close()
            sqlcmd.Dispose()

            Server.Transfer("~/MGVenues.aspx")


    End Sub
End Class