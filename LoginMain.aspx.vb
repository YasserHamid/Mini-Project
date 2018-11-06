Imports System.Data.SqlClient

Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As SqlConnection
        Dim sqlcmd As SqlCommand
        Dim reader As SqlDataReader
        Dim cmd As String

        cmd = "SELECT pID, Name, Username, Password, MatchesPlayed, Victories, Goals FROM Players"

        con = New SqlConnection(ConfigurationManager.ConnectionStrings("myCS").ConnectionString)

        Dim user As String
        Dim pass As String

        user = TextBox2.Text
        pass = TextBox3.Text

        Try
            con.Open()
            sqlcmd = New SqlCommand(cmd, con)
            reader = sqlcmd.ExecuteReader()
            While reader.Read
                If reader.Item(2) = user Then
                    If pass = reader.Item(3) Then
                        Session("Username") = reader.Item(2)
                        Session("Password") = reader.Item(3)
                        Session("LoggedIn") = True
                        Session("Player") = True
                        Session("PLID") = reader.Item(0)

                        Server.Transfer("~/Home.aspx")

                    End If
                End If



            End While

            If Session("LoggedIn") = False Then
                MsgBox("Log In Failed")
            End If

        Catch ex As Exception

        End Try

        con.Close()







    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim con As SqlConnection
        Dim sqlcmd As SqlCommand
        Dim reader As SqlDataReader
        Dim cmd As String

        cmd = "SELECT * FROM Managers"

        con = New SqlConnection(ConfigurationManager.ConnectionStrings("myCS").ConnectionString)

        Dim user As String
        Dim pass As String

        user = TextBox2.Text
        pass = TextBox3.Text

        Try
            con.Open()
            sqlcmd = New SqlCommand(cmd, con)
            reader = sqlcmd.ExecuteReader()
            While reader.Read
                If reader.Item(2) = user Then
                    If pass = reader.Item(3) Then
                        Session("Username") = reader.Item(2)
                        Session("LoggedIn") = True
                        Session("MGID") = reader.Item(0)
                        Session("Manager") = True

                        Server.Transfer("~/Home.aspx")

                    End If

                End If



            End While

            If Session("LoggedIn") = False Then
                MsgBox("Log In Failed")
            End If

        Catch ex As Exception

        End Try


    End Sub
End Class