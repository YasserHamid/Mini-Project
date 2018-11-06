Imports System.Data.SqlClient

Public Class WebForm9
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text += Session("Username")

        Dim con As SqlConnection
        Dim sqlcmd As SqlCommand
        Dim reader As SqlDataReader
        Dim cmd As String
        Dim da As SqlDataAdapter
        Dim ds As DataSet


        Dim texter As String = ""

        con = New SqlConnection(ConfigurationManager.ConnectionStrings("myCS").ConnectionString)
        con.Open()

        cmd = "SELECT Name, Username, MatchesPlayed, Victories, Goals FROM Players WHERE pID =" & Session("PLID").ToString
        da = New SqlDataAdapter(cmd, con)

        ds = New DataSet()
        da.Fill(ds)

        GridView1.DataSource = ds
        GridView1.DataBind()
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Server.Transfer("~/PLEditProfile.aspx")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Server.Transfer("~/PLDelete.aspx")

    End Sub
End Class