Imports System.Data.SqlClient

Public Class WebForm13
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("Manager") = False Then
            Button1.Visible = False
        End If

        Dim con As SqlConnection
        Dim sqlcmd As SqlCommand
        Dim reader As SqlDataReader
        Dim cmd As String
        Dim da As SqlDataAdapter
        Dim ds As DataSet


        Dim texter As String = ""

        con = New SqlConnection(ConfigurationManager.ConnectionStrings("myCS").ConnectionString)
        con.Open()

        cmd = "SELECT Address, Image, Name FROM Venues"
        da = New SqlDataAdapter(cmd, con)

        ds = New DataSet()
        da.Fill(ds)

        GridView1.DataSource = ds
        GridView1.DataBind()

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Server.Transfer("~/MGAddVenue.aspx")
    End Sub
End Class