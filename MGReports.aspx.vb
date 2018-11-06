Imports System.Data.SqlClient

Public Class WebForm16
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Dim con As SqlConnection

        'Dim cmd As String
        'Dim da As SqlDataAdapter
        'Dim ds As DataSet


        'Dim texter As String = ""

        'con = New SqlConnection(ConfigurationManager.ConnectionStrings("myCS").ConnectionString)
        'con.Open()

        'cmd = "SELECT COUNT(BookingID)AS BookingsIn2018 FROM [1v1Booking] WHERE Start > 01/01/2018"
        'da = New SqlDataAdapter(cmd, con)

        'ds = New DataSet()
        'da.Fill(ds)

        'GridView1.DataSource = ds
        'GridView1.DataBind()

        'con.Close()

        'loadResults()
    End Sub

    Protected Sub loadResults()
        'Dim con2 As SqlConnection

        'Dim cmd2 As String
        'Dim da2 As SqlDataAdapter
        'Dim ds2 As DataSet


        'Dim texter As String = ""

        'con2 = New SqlConnection(ConfigurationManager.ConnectionStrings("myCS").ConnectionString)
        'con2.Open()

        'cmd2 = "SELECT * FROM [1v1Result]"
        'da2 = New SqlDataAdapter(cmd2, con2)

        'ds2 = New DataSet()
        'da2.Fill(ds2)

        'GridView2.DataSource = ds2
        'GridView2.DataBind()

        'con2.Close()
    End Sub

End Class