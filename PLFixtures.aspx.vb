Imports System.Data.SqlClient

Public Class WebForm6
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim con2 As SqlConnection

            Dim cmd2 As String
            Dim da2 As SqlDataAdapter
            Dim ds2 As DataSet


        Dim texter As String = Session("Username").ToString


        con2 = New SqlConnection(ConfigurationManager.ConnectionStrings("myCS").ConnectionString)
            con2.Open()

        'cmd2 = "SELECT * FROM [1v1Result] WHERE pUsername1= 'frikki' OR pUsername2= 'frikki' " ' & texter '& " OR pUsername2=" & Session("Username")
        cmd2 = "SELECT * FROM [1v1Result] WHERE pUsername1= '" & texter & "' OR pUsername2= '" & texter & "' "   ' OR pUsername2= 'frikki' "
        da2 = New SqlDataAdapter(cmd2, con2)

        ds2 = New DataSet()
            da2.Fill(ds2)

            GridView1.DataSource = ds2
            GridView1.DataBind()

            con2.Close()


    End Sub

End Class