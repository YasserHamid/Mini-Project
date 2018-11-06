Imports System.Data.SqlClient

Public Class WebForm8
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim con As SqlConnection

        Dim cmd As String
        Dim da As SqlDataAdapter
        Dim ds As DataSet


        Dim texter As String = ""

        con = New SqlConnection(ConfigurationManager.ConnectionStrings("myCS").ConnectionString)
        con.Open()

        cmd = "SELECT Username, MatchesPlayed, Victories, Goals FROM Players"
        da = New SqlDataAdapter(cmd, con)

        ds = New DataSet()
        da.Fill(ds)

        GridView1.DataSource = ds
        GridView1.DataBind()


    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged

    End Sub
End Class