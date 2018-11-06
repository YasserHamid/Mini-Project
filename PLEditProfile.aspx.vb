Imports System.Data.SqlClient

Public Class WebForm10
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadDetails()
    End Sub

    Protected Sub LoadDetails()


        If Not IsPostBack Then
            Dim con As SqlConnection
            Dim sqlcmd As SqlCommand
            Dim reader As SqlDataReader

            Dim id = Session("PLID")

            Dim cmd As String = "SELECT Name, Username, Password FROM Players WHERE pID =" & id

            con = New SqlConnection(ConfigurationManager.ConnectionStrings("myCS").ConnectionString)
            sqlcmd = New SqlCommand(cmd, con)

            sqlcmd.CommandType = CommandType.Text
            sqlcmd.Connection.Open()
            sqlcmd.ExecuteNonQuery()

            reader = sqlcmd.ExecuteReader
            reader.Read()

            TextBox1.Text = reader("Name")
            TextBox2.Text = reader("Username")
            TextBox3.Text = reader("Password")

            reader.Close()
            con.Close()
            con.Dispose()

            sqlcmd.Connection.Close()
            sqlcmd.Connection.Dispose()
            sqlcmd.Dispose()


        End If



    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As SqlConnection
        Dim sqlcmd As SqlCommand


        Dim id = Session("PLID")

        Dim cmd As String = "UPDATE [Players] SET [Name]='" & TextBox1.Text.ToString & "',[Username]='" & TextBox2.Text.ToString & "',[Password]='" & TextBox3.Text.ToString & "'WHERE pID =" & id

        con = New SqlConnection(ConfigurationManager.ConnectionStrings("myCS").ConnectionString)
        sqlcmd = New SqlCommand(cmd, con)
        Try
            Session("Username") = TextBox2.Text
            Session("Password") = TextBox3.Text
            sqlcmd.Connection.Open()
            sqlcmd.ExecuteNonQuery()
            sqlcmd.Connection.Close()
            sqlcmd.Connection.Dispose()
            con.Close()
            con.Dispose()



            Response.Redirect("~/PLProfile.aspx")
        Catch ex As Exception
            Label4.Text = "Failed"
        End Try



    End Sub
End Class